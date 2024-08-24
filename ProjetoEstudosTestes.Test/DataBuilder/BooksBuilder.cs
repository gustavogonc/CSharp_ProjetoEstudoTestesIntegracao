using Bogus;
using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Testes.Test.DataBuilder;

namespace ProjetoEstudosTestes.Test.DataBuilder
{
    public class BooksBuilder
    {
        public Books Build()
        {
            DateTime minYear = DateTime.Parse("01/01/1950");
            DateTime maxYear = DateTime.Parse("01/01/2024");

            Books books = new Faker<Books>()
                .RuleFor(b => b.Author, f => f.Person.FullName)
                .RuleFor(b => b.User, f => new UsersBuilder().Build())
                .RuleFor(b => b.Title, f => f.Random.Words())
                .RuleFor(b => b.IsbnCode, f => f.Random.Word())
                .RuleFor(c => c.EditedOn, f => f.Date.Recent(10))
                .RuleFor(c => c.CreatedOn, f => f.Date.Recent(5))
                .RuleFor(c => c.PublicationYear, f => f.Date.Between(minYear, maxYear).Year)
                .RuleFor(c => c.CopiesAvailable, f => f.Random.Number(1, 100))
                .Generate();

            return books;
        }
    }
}
