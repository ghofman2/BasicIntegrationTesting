using System.ComponentModel.DataAnnotations;

namespace Vault.Data.Models.Medical
{
  public class Address
  {
    public string Use { get; set; }

    [Display(Name = "Street Address")]
    public string StreetAddress { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    [Display(Name = "Postal Code")]
    public string PostalCode { get; set; }

    public string Country { get; set; }
  }
}
