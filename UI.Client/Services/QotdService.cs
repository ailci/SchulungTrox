using System;
using System.Collections.Generic;
using System.Text;
using Application.Contracts;
using Application.ViewModels;
using Data;
using Microsoft.EntityFrameworkCore;

namespace UI.Client.Services;

public class QotdService(QotdDbContext context) : IQotdService
{
    public QuoteOfTheDayViewModel GetQuoteOfTheDayViewModel()
    {
        var quotes = context.Quotes.Include(a => a.Author).ToList(); //Include auch Autoren holen

        var randomQuote = quotes.Shuffle().First(); // C#13 mischen

        //Manuelles Mapping (alternative AutoMapper)
        return new QuoteOfTheDayViewModel
        {
            Id = randomQuote.Id,
            AuthorName = randomQuote.Author?.Name ?? string.Empty,
            AuthorDescription = randomQuote.Author?.Description ?? string.Empty,
            AuthorBirthDate = randomQuote.Author?.BirthDate,
            QuoteText = randomQuote.QuoteText
        };
    }
}