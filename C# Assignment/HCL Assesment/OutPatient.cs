namespace HCL_Assesment;

public class OutPatient : Patient
{
    public double ConsultationFee { get; set; }

    public OutPatient(int id, string name, double fee)
        : base(id, name)
    {
        ConsultationFee = fee;
    }

    public override double CalculateBill()
    {
        return ConsultationFee;
    }
}
