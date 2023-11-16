using Employee;

public class Program : Ab
{
    public static void Main()
    {
        Program Ab = new Program();
        Ab.Amount = 50000;
        Ab.salary();

        EmployeGetSet employeGetSet = new EmployeGetSet();
        employeGetSet.Name = "Mafuj Ahammad Pranto";
        employeGetSet.SetAge(23);
        employeGetSet.Display();
    }
}