namespace Domain.DTOs;

public class UserBasicDto
{
    public int Id { get; }

    public string UserName { get; }
    public string password { get; }
    
    public UserBasicDto(int Id, string UserName,string password)
    {
        this.Id = Id;
        this.UserName = UserName;
        this.password = password;
    }
    
}