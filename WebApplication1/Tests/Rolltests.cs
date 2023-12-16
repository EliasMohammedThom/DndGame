
namespace Tests
{
    public class Rolltests : IClassFixture<RollTestFixture>
    {
        private Rolls RollService { get; set; }
        [Fact]
        public void Test1()
        {
            //Arrange
            RollService.RollforStats();

            //Act 

            //Assert


        }
    }
}