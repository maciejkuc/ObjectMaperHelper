using NUnit.Framework;
using ObjectMappingHelper;

namespace ObjectMappingHelperTests
{
    public class ObjectMappingControlerTests
    {
        ObjectMappingControler objectMappingControler;

        [SetUp]
        public void Setup()
        {
            objectMappingControler = new ObjectMappingControler();
        }
        /// <summary>
        /// Controler is not null
        /// </summary>
        [Test]
        public void CreateObjectMappingController()
        {            
            Assert.IsNotNull(objectMappingControler);
        }
    }
}