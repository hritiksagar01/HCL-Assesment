namespace HCL_Assesment;

public class InPatient : Patient
{
    public int DaysAdmitted { get; set; }
    public double DailyCharge { get; set; }
    public String TypeOfDisease { get; set; }
    
    public InPatient(int id, string name, int days, double charge, String typeOfDisease)
        : base(id, name)
    {
        DaysAdmitted = days;
        DailyCharge = charge;
        TypeOfDisease = typeOfDisease;
    }

    public override double CalculateBill()
    {
        return DaysAdmitted * DailyCharge;
    }
}
