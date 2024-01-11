
namespace Tests
{
    public class Rolltests : IClassFixture<RollTestFixture>
    {
        private Rolls? RollService { get; set; } = null;
        [Theory]
        [InlineData]
        public void Test1()
        {
            //Arrange
            var number = RollService.RollforStats();

            //Act 


            //Assert


        }
    }
}