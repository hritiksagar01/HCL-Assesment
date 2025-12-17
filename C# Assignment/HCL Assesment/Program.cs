namespace HCL_Assesment;
class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();

        Pharmacy pharmacy = new Pharmacy();
        BillingDepartment billing = new BillingDepartment();

        hospital.NotifyDepartments += pharmacy.OnNotification;
        hospital.NotifyDepartments += billing.OnNotification;

        Console.WriteLine("Enter Patient ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Patient Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Select Patient Type:");
        Console.WriteLine("1. InPatient");
        Console.WriteLine("2. OutPatient");
        int choice = int.Parse(Console.ReadLine());

        Patient patient;

        if (choice == 1)
        {
            Console.WriteLine("Enter Days Admitted:");
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Daily Charge:");
            double charge = double.Parse(Console.ReadLine());

            patient = new InPatient(id, name, days, charge);
        }
        else
        {
            Console.WriteLine("Enter Consultation Fee:");
            double fee = double.Parse(Console.ReadLine());

            patient = new OutPatient(id, name, fee);
        }

        double baseBill = patient.CalculateBill();

        Console.WriteLine("Select Billing Strategy:");
        Console.WriteLine("1. Normal");
        Console.WriteLine("2. Insurance");
        int billingChoice = int.Parse(Console.ReadLine());

        BillingDelegate billingDelegate =
            billingChoice == 2
            ? BillingStrategies.InsuranceBilling
            : BillingStrategies.NormalBilling;

        double finalBill = billingDelegate(baseBill);

        Console.WriteLine("\n--- BILL GENERATED ---");
        Console.WriteLine("Patient Name: " + patient.Name);
        Console.WriteLine("Total Amount: " + finalBill);

        hospital.TriggerEvent("Patient " + patient.Name + " billing completed.");
    }
}
