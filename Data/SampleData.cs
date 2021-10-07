using System.Collections.Generic;
using labW5.Models;
public class SampleData {
  public static List<Province> GetProvinces() {
      List<Province> provinces = new List<Province>() {
         new Province() {
            ProvinceCode="BC",
            ProvinceName="British Columbia",
         },
         new Province() {
            ProvinceCode="AB",
            ProvinceName="Alberta",
         },
         new Province() {
            ProvinceCode="ON",
            ProvinceName="Ontario",
         },
      };

      return provinces;
  }

  public static List<City> GetCities() {
      List<City> cities = new List<City>() {
         new City {
             CityId = 1,
             CityName = "Vancouver",
             Population = 2264823,
             ProvinceCode = "BC"
         },
         new City {
             CityId = 2,
             CityName = "Victoria",
             Population = 335696,
             ProvinceCode = "BC"
         },
         new City {
             CityId = 3,
             CityName = "Kelowna",
             Population = 151957,
             ProvinceCode = "BC"
         },
         new City {
             CityId = 4,
             CityName = "Calgary",
             Population = 1392609,
             ProvinceCode = "AB"
         },
        new City {
             CityId = 5,
             CityName = "Edmonton",
             Population = 1321426,
             ProvinceCode = "AB"
         },
         new City {
             CityId = 6,
             CityName = "Red Deer",
             Population = 99718,
             ProvinceCode = "AB"
         },
        new City {
             CityId = 7,
             CityName = "Toronto",
             Population = 2700000,
             ProvinceCode = "ON"
         },
        new City {
             CityId = 8,
             CityName = "Ottawa",
             Population = 934243,
             ProvinceCode = "ON"
         },
         new City {
             CityId = 9,
             CityName = "Mississauga",
             Population = 721599,
             ProvinceCode = "ON"
         },
      };

      return cities;
  }

}