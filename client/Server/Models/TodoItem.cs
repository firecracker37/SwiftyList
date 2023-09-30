using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace client.Server.Models
{
    public class TodoItem
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime? DueDate { get; set; }
        public string TodoListId { get; set; }

        [ForeignKey("TodoListId")]
        public virtual TodoList TodoList { get; set; }
    }
}
