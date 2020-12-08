using Microsoft.EntityFrameworkCore;

namespace NameThat.Models
{
    public class ResultContext: DbContext
    {
        public ResultContext(DbContextOptions<ResultContext> options) : base(options)
        {
        }
        
        public DbSet<Result> Result { get; set; }
    }
}