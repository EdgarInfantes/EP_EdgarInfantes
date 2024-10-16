using System;
using System.Collections.Generic;

namespace Parcial.Data;

public partial class JobOffer
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Salary { get; set; }

    public string? Location { get; set; }
}
