namespace NHTLesson11.Models;

public partial class Nhtemployee
{
    public int NhtempId { get; set; }

    public string? NhtempName { get; set; }

    public string? NhtempLevel { get; set; }

    public DateOnly? NhtempStartDate { get; set; }

    public bool? NhtempStatus { get; set; }
}
