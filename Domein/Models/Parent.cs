namespace Domein.Models;

public class Parent
{
    public int Parent_id { get; set; }
    public string Parent_code { get; set; }
    public string Parent_full_name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}