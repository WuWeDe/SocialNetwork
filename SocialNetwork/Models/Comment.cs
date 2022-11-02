using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    [Table("Comment")]
    [Keyless]
    public class Comment
    {

        public string Content { get; set; }
        public Guid AuthorId { get; set; }
        [NotMapped]
        public User Author { get; set; }
        public Guid PostId { get; set; }
        [NotMapped]
        public Post Post { get; set; }
    }
}
