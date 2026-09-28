using Tyuiu.LopushanskayaMS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.LopushanskayaMS.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);
            Assert.Equal("Привет, Игорь",res);
        }
    }
}