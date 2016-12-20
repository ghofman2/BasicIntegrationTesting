using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.MedicalField
{
  public class PatientName
  {
    public string Use { get; set; }

    public string Prefix { get; set; }

    public PatientNameGiven[] Given { get; set; }

    public string Family { get; set; }
  }
}
