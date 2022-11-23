using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Post
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string title { get; set; }
    [MaxLength(150)]

    public string body { get; set; }
    
    

    public Post(string title, string body)
    {
       
        this.title = title;
        this.body = body;
    }
    
    
}