using System;
using System.Collections.Generic;
using System.Text;
using Application.Contracts;
using Application.ViewModels;

namespace UI.Client.Services;

public class FakeQotdService : IQotdService
{
    public QuoteOfTheDayViewModel GetQuoteOfTheDayViewModel()
    {
        return new QuoteOfTheDayViewModel
        {
            Id = new Guid(),
            AuthorName = "Test",
            AuthorDescription = "Test Description",
            AuthorBirthDate = new DateOnly(2026, 11, 13),
            QuoteText = "Lirum larum Löffelstiel"
        };
    }
}