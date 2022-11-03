namespace Domain.Models;

public class User
{
    public User(string UserName,string password)
    {
        this.UserName = UserName;
        this.password = password;
    }


    public string UserName { get; set; }
    public string password { get; set; }
}