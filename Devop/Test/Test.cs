using NUnit.Framework;
using System;
namespace Test
{
   [TestFixture()]
   public class Test
   {
      [Test()]
      public void TestCase()
      {
			
      }


		[Test()]
        public void TestAdd()
        {
			Assert.AreEqual(28, 28); 
        }



		[Test()]
        public void TestSub()
        {
			Assert.AreEqual(28, 20); 
        }
   }
}
