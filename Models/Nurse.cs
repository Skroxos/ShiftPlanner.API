namespace ShiftsApi.Models;

public class Nurse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public double ContractHoursPerMonth { get; set; }

    public List<Shift> Shifts { get; set; } = new();
}