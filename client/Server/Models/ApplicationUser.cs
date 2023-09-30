using Microsoft.AspNetCore.Identity;

namespace client.Server.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

        // Custom properties
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        // Navigation properties
        public virtual ICollection<TodoList> TodoLists { get; set; } = new List<TodoList>();
        public virtual ICollection<SharedList> SharedLists { get; set; } = new List<SharedList>();
    }
}
