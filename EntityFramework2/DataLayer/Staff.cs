using System;
using System.Collections.Generic;

namespace EntityFramework2.DataLayer;

public partial class Staff
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public int? Salary { get; set; }
}
