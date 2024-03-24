using Microsoft.Extensions.Hosting;

namespace StackOverflowMVC.Models
{
    public class Badge
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int UserId { get; set; }
        public DateTime Date { get; set; }

        public Post Post { get; set; }
    }
}
