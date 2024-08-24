using ProjetoEstudoTestes.Domain;
using ProjetoEstudoTestes.Testes.Test.DataBuilder;

namespace ProjetoEstudosTestes.Test
{
    public class UserTest
    {
        [Theory]
        [InlineData("Teste Gutavo HardCoded", "1234566667789")]
        [InlineData("Teste HardCoded", "6667789")]
        [InlineData("Gustavo Gonçalves Dev", "9871134")]
        public void GivenARandomData_WhenCorrectParams_UserShouldBeValid(string name, string password)
        {
            //Arrange 
            var user = new Users(name, password, Guid.NewGuid(), "", "");

            //Act + Assert
            Assert.True(user.IsValid);
        }

        [Fact]
        public void GivenAValidUser_WhenCorrectParams_UserShouldBeValid()
        {
            //Arrange
            var user = new Users("Teste Gutavo HardCoded", "123456", Guid.NewGuid(), "", "");

            //Act + Assert
            Assert.True(user.IsValid);
        }
        [Fact]
        public void GivenAnInvalidUser_WhenIncorrectParams_UserShouldNotBeValid()
        {
            //Arrange
            var user = new Users("t", "", Guid.NewGuid(), "", "");

            //Act + Assert
            Assert.False(user.IsValid);
        }

        [Fact]
        public void GivenARandomUser_WhenCorrectParams_UserShouldBeValid()
        {
            //Arrange
            var user = new UsersBuilder().Build();

            //Act + Assert
            Assert.True(user.IsValid);
        }
    }
}