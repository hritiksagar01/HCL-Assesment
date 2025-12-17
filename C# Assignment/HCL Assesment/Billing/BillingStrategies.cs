namespace HCL_Assesment.Billing;

public class BillingStrategies
{
    public static double NormalBilling(double amount)
    {
        return amount;
    }

    public static double InsuranceBilling(double amount)
    {
        return amount * 0.7; 
    }
}
