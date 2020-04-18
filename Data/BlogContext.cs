using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) {}

        public DbSet<Blog> Blogs { get; set; }
    }
    
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}