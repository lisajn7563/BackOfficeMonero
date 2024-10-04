namespace Manero_BackOffice.Client.Shared.Models;

public class Color
{
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string colorTitle { get; set; } = null!;
}
