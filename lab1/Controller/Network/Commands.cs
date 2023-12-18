using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Network
{
    public static class Commands
    {
        public static readonly string AVAILABLE_TRAINS = "AVAILABLE_TRAINS:";
        public static readonly string TRAIN_OUT = "TRAIN_OUT:";
        public static readonly string TRAIN_IN = "TRAIN_IN:";
        public static readonly string AUTH_REQUEST = "AUTH_REQUEST:";
        public static readonly string AUTH_RESPONSE = "AUTH_RESPONSE";
        public static readonly string GET_AVAILABLE_TRAINS = "GET_AVAILABLE_TRAINS";
    }
}
