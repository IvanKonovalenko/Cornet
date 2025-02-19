public class User
{
    public int? UserId { get; set; }
    public string Email { get; set; } = null!;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Password { get; set; } = null!;
    public string Salt { get; set; } = null!;
    public Role Role { get; set; }
    public Organization Organization { get; set; } = null!;
}