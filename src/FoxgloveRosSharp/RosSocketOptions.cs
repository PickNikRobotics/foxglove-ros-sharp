using System.Collections.Generic;

namespace RosSharp.RosBridgeClient
{
    public sealed class RosSocketOptions
    {
        /// <summary>
        /// HTTP headers sent during the WebSocket opening handshake.
        /// </summary>
        public IDictionary<string, string> RequestHeaders { get; } = new Dictionary<string, string>();
    }
}
