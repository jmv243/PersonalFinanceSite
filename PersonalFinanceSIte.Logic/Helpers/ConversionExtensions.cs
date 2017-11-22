using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PersonalFinanceSIte.Logic
{
    public static class ConversionExtensions
    {
        /// <summary>
        /// This method can be dangerous!
        /// The types have to match exactly in order for this to work!
        /// </summary>
        /// <typeparam name="OldType"></typeparam>
        /// <typeparam name="NewType"></typeparam>
        /// <param name="T"></param>
        /// <returns></returns>
        public static NewType FromInterfaceToEntity<OldType, NewType>(this OldType T)
        {
            string jsonObject = JsonConvert.SerializeObject(T);
            return JsonConvert.DeserializeObject<NewType>(jsonObject);
        }
    }
}
