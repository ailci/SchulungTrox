using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities;

public class Author
{
    //[Key]
    public Guid Id { get; set; } // ID, Id, AuthorId
    public required string Name { get; set; }
    public required string Description { get; set; }
    public DateOnly? BirthDate { get; set; }
    public ICollection<Quote>? Quotes { get; set; }
}
