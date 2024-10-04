namespace Manero_BackOffice.Client.Shared.Models;

public class ProductRegistration
{
    public string? Id { get; set; } = Guid.NewGuid().ToString();
    public string BatchNumber { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public decimal OriginalPrice { get; set; }
    public string? DiscountPrice { get; set; }
    public string? Color { get; set; }
    public string? Category { get; set; }
    public string? ImageUrl { get; set; }
    public string Size { get; set; } = null!;
    public Rating? Rating { get; set; }
    public Tags? Tags { get; set; }
    public string? Reviews { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? LastUpdated { get; set; }
}

public class Rating
{
    public int Id { get; set; }
}


public class Tags
{
    public string Id { get; set; }
}