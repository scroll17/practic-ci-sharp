using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР08
{
    class Сountry
    {
        private string name;
        private string president;
        private int population;
        private decimal square;

       private static int countryCount = 0;
       private static decimal sumOfAllSquareCountries = 0;

        public string Name {
            get {
                return name;
            }
        }

        public string President {
            get
            {
                return president;
            }
            set
            {
                president = value;
            }
        }


        public int Population {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }

        public decimal Square { 
            get
            {
                return square;
            }
            set
            {
                square = value;
            }
        }

        public decimal Density {
            get
            {
                return GetDensity();
            }
        }

        public Сountry()
        {
            name = "Default";
            president = "Default President";
            population = 1000;
            square = 100;

            UpdateSummaryStaticFields();
        }

        ~Сountry()
        {
            
        }
    
        public Сountry(string name, string president, int population, decimal square)
        {
            this.name = name;
            this.president = president;
            this.population = population;
            this.square = square;

            UpdateSummaryStaticFields();
        }

        public Сountry(Сountry country)
        {
            this.name = country.name;
            this.president = country.president;
            this.population = country.population;
            this.square = country.square;

            UpdateSummaryStaticFields();
        }

        private decimal GetDensity()
        {
            return population / square;
        }

        private void UpdateSummaryStaticFields()
        {
            countryCount++;
            sumOfAllSquareCountries += GetDensity();
        }

        public static int FlightsCount {
            get {
                return countryCount;
            }
        }

        public static decimal getSumOfAllSquareCountries
        {
            get
            {
                return sumOfAllSquareCountries;
            }
        }
    }
}
