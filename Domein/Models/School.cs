namespace Domein.Models;

public class School
{
    public int School_id { get; set; }
    public string Title { get; set; }
    public int Level_count { get; set; }
    public bool Is_active { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}