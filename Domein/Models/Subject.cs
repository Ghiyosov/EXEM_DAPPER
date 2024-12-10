namespace Domein.Models;

public class Subject
{
    public int Subject_id { get; set; }
    public string Title { get; set; }
    public int school_id { get; set; }
    public int Stage { get; set; }
    public int Term { get; set; }
    public int Carry_mark { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}