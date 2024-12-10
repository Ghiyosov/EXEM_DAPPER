namespace Domein.Models;

public class Class
{
    public int Class_id { get; set; }
    public string Class_name { get; set; }
    public int Subject_id { get; set; }
    public int Teacher_id { get; set; }
    public int Classroom_id { get; set; }
    public string Section { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}