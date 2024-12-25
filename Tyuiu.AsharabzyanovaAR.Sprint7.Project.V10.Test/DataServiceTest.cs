using Tyuiu.AsharabzyanovaAR.Sprint7.Project.V10.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrixTest()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InputFileTest.csv";
            string[,] waitArray = { { "-19", "-4", "13", "-11"},
                                    {"5", "2", "16", "83"},
                                    {"-14", "78", "3", "2"},
                                    {"42", "-9", "54", "10"} };
            string[,] resArray = ds.GetMatrix(path);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}