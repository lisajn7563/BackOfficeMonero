namespace Manero_BackOffice.Client.Shared.Models;

public class Size
{
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string sizeTitle { get; set; } = null!;
}


