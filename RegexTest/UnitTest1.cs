using RegularExpressions;

namespace RegexTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            string name = "Anitha";
            string expected = "Anitha";
            RegularExpressions.RegularExp exp = new RegularExpressions.RegularExp();
            exp.firstnameValidation(name);
            Assert.AreEqual(name, expected);
        }
    }
}