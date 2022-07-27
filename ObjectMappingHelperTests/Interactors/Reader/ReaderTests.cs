using NUnit.Framework;
using ObjectMappingHelper.Interactors;

namespace ObjectMappingHelperTests
{
    public class ReaderTests
    {
        Reader reader;
        [SetUp]
        public void Setup()
        {
            reader = new Reader(); 
        }
        /// <summary>
        /// Reader is not null
        /// </summary>
        [Test]
        public void CreateReader()
        {
            Assert.IsNotNull(reader);
        }
    }
}
