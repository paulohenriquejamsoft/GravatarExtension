using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar")]
        [TestMethod("Should validate Gravatar Extension")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("a@andre.com", false)]
        [DataRow("scariodes1895@gmail.com", true)]        
        public void ShouldValidateGravatar(string email, bool status)
        {
            //4eedd55ffb4ebb3ee9786955a581dcab
            var result = "https://www.gravatar.com/avatar/4eedd55ffb4ebb3ee9786955a581dcab";
            Assert.AreEqual((email.ToGravatar())  == result, status);
        }
    }
}
