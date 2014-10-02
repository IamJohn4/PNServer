namespace Game_Server.AppSettings
{
    public interface IPubnubAppSettings
    {
        string PubnubSubscribeKey { get; }
        string PubnubPublishKey { get; }
        string PubnubOrigin { get; }
        string PubnubAuthKey { get; }
    }
}