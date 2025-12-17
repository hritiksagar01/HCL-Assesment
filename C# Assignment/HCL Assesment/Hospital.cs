namespace HCL_Assesment;

public delegate void HospitalEventHandler(string message);

public class Hospital
{
    public event HospitalEventHandler NotifyDepartments;

    public void TriggerEvent(string msg)
    {
        NotifyDepartments?.Invoke(msg);
    }
}