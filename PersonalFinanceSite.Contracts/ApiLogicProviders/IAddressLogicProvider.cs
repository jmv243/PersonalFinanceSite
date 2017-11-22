using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    public interface IAddressLogicProvider
    {
        IAddressInformation AddAddressInformation(IAddressInformation addressInfo);
        IAddressInformation GeAddressByPK(Guid addressPK);
        IAddressInformation GetUserAddress(Guid userFK);
        IAddressInformation UpdateAddressInformation(IAddressInformation addressInformation);
        IAddressInformation DeleteAddressInformation(Guid addressPK);
    }
}
