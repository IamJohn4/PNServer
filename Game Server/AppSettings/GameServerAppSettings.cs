using System.Configuration;

namespace Game_Server.AppSettings
{
    class GameServerAppSettings : IPubnubAppSettings, IGameServerAppSettings
    {
        public string PubnubSubscribeKey
        {
            get { return ConfigurationManager.AppSettings["PubnubSubscribeKey"]; }
        }

        public string PubnubPublishKey
        {
            get { return ConfigurationManager.AppSettings["PubnubPublishKey"]; }
        }

        public string GameUpdatesChannelName
        {
            get { return ConfigurationManager.AppSettings["GameUpdatesChannelName"]; }
        }

        public string PubnubOrigin
        {
            get { return ConfigurationManager.AppSettings["PubnubOrigin"]; }
        }

        public string PubnubAuthKey
        {
            get { return ConfigurationManager.AppSettings["PubnubAuthKey"]; }
        }
    }
}
