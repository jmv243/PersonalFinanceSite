using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using NUnit.Framework;

namespace PersonalFinanceSite.Tests
{
    public class AddressLogicProviderTests : IAddressLogicProvider
    {
        [Test]
        public void AddAddressInformation()
        {
            throw new NotImplementedException();
        }

        [Test]
        public IAddressInformation DeleteAddressInformation(Guid addressPK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IAddressInformation GeAddressByPK(Guid addressPK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IAddressInformation GetUserAddress(Guid userFK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IAddressInformation UpdateAddressInformation(IAddressInformation addressInformation)
        {
            throw new NotImplementedException();
        }
    }
}
