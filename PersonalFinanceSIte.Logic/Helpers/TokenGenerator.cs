using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSIte.Logic
{
    public class TokenGenerator
    {
        public string GenerateRandomToken()
        {
            DateTime dt = DateTime.Now;
            byte[] bytes = Encoding.ASCII.GetBytes(dt.ToString() + Guid.NewGuid().ToString().Replace("-", ""));
            return Convert.ToBase64String(bytes);
        }
    }
}
