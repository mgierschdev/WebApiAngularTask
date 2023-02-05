namespace Domain.Model;

public class Role
{
    public string RoleName { get; set; }
    public DateTime CreationTime { get; set; }

    public Role(string RoleName)
    {
        this.RoleName = RoleName;
        CreationTime = DateTime.Now;
    }
}
