using System;
using System.Collections.Generic;

namespace Variant3_trofimov.Models;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
