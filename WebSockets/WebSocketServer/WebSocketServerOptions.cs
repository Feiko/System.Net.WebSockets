﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System.Net.WebSockets.WebSocketFrame;

namespace System.Net.WebSockets.Server
{
    /// <summary>
    /// Options to use with a WebSocketServer object.
    /// </summary>
    public class WebSocketServerOptions : WebSocketOptions
    {
        /// <summary>
        /// The local Port to listen on.
        /// </summary>
        public int Port { get; set; } = 80;

        /// <summary>
        /// The server name that is presented to the client during the handshake
        /// </summary>
        public string ServerName { get; set; } = "NFWebSocketServer";

        /// <summary>
        /// The maximum number of clients that can connect to the server.
        /// </summary>
        public int MaxClients { get; set; } = 10;

        /// <summary>
        /// The remote Prefix clients need to connect to.
        /// </summary>
        public string Prefix { get; set; } = "/";
    }
}