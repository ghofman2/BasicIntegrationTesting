using System.ComponentModel.DataAnnotations;

namespace Vault.Data.Models.Base
{
  public class Entity
  {
    [Key]
    public virtual int Id { get; set; }
  }
}
