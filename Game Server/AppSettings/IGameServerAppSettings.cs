namespace Game_Server.AppSettings
{
    public interface IGameServerAppSettings
    {
        string PubnubSubscribeKey { get; }
        string PubnubPublishKey { get; }
        string GameUpdatesChannelName { get; }
        string PubnubOrigin { get; }
        string PubnubAuthKey { get; }
    }
}