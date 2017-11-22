using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using NUnit.Framework;
using PersonalFinanceSIte.Logic;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSite.Tests
{
    public class AddressLogicProviderTests : IAddressLogicProvider
    {
        //system under test
        AddressLogicProvider _provider;

        public AddressLogicProviderTests()
        {
            PersonalFinanceSiteData db = new PersonalFinanceSiteData();
            _provider = new AddressLogicProvider(db);
        }

        [Test]
        public IAddressInformation AddAddressInformation(IAddressInformation addressInfo)
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
