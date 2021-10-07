using System.ComponentModel.DataAnnotations.Schema;

public class City {
   public int CityId { get; set; } //if this follows rule of [name of class] + Id, it'll automatically know this is PK
   public string CityName { get; set; }
   public int Population { get; set; }

// relationship
   public string ProvinceCode { get; set; }

   [ForeignKey("ProvinceCode")]
   public Province Province { get; set; }
}