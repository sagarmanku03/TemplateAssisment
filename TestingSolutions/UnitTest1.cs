using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingSolutions;

namespace TemplateAssisment
{
    [TestClass]
    public class RRclasstest
    {
        RRclass rr = new RRclass();

        [TestMethod]
        public void TestShootAway()
        {
          
            Assert.IsTrue("GunShootButton.Test");
        }
        
        [ TestMethod]
        public void TestReloadRevolver()
        { 
        
        }
    }
}
