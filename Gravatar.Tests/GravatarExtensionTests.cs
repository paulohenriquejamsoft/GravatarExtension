using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar")]
        [TestMethod("Should validate Gravatar Extension")]
        [DataRow(null, 200,  false)]
        [DataRow("", 200,  false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("a@andre.com", 200, false)]
        [DataRow("scariodes1895@gmail.com", null, true)] 
         [DataRow("scariodes1895@gmail.com", 200,  true)]         
        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            //4eedd55ffb4ebb3ee9786955a581dcab
            var imageSize = size.HasValue? size.Value.ToString() : "80";
            var result = $"https://www.gravatar.com/avatar/4eedd55ffb4ebb3ee9786955a581dcab?s={imageSize}";
            Assert.AreEqual((email.ToGravatar(size ?? 80))  == result, status);
        }
    }
}
