using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models.XmlModels;

namespace Vault.Data.ViewModels
{
  public class CcdaModel
  {
    public CcdaModel()
    {
      //Initalizations
      this.Sections = new List<Section>();
      this.PatientContainer = new PatientContainer();
      this.PatientContainer.Address = new Address();
      this.PatientContainer.Patient = new Patient();
      this.PatientContainer.ProviderOrganization = new Organization();
      this.PatientContainer.ProviderOrganization.Address = new Address();
      this.Author = new Author();
      this.Author.Address = new Address();
      this.Author.ProviderOrganization = new Organization();
      this.Author.ProviderOrganization.Address = new Address();
      this.Informant = new Informant();
      this.Informant.Address = new Address();
      this.Informant.RepresentedOrganization = new Organization();
      this.Informant.RepresentedOrganization.Address = new Address();
      this.AssignedEntity = new AssignedEntity();
      this.AssignedEntity.Address = new Address();
      this.AssignedEntity.AssignedPerson = new AssignedPerson();
      this.Authenticator = new Authenticator();
      this.Authenticator.Address = new Address();
      this.Authenticator.RepresentedOrganization = new Organization();
      this.Authenticator.RepresentedOrganization.Address = new Address();
      this.LegalAuthenticator = new LegalAuthenticator();
      this.LegalAuthenticator.Address = new Address();
      this.LegalAuthenticator.RepresentedOrganization = new Organization();
      this.LegalAuthenticator.RepresentedOrganization.Address = new Address();
      this.Custodian = new Custodian();
      this.Custodian.Address = new Address();
      this.Performer = new Performer();
      this.Performer.Address = new Address();
    }

    public List<Section> Sections { get; set; }

    public String DocumentTitle { get; set; }

    public PatientContainer PatientContainer { get; set;}

    public Author Author { get; set; }

    public Informant Informant { get; set; }

    public AssignedEntity AssignedEntity { get; set; }

    public Authenticator Authenticator { get; set; }

    public LegalAuthenticator LegalAuthenticator { get; set; }

    public Custodian Custodian { get; set; }

    public Performer Performer { get; set; }



    //above section level, currently leaving out legal authenticator, authenticator, custodian
  }
}
