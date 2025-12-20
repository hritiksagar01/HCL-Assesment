namespace HCL_Assesment;

public class Emergency : Patient
{
    public string TypeOfDisease { get; set; }
    public int DaysAdmitted { get; set; }
    public int DailyCharge { get; set; }

    public Emergency(int id, string name, int days, string typeOfDisease, int charge)
        : base(id, name)
    {
        DaysAdmitted = days;
        DailyCharge = charge;
        TypeOfDisease = typeOfDisease;
    }

    public override double CalculateBill()
    {
        return DaysAdmitted * DailyCharge + 2000; 
    }
}