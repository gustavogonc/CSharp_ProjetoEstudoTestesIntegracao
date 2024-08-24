using Flunt.Validations;

namespace ProjetoEstudoTestes.Domain
{
    public sealed class Users : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }    
        public Guid Role { get; set; }
        public string? Email { get ; set; }  
        public string? PhoneNumber { get; set; }
        public List<Books>? Books { get; set; }   


        public Users()
        {
            
        }

        public Users(string name, string password, Guid role, string? email, string? phoneNumber)
        {
            Name = name;
            Role = role;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            EditedOn = DateTime.Now;
            CreatedOn = DateTime.Now;

            Validate();
        }

        private void Validate()
        {
            var contract = new Contract<Users>()
                .IsNotNullOrEmpty(Name, "Name", "O nome do usuário não pode estar em branco")
                .IsNotNullOrWhiteSpace(Name, "Name", "O nome do usuário não pode estar sem caracteres")
                .IsGreaterOrEqualsThan(Name, 10, "Name", "O nome precisa ter mais de 10 caracteres")
                .IsNotNullOrEmpty(Password, "Password", "Senha não pode estar em branco ou ser null");


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
