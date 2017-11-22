using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PersonalFinanceSIte.Logic;

namespace PersonalFinanceSite.Tests
{
    public class ApiLogicProviderTests
    {
        [Test]
        public void TestClassInitialization()
        {
            ApiLogicProvider provider = new ApiLogicProvider();
        }
    }
}
