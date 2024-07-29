using BloggyBlog.Models;

namespace BloggyBlog;

using Microsoft.EntityFrameworkCore;

public class BloggyBlogDbContext(DbContextOptions<BloggyBlogDbContext> options) : DbContext(options)
{
    public DbSet<Article> Articles { get; set; }
}
