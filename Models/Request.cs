using System;
using System.Collections.Generic;

namespace Variant3_trofimov.Models;

public partial class Request
{
    public int id { get; set; }

    public string RequestNumber { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Type { get; set; }

    public string? ProblemDescription { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public int Status { get; set; }

    public int? MasterId { get; set; }

    public virtual User? Master { get; set; }
}
