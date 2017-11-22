using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using System.Data.Entity;
using PersonalFinanceSite.Db;
using PersonalFinanceSite.Db.Types;
using System.Linq;

namespace PersonalFinanceSIte.Logic
{
    public class AddressLogicProvider : IAddressLogicProvider
    {
        private PersonalFinanceSiteData db;

        public AddressLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

        public IAddressInformation AddAddressInformation(IAddressInformation addressInfo)
        {
            //TODO: make sure the user doesn't already have an address saved

            AddressInformation info = addressInfo.FromInterfaceToEntity<IAddressInformation, AddressInformation>();
            db.AddressInformation.Add(info);
            db.SaveChanges();

            return info;
        }

        public IAddressInformation DeleteAddressInformation(Guid addressPK)
        {
            AddressInformation info = db.AddressInformation.Where(x => x.AddressInformationPK == addressPK).FirstOrDefault();
            db.AddressInformation.Remove(info);
            db.SaveChanges();

            return info;
        }

        public IAddressInformation GeAddressByPK(Guid addressPK)
        {
            AddressInformation info = db.AddressInformation.Where(x => x.AddressInformationPK == addressPK).FirstOrDefault();

            return info;
        }

        public IAddressInformation GetUserAddress(Guid userFK)
        {
            AddressInformation address = db.AddressInformation.Where(x => x.UserFK == userFK).FirstOrDefault();
            return address;
        }

        public IAddressInformation UpdateAddressInformation(IAddressInformation addressInformation)
        {
            AddressInformation info = addressInformation.FromInterfaceToEntity<IAddressInformation, AddressInformation>();
            var fetch = db.AddressInformation.Where(x => x.AddressInformationPK == info.AddressInformationPK).FirstOrDefault();
            fetch = info;

            db.SaveChanges();

            return fetch;
        }
    }
}