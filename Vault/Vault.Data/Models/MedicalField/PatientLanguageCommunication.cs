using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.MedicalField
{
  public class PatientLanguageCommunication
  {
    public List<string> TemplateIds { get; set; }

    public string LanguageCode { get; set; }

    public bool PreferenceInd { get; set; }
  }
}
