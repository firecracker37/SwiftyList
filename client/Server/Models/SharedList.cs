using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace client.Server.Models
{
    public class SharedList
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool CanEdit { get; set; } = true;
        public string TodoListId { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey("TodoListId")]
        public TodoList TodoList { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
