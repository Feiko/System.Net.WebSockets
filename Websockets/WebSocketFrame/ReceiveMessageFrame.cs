﻿using System.Net;

namespace nanoframework.System.Net.Websockets
{
    public class ReceiveMessageFrame : MessageFrame
    {

        public bool IsMasked { get; set; } = false;
        public FragmentationType Fragmentation { get; set; }
        public bool IsFragmented { get => Fragmentation != FragmentationType.NotFragmented; }
        
        public int MessageLength { get; set; }
        public byte[] Masks { get; set; } = new byte[4];
        public ReceiveMessageStream MessageStream { get; set; }

    }
}
