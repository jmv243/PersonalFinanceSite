using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using System.Data.Entity;
using PersonalFinanceSite.Db;
using PersonalFinanceSite.Db.Types;

namespace PersonalFinanceSIte.Logic
{
    public class AddressLogicProvider : IAddressLogicProvider
    {
        private PersonalFinanceSiteData db;

        public AddressLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

        public void AddAddressInformation(IAddressInformation addressInfo)
        {                        
            //db.AddressInformation.Add(addressInfo);
            db.SaveChanges();
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