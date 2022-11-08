namespace Domain.DTOs;

public class UserRegisterDto
{
    public int Id { get; }

    public string UserName { get; }
    public string password { get; }
    
    public UserRegisterDto( string UserName,string password)
    {
       
        this.UserName = UserName;
        this.password = password;
    }
}