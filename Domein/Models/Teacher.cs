namespace Domein.Models;

public class Teacher
{
    public int Teacher_id { get; set; }
    public int Teacher_code { get; set; }
    public string Teacher_full_name { get; set; }
    public string Gender { get; set; }
    public DateTime Dob { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool Is_active { get; set; }
    public DateTime Join_date { get; set; }
    public int Working_days { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    
}