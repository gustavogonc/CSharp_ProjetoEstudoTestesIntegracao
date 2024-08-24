using Bogus;
using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudoTestes.Testes.Test.DataBuilder
{
    public class UsersBuilder
    {

        public Users Build()
        {
            Users u = new Faker<Users>("pt_BR")
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.Password, f => f.Internet.Password())
                .RuleFor(c => c.Name, f => f.Person.FullName)
                .RuleFor(c => c.CreatedOn, f => f.Date.Recent(10))
                .RuleFor(c => c.EditedOn, f => f.Date.Recent(10))
                .RuleFor(c => c.Role, f => f.Random.Guid())
                .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
                .Generate();

            return u;
        }
    }
}
