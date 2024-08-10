using Flunt.Validations;

namespace ProjetoEstudoTestes.Domain
{
    public sealed class Users : BaseEntity
    {
        public string Name { get; set; }
        public Guid Role { get; set; }
        public string? Email { get ; set; }  
        public string? PhoneNumber { get; set; }


        public Users()
        {
            
        }

        public Users(string name, Guid role, string? email, string? phoneNumber)
        {
            Name = name;
            Role = role;
            Email = email;
            PhoneNumber = phoneNumber;
            EditedOn = DateTime.Now;
            DateTime = DateTime.Now;

            Validate();
        }

        private void Validate()
        {
            var contract = new Contract<Users>()
                .IsNullOrEmpty(Name, "Name", "O nome do usuário não pode estar em branco")
                .IsNullOrWhiteSpace(Name, "Name", "O nome do usuário não pode estar sem caracteres")
                .IsGreaterThan(Name, 10, "Name", "O nome precisa ter mais de 10 caracteres");


            AddNotifications(contract);
        }

        public void EditInfo(string name, Guid role, string? email, string? phoneNumber)
        {
            Name = name;
            Role = role;
            Email = email;
            PhoneNumber = phoneNumber;
            EditedOn = DateTime.Now;

            Validate();
        }
    }

    
}
