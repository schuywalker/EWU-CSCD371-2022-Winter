using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqStuff.Tests
{
    // Mark was here
    public static class IEnumerableEx
    {
        static public IEnumerable<T> Filter<T>(
            this IEnumerable<T> items,  
            Predicate<T> filterExpression)
        {
            // Intentionally not using Where() linq standard query operator
            foreach(var item in items)
            {
                if(filterExpression(item))
                {
                    yield return item;
                }
            }
        }
    }


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckDataFileExists()
        {
            string fullPath =
                Path.Combine(
                    Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!,
                    "Data", "Data.txt");
            Assert.IsTrue(File.Exists(fullPath));
                
        }

        [DeploymentItem("Data\\Data.txt")]
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.IsTrue(File.Exists("Data\\Data.txt"));
        }

        [TestMethod]
        public void TestMethod1()
        {
            List<Person> kimList = new();
            List<Person> list = new();
            // ADd items
            IEnumerable<Person> persons = list;
            //persons.
            IEnumerable<string> firstNames = list.Where(item => item.LastName == "Kim")
                .Select(item => item.FirstName);

            IEnumerable<(string FirstName, string LastName)>? fullNameObjects = 
                list.Select(item => (item.FirstName, item.LastName));


            foreach (Person item in list)
            {
                if(item.LastName == "Kim")
                {
                    kimList.Add(item);
                }
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            List<string> kimList = new();
            List<Person> list = new();
            // ADd items
            foreach (Person item in list)
            {
                if (item.LastName == "Kim")
                {
                    kimList.Add(item.FirstName);
                }
            }
        }
    }
}