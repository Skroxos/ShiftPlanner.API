namespace ShiftsApi.Models;

    public enum ShiftType {
        Morning,
        Afternoon,
        Night
    }
public class Shift
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    
    public ShiftType Type { get; set; }
    
    public List<Nurse> Nurses { get; set; } = new();
}
