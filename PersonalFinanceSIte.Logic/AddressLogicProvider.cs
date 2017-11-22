using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSIte.Logic
{
    public class AddressLogicProvider : IAddressLogicProvider
    {
        public void AddAddressInformation()
        {
            throw new NotImplementedException();
        }

        public IAddressInformation DeleteAddressInformation(Guid addressPK)
        {
            throw new NotImplementedException();
        }

        public IAddressInformation GeAddressByPK(Guid addressPK)
        {
            throw new NotImplementedException();
        }

        public IAddressInformation GetUserAddress(Guid userFK)
        {
            throw new NotImplementedException();
        }

        public IAddressInformation UpdateAddressInformation(IAddressInformation addressInformation)
        {
            throw new NotImplementedException();
        }
    }
}