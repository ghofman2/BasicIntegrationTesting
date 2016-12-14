using System;
using System.Collections.Generic;

namespace CommonLibrary.Interface
{
  public interface Import :IDisposable
  {
    List<Parameter> getParameters();
    void setParameters(List<Parameter> parameters);
    Patient getPatient(Selection selection, List<Parameter> parameters = null);
    List<Patient> getPatients(Selection selection, List<Parameter> parameters = null);
    void getPatientsPaged(Selection selection, Action<int,int, List<Patient>> pagedCallback, List<Parameter> parameters = null);
    Physician getPhysician(Selection selection, List<Parameter> parameters = null);
    List<Physician> getPhysicians(Selection selection, List<Parameter> parameters = null);
    Appointment getAppointment(Selection selection, List<Parameter> parameters = null);
    List<Appointment> getAppointments(Selection selection, List<Parameter> parameters = null);
    void getAppointmentsPaged(Selection selection, Action<int, int, List<Appointment>> pagedCallback, List<Parameter> parameters = null);
    Inventory getInventory(Selection selection, List<Parameter> parameters = null);
    List<Inventory> getInventoryList(Selection selection, List<Parameter> parameters = null);
    Supplier getSupplier(Selection selection, List<Parameter> parameters = null);
    List<Supplier> getSuppliers(Selection selection, List<Parameter> parameters = null);
    PatientImage ImportImage(Selection selection, List<Parameter> parameters = null);
    List<PatientImage> ImportImages(Selection selection, List<Parameter> parameters = null);
    void ImportImagesDirect(Selection selection, Export exportInterface, List<Parameter> parameters = null);
  }
}
