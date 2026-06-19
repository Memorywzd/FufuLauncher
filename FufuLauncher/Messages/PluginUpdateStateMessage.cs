using CommunityToolkit.Mvvm.Messaging.Messages;

namespace FufuLauncher.Messages;

public class PluginUpdateStateMessage : ValueChangedMessage<bool>
{
    public PluginUpdateStateMessage(bool isUpdating) : base(isUpdating)
    {
    }
}
