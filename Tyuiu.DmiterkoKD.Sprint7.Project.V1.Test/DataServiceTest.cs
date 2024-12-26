using Tyuiu.DmiterkoKD.Sprint7.Project.V1.Lib;
namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            string p = @"File\JuguarInPutFile.csv";
            string res = ds.CollectTextFromFile(p, 0, 4);
            Assert.AreEqual(res, " 4");
        }
    }
}