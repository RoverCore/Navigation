using System.Text.Json.Serialization;

namespace RoverCore.Navigation.Models;

#pragma warning disable CS8618
public class NavMenu
{
    [JsonPropertyName("MenuId")]
    public string MenuId { get; set; } = String.Empty;

    [JsonPropertyName("NavMenuItems")]
    public List<NavMenuItem> NavMenuItems { get; set; }
}
#pragma warning restore CS8618
