namespace HCL_Assesment;

public class InPatient : Patient
{
    public int DaysAdmitted { get; set; }
    public double DailyCharge { get; set; }
    
    public InPatient(int id, string name, int days, double charge)
        : base(id, name)
    {
        DaysAdmitted = days;
        DailyCharge = charge;
    }

    public override double CalculateBill()
    {
        return DaysAdmitted * DailyCharge;
    }
}
