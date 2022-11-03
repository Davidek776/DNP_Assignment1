namespace Domain.DTOs;

public class SearchUserParametersDto
{
    public string? Username { get; }
    public string? password { get; }

    public SearchUserParametersDto(string? username, string? Password)
    {
        Username = username;
        password = Password;
    }

}