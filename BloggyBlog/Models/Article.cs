using System.ComponentModel.DataAnnotations;

namespace BloggyBlog.Models;

public class Article
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Content { get; set; }
    public string Blogger { get; set; }
}