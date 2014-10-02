using Game_Server.AppSettings;
using PubNubMessaging.Core;

namespace Game_Server.Factories
{
    public class PubnubFactory
    {
        public static Pubnub GetPubnub(IPubnubAppSettings appSettings)
        {
            var pubnub = new Pubnub(appSettings.PubnubPublishKey, appSettings.PubnubSubscribeKey)
            {
                Origin = appSettings.PubnubOrigin,
                AuthenticationKey = appSettings.PubnubAuthKey
            };
            return pubnub;
        }
    }
}
