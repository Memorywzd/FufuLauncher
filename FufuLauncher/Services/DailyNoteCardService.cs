using System.Diagnostics;
using FufuLauncher.Views;
using FufuLauncher.Models;

namespace FufuLauncher.Services;

public class DailyNoteCardService
{
    public async Task<DailyNoteCardData> LoadCardDataAsync(string roleId, string server, Dictionary<string, string> cookies)
    {
        string json = await FetchApiJsonAsync(roleId, server);
        return DailyNoteParser.Parse(json);
    }

    private async Task<string> FetchApiJsonAsync(string roleId, string server)
    {
        var apiUrl = $"https://api-takumi-record.mihoyo.com/game_record/app/genshin/api/dailyNote?server={server}&role_id={roleId}";
        Debug.WriteLine($"[DailyNoteCardService] 请求API: {apiUrl}");
        Debug.WriteLine("[DailyNoteCardService] 通过 BBSWindow 请求API");

        return await BBSWindow.FetchApiJsonAsync(apiUrl);
    }
}