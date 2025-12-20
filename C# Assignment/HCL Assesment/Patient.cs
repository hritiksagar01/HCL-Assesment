namespace HCL_Assesment;

public delegate double BillingDelegate(double amount);

public abstract class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Patient(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract double CalculateBill();
}