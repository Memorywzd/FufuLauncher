namespace FufuLauncher.Contracts.Services;

//获取指纹
public interface IDeviceFingerprintService
{
    //获取已注册的指纹，没有则注册
    Task<string> GetOrRegisterFingerprintAsync(string accountId, Dictionary<string, string> cookies);

    //获取当前内存中的指纹
    string? GetCurrentFingerprint();

    //强制重新注册指纹
    Task ResetFingerprintAsync(string accountId);
}
