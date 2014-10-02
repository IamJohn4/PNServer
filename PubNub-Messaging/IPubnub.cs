using System;

namespace PubNubMessaging.Core
{
    public interface IPubnub
    {
        void Subscribe<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<PubnubClientError> errorCallback);
        void Subscribe(string channel, Action<object> userCallback, Action<object> connectCallback, Action<PubnubClientError> errorCallback);
        bool Publish(string channel, object message, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool Publish<T>(string channel, object message, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void Presence<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<PubnubClientError> errorCallback);
        void Presence(string channel, Action<object> userCallback, Action<object> connectCallback, Action<PubnubClientError> errorCallback);
        bool DetailedHistory(string channel, long start, long end, int count, bool reverse, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool DetailedHistory<T>(string channel, long start, long end, int count, bool reverse, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool DetailedHistory(string channel, long start, Action<object> userCallback, Action<PubnubClientError> errorCallback, bool reverse);
        bool DetailedHistory<T>(string channel, long start, Action<T> userCallback, Action<PubnubClientError> errorCallback, bool reverse);
        bool DetailedHistory(string channel, int count, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool DetailedHistory<T>(string channel, int count, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool HereNow(string channel, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool HereNow(string channel, bool showUUIDList, bool includeUserState, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool HereNow<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool HereNow<T>(string channel, bool showUUIDList, bool includeUserState, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void GlobalHereNow(bool showUUIDList, bool includeUserState, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool GlobalHereNow<T>(bool showUUIDList, bool includeUserState, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void WhereNow(string uuid, Action<object> userCallback, Action<PubnubClientError> errorCallback);
        void WhereNow<T>(string uuid, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void Unsubscribe<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<T> disconnectCallback, Action<PubnubClientError> errorCallback);
        void Unsubscribe(string channel, Action<object> userCallback, Action<object> connectCallback, Action<object> disconnectCallback, Action<PubnubClientError> errorCallback);
        void PresenceUnsubscribe(string channel, Action<object> userCallback, Action<object> connectCallback, Action<object> disconnectCallback, Action<PubnubClientError> errorCallback);
        void PresenceUnsubscribe<T>(string channel, Action<T> userCallback, Action<T> connectCallback, Action<T> disconnectCallback, Action<PubnubClientError> errorCallback);
        bool Time(Action<object> userCallback, Action<PubnubClientError> errorCallback);
        bool Time<T>(Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void AuditAccess<T>(string channel, string authenticationKey, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void AuditAccess<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void AuditAccess<T>(Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void AuditPresenceAccess<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void AuditPresenceAccess<T>(string channel, string authenticationKey, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantAccess<T>(string channel, bool read, bool write, int ttl, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantAccess<T>(string channel, bool read, bool write, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantAccess<T>(string channel, string authenticationKey, bool read, bool write, int ttl, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantAccess<T>(string channel, string authenticationKey, bool read, bool write, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantPresenceAccess<T>(string channel, bool read, bool write, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantPresenceAccess<T>(string channel, bool read, bool write, int ttl, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantPresenceAccess<T>(string channel, string authenticationKey, bool read, bool write, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        bool GrantPresenceAccess<T>(string channel, string authenticationKey, bool read, bool write, int ttl, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void SetUserState<T>(string channel, string uuid, string jsonUserState, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void SetUserState<T>(string channel, string jsonUserState, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void SetUserState<T>(string channel, string uuid, System.Collections.Generic.KeyValuePair<string, object> keyValuePair, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void SetUserState<T>(string channel, System.Collections.Generic.KeyValuePair<string, object> keyValuePair, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void GetUserState<T>(string channel, string uuid, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void GetUserState<T>(string channel, Action<T> userCallback, Action<PubnubClientError> errorCallback);
        void TerminateCurrentSubscriberRequest();
        void EnableSimulateNetworkFailForTestingOnly();
        void DisableSimulateNetworkFailForTestingOnly();
        void EnableMachineSleepModeForTestingOnly();
        void DisableMachineSleepModeForTestingOnly();
        void EndPendingRequests();
        Guid GenerateGuid();
        void ChangeUUID(string newUUID);
        string AuthenticationKey { get; set; }
        int LocalClientHeartbeatInterval { get; set; }
        int NetworkCheckRetryInterval { get; set; }
        int NetworkCheckMaxRetries { get; set; }
        int NonSubscribeTimeout { get; set; }
        int SubscribeTimeout { get; set; }
        bool EnableResumeOnReconnect { get; set; }
        string SessionUUID { get; set; }
        string Origin { get; set; }
        int PresenceHeartbeat { get; set; }
        int PresenceHeartbeatInterval { get; set; }
        IPubnubUnitTest PubnubUnitTest { get; set; }
        bool EnableJsonEncodingForPublish { get; set; }
        PubnubProxy Proxy { get; set; }
        IJsonPluggableLibrary JsonPluggableLibrary { get; set; }
    }
}