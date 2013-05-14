using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Unit.Tests
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Fact]
        [Trait("category","smoke")]
        public void Test2()
        {
            Assert.True(true);
        }
    }
}
