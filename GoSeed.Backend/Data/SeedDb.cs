using GoSeed.Shared.Entities;

namespace GoSeed.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedDbAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckPlans();
    }

    private async Task CheckPlans()
    {
        if (!_context.SoftPlans.Any())
        {
            _context.SoftPlans.Add(new SoftPlan { Name = "Plan Basico", Price = 34, Active = true });
            _context.SoftPlans.Add(new SoftPlan { Name = "Plan Avanzado", Price = 43, Active = true });
            _context.SoftPlans.Add(new SoftPlan { Name = "Plan Empresarial", Price = 53, Active = false });
            await _context.SaveChangesAsync();
        }
    }
}