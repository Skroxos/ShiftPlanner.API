namespace ShiftsApi.DTOs;

public class NurseDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public double ContractHoursPerMonth { get; set; }
}