namespace ShiftsApi.DTOs;

public class CreateNurseDto
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    
    public double ContractHoursPerMonth { get; set; }
}