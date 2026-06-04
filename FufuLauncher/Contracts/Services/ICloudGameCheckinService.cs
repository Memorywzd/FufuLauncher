using FufuLauncher.Models;

namespace FufuLauncher.Contracts.Services;

public interface ICloudGameCheckinService
{
    Task<CheckinTypeResult> ExecuteCheckinAsync(string uid, string comboToken);
}
