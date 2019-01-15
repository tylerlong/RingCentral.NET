using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class SIPInfoRequest : Serializable
    {
        // Supported transport. SIP info will be returned for this transport if supported
        // Enum: UDP, TCP, TLS, WS, WSS
        public string transport;
    }
}