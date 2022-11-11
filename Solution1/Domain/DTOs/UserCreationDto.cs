namespace Domain.DTOs;

public class UserCreationDto
{   
    // public int Id { get; }
    public string UserName { get;}
    public string password { get;}

    public UserCreationDto(string userName,string password)
    {
        
        UserName = userName;
        this.password = password;
    }
}