namespace Manero_BackOffice.Client.Shared.Models;

public class Category
{
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string categoryTitle { get; set; } = null!;
}
