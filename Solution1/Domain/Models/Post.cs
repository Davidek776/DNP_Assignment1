namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string title { get; }
    public string body { get; }
    public User Owner { get; }

    public Post(User owner, string title, string body)
    {
        this.Owner = owner;
        this.title = title;
        this.body = body;
    }
}