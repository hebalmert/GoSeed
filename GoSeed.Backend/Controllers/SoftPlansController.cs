using GoSeed.Backend.Data;
using GoSeed.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoSeed.Backend.Controllers;

[Route("api/softplas")]
[ApiController]
public class SoftPlansController : ControllerBase
{
    private readonly DataContext _context;

    public SoftPlansController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SoftPlan>>> GetAsync()
    {
        var lista = await _context.SoftPlans.ToListAsync();
        return Ok(lista);
    }
}