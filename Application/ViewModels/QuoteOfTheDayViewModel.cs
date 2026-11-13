using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels;

public class QuoteOfTheDayViewModel
{
    public Guid Id { get; init; }
    public required string QuoteText { get; init; }
    public required string AuthorName { get; init; }
    public required string AuthorDescription { get; init; }
    public DateOnly? AuthorBirthDate { get; init; }
}