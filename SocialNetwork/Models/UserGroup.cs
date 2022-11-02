using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    [Table("UserGroup")]
    [Keyless]
    public class UserGroup
    {
        public Guid GroupId { get; set; }
        [NotMapped]
        public Group Group { get; set; }
        public Guid UserId { get; set; }
        [NotMapped]
        public User User { get; set; }

    }
}
