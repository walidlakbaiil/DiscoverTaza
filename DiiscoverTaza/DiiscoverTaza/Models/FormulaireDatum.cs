using System;
using System.Collections.Generic;

namespace DiiscoverTaza.Models;

public partial class FormulaireDatum
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Subject { get; set; }

    public string? Question { get; set; }
}
