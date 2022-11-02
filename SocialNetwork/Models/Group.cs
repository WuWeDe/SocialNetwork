using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    [Keyless]
    public class Group
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }
        [NotMapped]
        public ICollection<UserGroup> UserInGroup { get; set; }
        [NotMapped]
        public ICollection<Post> PostInGroup { get; set; }
    }
}
