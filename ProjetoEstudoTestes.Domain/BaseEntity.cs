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
        public Guid EditeBy { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
