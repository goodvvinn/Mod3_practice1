using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mod3_practice1
{
    public class Culture
    {
        public CultureInfo GetCultureInfo(string name)
        {
            return CultureInfo.GetCultureInfo(name);
        }
    }
}
