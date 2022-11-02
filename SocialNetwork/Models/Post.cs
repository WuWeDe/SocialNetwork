using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    [Table("Post")]
    [Keyless]
    public class Post
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public Guid AuthorID { get; set; }
        [NotMapped]
        public User Author { get; set; }
        [NotMapped]
        public ICollection<Comment> Comments { get; set; }
    }
}
