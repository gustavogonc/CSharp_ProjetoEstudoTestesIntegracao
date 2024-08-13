using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudosTestes.Test
{
    public class BooksTest
    {
        [Fact]
        public void GivenAnInvalidBook_WhenIncorrectParams_BookShouldNotBeValid()
        {
            //Arrange
            var book = new Books("Título de Livro Teste", "Teste", Guid.NewGuid(), "1550300", 2024, 0);

            //Act + Assert
            Assert.False(book.IsValid);
        }
    }
}
