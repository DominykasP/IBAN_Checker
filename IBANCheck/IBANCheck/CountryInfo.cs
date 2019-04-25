using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANCheck
{
    public struct CountryInfo
    {
        public int lenght;
        public string regex;

        public CountryInfo(int lenght, string regex)
        {
            this.lenght = lenght;
            this.regex = regex;
        }
    }
}
