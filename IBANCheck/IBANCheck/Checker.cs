using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IBANCheck
{
    public class Checker
    {
        Dictionary<string, CountryInfo> countries; //Holds country code as key; number of chars and regex as value

        public Checker()
        {
            fillCountries();
        }

        public int CheckIBAN(string IBAN)
        {
            string formattedIBAN = IBAN.ToUpper().Replace(" ", string.Empty);

            if (!CheckGeneralStructure(formattedIBAN))
                return 1; //Provided IBAN is structured incorrectly

            if (!CheckCountryCode(formattedIBAN))
                return 2; //Country code of provided IBAN is incorrect

            if (!CheckCountryLenght(formattedIBAN))
                return 3; //Total IBAN length for this country is incorrect

            if (!CheckCountryStructure(formattedIBAN))
                return 4; //Provided IBAN is structured incorrectly for this country

            if (!ValidateByChechDigits(formattedIBAN))
                return 5; //Provided IBAN is incorrect

            return 0; //Provided IBAN is correct
        }

        public void CheckIBANsFromFile(string[] IBANs)
        {
            for (int i = 0; i < IBANs.Length; i++)
            {
                if (CheckIBAN(IBANs[i]) == 0)
                    IBANs[i] += ";true";
                else
                    IBANs[i] += ";false";
            }
        }

        private bool CheckGeneralStructure(string IBAN) //Check if provided IBAN is structured correctly
        {
            if (Regex.IsMatch(IBAN, @"^[A-Z]{2}\d{2}[A-Z0-9]{1,30}$"))
                return true;
            else
                return false;
        }

        private bool CheckCountryCode(string IBAN) //Check if country code of provided IBAN is correct
        {
            string countryCode = IBAN.Substring(0, 2);

            if (countries.ContainsKey(countryCode))
                return true;
            else
                return false;
        }

        private bool CheckCountryLenght(string IBAN) //Check if total IBAN length for this country is correct
        {
            string countryCode = IBAN.Substring(0, 2);

            if (IBAN.Length == countries[countryCode].lenght)
                return true;
            else
                return false;
        }

        private bool CheckCountryStructure(string IBAN) //Check if provided IBAN is structured correctly for this country
        {
            string countryCode = IBAN.Substring(0, 2),
                   BBAN = IBAN.Substring(4, IBAN.Length - 4);

            if (Regex.IsMatch(BBAN, countries[countryCode].regex))
                return true;
            else
                return false;
        }

        private bool ValidateByChechDigits(string IBAN) //Validate provided IBAN by check digits
        {
            int numberToInsert;
            StringBuilder numberedIBAN = new StringBuilder();
            string finalIBAN;

            numberedIBAN.Append(IBAN.Substring(4, IBAN.Length - 4)); //Moving four initial characters to the end of the string
            numberedIBAN.Append(IBAN.Substring(0, 4));

            for (int i = 0; i < numberedIBAN.Length; i++) //Replacing each letter in the string with two digits, where A = 10, B = 11, ..., Z = 35
            {
                if (Char.IsLetter(numberedIBAN[i]))
                {
                    numberToInsert = numberedIBAN[i] - 55;
                    numberedIBAN.Remove(i, 1);
                    numberedIBAN.Insert(i, numberToInsert);
                    i++;
                }
            }

            finalIBAN = numberedIBAN.ToString();

            int remainder = int.Parse(finalIBAN.Substring(0, 1));
            for (int i = 1; i < finalIBAN.Length; i++)
            {
                numberToInsert = int.Parse(finalIBAN.Substring(i, 1));
                remainder *= 10;
                remainder += numberToInsert;
                remainder %= 97;
            }

            if (remainder == 1)
                return true;
            else
                return false;
        }

        private void fillCountries() //Fills a dictionary of countries with data from Wikipedia
        {
            countries = new Dictionary<string, CountryInfo>()
            {
                {"AL", new CountryInfo(28, @"^\d{8}[A-Z0-9]{16}$") },
                {"AD", new CountryInfo(24, @"^\d{8}[A-Z0-9]{12}$") },
                {"AT", new CountryInfo(20, @"^\d{16}$") },
                {"AZ", new CountryInfo(28, @"^[A-Z0-9]{4}\d{20}$") },
                {"BH", new CountryInfo(22, @"^[A-Z]{4}[A-Z0-9]{14}$") },
                {"BY", new CountryInfo(28, @"^[A-Z0-9]{4}\d{20}$") },
                {"BE", new CountryInfo(16, @"^\d{12}$") },
                {"BA", new CountryInfo(20, @"^\d{16}$") },
                {"BR", new CountryInfo(29, @"^\d{23}[A-Z]{1}[A-Z0-9]{1}$") },
                {"BG", new CountryInfo(22, @"^[A-Z]{4}\d{6}[A-Z0-9]{8}$") },
                {"CR", new CountryInfo(22, @"^\d{18}$") },
                {"HR", new CountryInfo(21, @"^\d{17}$") },
                {"CY", new CountryInfo(28, @"^\d{8}[A-Z0-9]{16}$") },
                {"CZ", new CountryInfo(24, @"^\d{20}$") },
                {"DK", new CountryInfo(18, @"^\d{14}$") },
                {"DO", new CountryInfo(28, @"^[A-Z]{4}\d{20}$") },
                {"TL", new CountryInfo(23, @"^\d{19}$") },
                {"EE", new CountryInfo(20, @"^\d{16}$") },
                {"FO", new CountryInfo(18, @"^\d{14}$") },
                {"FI", new CountryInfo(18, @"^\d{14}$") },
                {"FR", new CountryInfo(27, @"^\d{10}[A-Z0-9]{11}\d{2}$") },
                {"GE", new CountryInfo(22, @"^[A-Z0-9]{2}\d{16}$") },
                {"DE", new CountryInfo(22, @"^\d{18}$") },
                {"GI", new CountryInfo(23, @"^[A-Z]{4}[A-Z0-9]{15}$") },
                {"GR", new CountryInfo(27, @"^\d{7}[A-Z0-9]{16}$") },
                {"GL", new CountryInfo(18, @"^\d{14}$") },
                {"GT", new CountryInfo(28, @"^[A-Z0-9]{4}[A-Z0-9]{20}$") },
                {"HU", new CountryInfo(28, @"^\d{24}$") },
                {"IS", new CountryInfo(26, @"^\d{22}$") },
                {"IE", new CountryInfo(22, @"^[A-Z0-9]{4}\d{14}$") },
                {"IL", new CountryInfo(23, @"^\d{19}$") },
                {"IT", new CountryInfo(27, @"^[A-Z]{1}\d{10}[A-Z0-9]{12}$") },
                {"JO", new CountryInfo(30, @"^[A-Z]{4}\d{22}$") },
                {"KZ", new CountryInfo(20, @"^\d{3}[A-Z0-9]{13}$") },
                {"XK", new CountryInfo(20, @"^\d{4}\d{10}\d{2}$") },
                {"KW", new CountryInfo(30, @"^[A-Z]{4}[A-Z0-9]{22}$") },
                {"LV", new CountryInfo(21, @"^[A-Z]{4}[A-Z0-9]{13}$") },
                {"LB", new CountryInfo(28, @"^\d{4}[A-Z0-9]{20}$") },
                {"LI", new CountryInfo(21, @"^\d{5}[A-Z0-9]{12}$") },
                {"LT", new CountryInfo(20, @"^\d{16}$") },
                {"LU", new CountryInfo(20, @"^\d{3}[A-Z0-9]{13}$") },
                {"MT", new CountryInfo(31, @"^[A-Z]{4}\d{5}[A-Z0-9]{18}$") },
                {"MR", new CountryInfo(27, @"^\d{23}$") },
                {"MU", new CountryInfo(30, @"^[A-Z]{4}\d{19}[A-Z]{3}$") },
                {"MD", new CountryInfo(24, @"^[A-Z0-9]{2}[A-Z0-9]{18}$") },
                {"MC", new CountryInfo(27, @"^\d{10}[A-Z0-9]{11}\d{2}$") },
                {"ME", new CountryInfo(22, @"^\d{18}$") },
                {"NL", new CountryInfo(18, @"^[A-Z]{4}\d{10}$") },
                {"MK", new CountryInfo(19, @"^\d{3}[A-Z0-9]{10}\d{2}$") },
                {"NO", new CountryInfo(15, @"^\d{11}$") },
                {"PK", new CountryInfo(24, @"^[A-Z0-9]{4}\d{16}$") },
                {"PS", new CountryInfo(29, @"^[A-Z0-9]{4}\d{21}$") },
                {"PL", new CountryInfo(28, @"^\d{24}$") },
                {"PT", new CountryInfo(25, @"^\d{21}$") },
                {"QA", new CountryInfo(29, @"^[A-Z]{4}[A-Z0-9]{21}$") },
                {"RO", new CountryInfo(24, @"^[A-Z]{4}[A-Z0-9]{16}$") },
                {"SM", new CountryInfo(27, @"^[A-Z]{1}\d{10}[A-Z0-9]{12}$") },
                {"SA", new CountryInfo(24, @"^\d{2}[A-Z0-9]{18}$") },
                {"RS", new CountryInfo(22, @"^\d{18}$") },
                {"SK", new CountryInfo(24, @"^\d{20}$") },
                {"SI", new CountryInfo(19, @"^\d{15}$") },
                {"ES", new CountryInfo(24, @"^\d{20}$") },
                {"SE", new CountryInfo(24, @"^\d{20}$") },
                {"CH", new CountryInfo(21, @"^\d{5}[A-Z0-9]{12}$") },
                {"TN", new CountryInfo(24, @"^\d{20}$") },
                {"TR", new CountryInfo(26, @"^\d{5}[A-Z0-9]{17}$") },
                {"AE", new CountryInfo(23, @"^\d{3}\d{16}$") },
                {"GB", new CountryInfo(22, @"^[A-Z]{4}\d{14}$") },
                {"VA", new CountryInfo(22, @"^\d{3}\d{15}$") },
                {"VG", new CountryInfo(24, @"^[A-Z0-9]{4}\d{16}$") }
            };
        }
    }
}
