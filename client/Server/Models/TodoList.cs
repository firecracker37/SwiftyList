using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace client.Server.Models
{
    public class TodoList
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Title { get; set; }

        public bool IsPublic { get; set; } = true;

        [Required]
        public Guid UserId { get; set; }

        // Navigation properties
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

        public virtual ICollection<SharedList> SharedLists { get; set; } = new List<SharedList>();
    }
}
