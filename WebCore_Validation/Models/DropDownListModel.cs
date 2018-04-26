using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_Validation.Models
{
      public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}
