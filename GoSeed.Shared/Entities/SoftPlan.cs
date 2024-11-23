namespace GoSeed.Shared.Entities;

public class SoftPlan
{
    public int SoftPlanId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Active { get; set; }
}