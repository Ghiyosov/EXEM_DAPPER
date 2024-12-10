namespace Domein.Models;

public class Student
{
    public int Student_id { get; set; }
    public string Student_code { get; set; }
    public string Student_full_name { get; set; }
    public string Gender { get; set; }
    public DateTime Dob { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int School_id { get; set; }
    public int Stage { get; set; }
    public string Section { get; set; }
    public bool Is_active { get; set; }
    public DateTime Join_date { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}