namespace Domein.Models;

public class Classroom
{
    public int Classroom_id { get; set; }
    public int Capacity { get; set; }
    public int Room_typ { get; set; }
    public string Description { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}