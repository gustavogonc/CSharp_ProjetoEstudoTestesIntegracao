using Flunt.Notifications;

namespace ProjetoEstudoTestes.Domain
{
    public class BaseEntity : Notifiable<Notification>
    {

        public BaseEntity()
        {
                Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime EditedOn { get; set; }
        public Users EditeBy { get; set; }
        public Users CreatedBy { get; set; } 
        public DateTime DateTime { get; set; }
    }
}
