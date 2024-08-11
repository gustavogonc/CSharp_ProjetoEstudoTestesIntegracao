using ProjetoEstudoTestes.Domain;

namespace ProjetoEstudosTestes.Test
{
    public class UserTest
    {

        [Fact]
        public void GivenAnValidUserWhenCorrectParamsUserShouldBeValid()
        {
            //Arrange
            var user = new Users("Teste Gutavo HardCoded", "123456", Guid.NewGuid(), "", "");

            //Act + Assert
            Assert.True(user.IsValid);
        }
        [Fact]
        public void GivenAnInvalidUserWhenIncorrectParamsUserShouldNotBeValid()
        {
            //Arrange
            var user = new Users("t", "", Guid.NewGuid(), "", "");

            //Act + Assert
            Assert.False(user.IsValid);
        }
    }
}