using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

   public class City {
      public int CityId { get; set; } //if this follows rule of [name of class] + Id, it'll automatically know this is PK
   [Display(Name="City")]
      public string CityName { get; set; }
      public int Population { get; set; }

   // relationship
   [Display(Name="Province Code")]
      public string ProvinceCode { get; set; }

      [ForeignKey("ProvinceCode")]
   [Display(Name="Province")]
      public Province Province { get; set; }
   }