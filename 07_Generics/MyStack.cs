using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _07_Generics;

public class MyStack
{
    private readonly int _size;
    private readonly object[] _elements;
    private int _pointer = 0;

    public MyStack(int size)
    {
        _size = size;
        _elements = new object[size];
    }

    public void Push(object element)
    {
        if (_pointer >= _size)
        {
            throw new StackOverflowException();
        }

        _elements[_pointer] = element;
        _pointer++;
    }

    public object Pop()
    {
        _pointer--;
        if (_pointer >= 0)
        {
            return _elements[_pointer];
        }
        else
        {
            _pointer = 0;
            throw new InvalidOperationException("Der Stack ist leer");
        }
    }

    public int Length => this._pointer;
}

public class MyStack<T>
{
    private readonly int _size;
    private readonly T[] _elements;
    private int _pointer = 0;

    public MyStack(int size)
    {
        _size = size;
        _elements = new T[size];
    }

    public void Push(T element)
    {
        if (_pointer >= _size)
        {
            throw new StackOverflowException();
        }

        _elements[_pointer] = element;
        _pointer++;
    }

    public T Pop()
    {
        _pointer--;
        if (_pointer >= 0)
        {
            return _elements[_pointer];
        }
        else
        {
            _pointer = 0;
            throw new InvalidOperationException("Der Stack ist leer");
        }
    }

    public int Length => this._pointer;
}