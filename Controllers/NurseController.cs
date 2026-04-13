using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShiftsApi.Data;
using ShiftsApi.Models;
using ShiftsApi.DTOs;

namespace ShiftsApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class NursesController : ControllerBase
{
   
    private readonly ShiftsDbContext _context;

   
    public NursesController(ShiftsDbContext context)
    {
        _context = context;
    }

  
    [HttpGet]
    public async Task<ActionResult<IEnumerable<NurseDto>>> GetNurses()
    {
        var nurses = await _context.Nurses
            .Select(n => new NurseDto
            {
                Id = n.Id,
                FirstName = n.FirstName,
                LastName = n.LastName,
                ContractHoursPerMonth = n.ContractHoursPerMonth
            })
            .ToListAsync();
        return Ok(nurses);
    }

    
    [HttpPost]
    public async Task<ActionResult<NurseDto>> CreateNurse(CreateNurseDto dto)
    {
        var nurse = new Nurse
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            ContractHoursPerMonth = dto.ContractHoursPerMonth
        };
        
        _context.Nurses.Add(nurse);
        await _context.SaveChangesAsync();
        
        var responseDto = new NurseDto
        {
            Id = nurse.Id,
            FirstName = nurse.FirstName,
            LastName = nurse.LastName,
            ContractHoursPerMonth = nurse.ContractHoursPerMonth
        };
        
        return CreatedAtAction(nameof(GetNurses), new { id = nurse.Id }, responseDto);
        
    }
}