using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerCraft.Network
{
    public class UnsupportedHeartbeatException: Exception
    {
        public UnsupportedHeartbeatException()
        {
        }

        public UnsupportedHeartbeatException(string message)
            : base(message)
        {
        }

        public UnsupportedHeartbeatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
