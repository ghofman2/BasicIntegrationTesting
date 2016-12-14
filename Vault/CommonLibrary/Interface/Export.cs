using System;
using System.Collections.Generic;

namespace CommonLibrary.Interface
{
  public interface Export : IDisposable
  {
    List<Parameter> getParameters();
    void setParameters(List<Parameter> parameters);
    void ExportPatient(Patient data, List<Parameter> parameters = null);
    void ExportPatients(List<Patient> data, List<Parameter> parameters = null);
    void ExportPagedPatients(List<Patient> data, List<Parameter> parameters = null);
    void ExportAppointment(Appointment data, List<Parameter> parameters = null);
    void ExportAppointments(List<Appointment> data, List<Parameter> parameters = null);
    void ExportPagedAppointments(List<Appointment> data, List<Parameter> parameters = null);
    void ExportImage(PatientImage data, List<Parameter> parameters = null);
    void ExportImages(List<PatientImage> data, List<Parameter> parameters = null);
  }
}
