using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models.Base;
using Vault.Data.Models.Enums;

namespace Vault.Data.Models
{
  public class CustomField : Entity
  {
    public int FieldNumber { get; set; }

    public String FieldName { get; set; }

    public DataTypes.DataType DbType { get; set; }

    public int CabinetId { get; set; }

    public virtual Cabinet Cabinet { get; set; }


  }
}
