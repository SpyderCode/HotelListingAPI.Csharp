using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Country
{
    public abstract class BaseCountryDTO
    {
        [Required]
        public String Name { get; set; }
        public string ShortName { get; set; }
    }
}
