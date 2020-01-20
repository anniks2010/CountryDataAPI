using System;
using System.Collections.Generic;
using System.Text;

namespace CountryDataAPI
{
    public class CountryDetails
    {
        public string Name { get; set; }
        public string Cioc { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        
        public List<CountryDetails> Languages { get; set; }
        public List<string> TopLevelDomain { get; set; }
     

        public class Language
        {
            public string Name { get; set; }
        }
       
        
    }
   
}
