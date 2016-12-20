using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models.MedicalField;

namespace Vault.Data.Models.Medical
{
  public class Patient
  {
    public PatientName Name { get; set; }

    public PatientGender AdministrativeGenderCode { get; set; }

    public DateTime BirthTime { get; set; }

    public PatientMaritalStatus MaritalStatusCode { get; set; }

    public PatientReligiousAffiliation ReligiousAffiliationCode { get; set; }

    public PatientRaceCode RaceCode { get; set; }

    public PatientEhinicGroup EthnicGroupCode { get; set; }

    public PatientLanguageCommunication LanguageCommunication{ get; set; }
  }
}
