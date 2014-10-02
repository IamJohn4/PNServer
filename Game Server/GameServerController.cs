using Game_Server.AppSettings;
using Newtonsoft.Json;
using PubNubMessaging.Core;
using System;

namespace Game_Server
{
    public class GameServerController
    {
        private readonly IPubnub _pubnub;
        private readonly IGameServerAppSettings _appSettings;

        public GameServerController(IPubnub pubnub, IGameServerAppSettings appSettings)
        {
            _pubnub = pubnub;
            _appSettings = appSettings;
        }

        public void Initialize()
        {
            _pubnub.Publish(_appSettings.GameUpdatesChannelName,
                new PubnubMessage() {text = "server console started"}, PublishCallback,
                PublishErrorCallback);
            _pubnub.Subscribe<string>(_appSettings.GameUpdatesChannelName, DisplaySubscribeReturnMessage, DisplaySubscribeConnectStatusMessage, DisplayErrorMessage);
            Console.WriteLine("Game Server Online.");
            Console.Write(">");
            string input = Console.ReadLine();
        }

        private void PublishErrorCallback(PubnubClientError obj)
        {

        }

        private void PublishCallback(object obj)
        {

        }

        private void DisplayErrorMessage(PubnubClientError error)
        {
            Console.WriteLine("Error subscribing to pubnub channel {0} : {1}", _appSettings.GameUpdatesChannelName, error.Message);
        }

        private void DisplaySubscribeConnectStatusMessage(string message)
        {
            Console.WriteLine("Connected to pubnub channel {0} : {1}", _appSettings.GameUpdatesChannelName, message);
        }

        private void DisplaySubscribeReturnMessage(string obj)
        {
            Console.WriteLine("Message received on channel {0} : {1}", _appSettings.GameUpdatesChannelName, obj);
            try
            {
                object[] messageObject = JsonConvert.DeserializeObject<object[]>(obj);
                PubnubMessage message = null;
                if (messageObject[0] != null)
                {
                    message = JsonConvert.DeserializeObject<PubnubMessage>(messageObject[0].ToString());
                }
                if(message != null)
                    Console.WriteLine("Message Text:{0}", message.text);
            }
            catch (Exception ex)
            {
            }
        }
    }

    public class PubnubMessage
    {
        public string text;
    }
}
