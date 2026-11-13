using System;
using System.Collections.Generic;
using System.Text;
using Application.ViewModels;

namespace Application.Contracts;

public interface IQotdService
{
    QuoteOfTheDayViewModel GetQuoteOfTheDayViewModel();
}