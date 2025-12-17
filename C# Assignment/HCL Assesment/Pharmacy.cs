namespace HCL_Assesment;

public class Pharmacy
{
    public void OnNotification(string msg)
    {
        Console.WriteLine("Pharmacy Notification: " + msg);
    }
}

public class BillingDepartment
{
    public void OnNotification(string msg)
    {
        Console.WriteLine("Billing Notification: " + msg);
    }
}
