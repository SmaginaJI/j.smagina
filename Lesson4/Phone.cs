using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Phone
    {
        private string _CityCode;
        private string _PhoneNumber;

        public Phone(string cityCode, string phoneNumber)
        {
            _CityCode = cityCode;
            _PhoneNumber = phoneNumber;
        }

        public string PhoneNumber
        {
            get {return _PhoneNumber;}
            set
            {
                if (value == null)
                    return;
                _PhoneNumber = value;
            }
        }

        public string GetPhone()
        {
            if (_CityCode == string.Empty || _CityCode == null)
            {
                return _PhoneNumber;
            }
            else
            {
                return string.Format("({0}) {1}", _CityCode, _PhoneNumber);
            }
        }

    }
}
