using CommunityToolkit.Mvvm.ComponentModel;

namespace FufuLauncher.Models;

public partial class CheckinAccountItem : ObservableObject
{
    [ObservableProperty] private string _uid = string.Empty;
    [ObservableProperty] private string _nickname = string.Empty;
    [ObservableProperty] private bool _isSelected = true;
    [ObservableProperty] private bool _hasCloudCredential;
}
