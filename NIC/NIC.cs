using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIC
{
    class NIC
    {
        public string Manufacture { get; private set; }
        public string MACAddress { get; private set; }
        public NICType Type { get; private set; }

        private static NIC _instance;

        private static readonly object _lock = new object();

        private NIC(string manufacture, string macAddress, NICType type)
        {
            Manufacture = manufacture;
            MACAddress = macAddress;
            Type = type;
        }

        public static NIC GetInstance(string manufacture, string macAddress, NICType type)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new NIC(manufacture, macAddress, type);
                    }
                }
            }
            return _instance;
        }

        public override string ToString()
        {
            return $"NIC Info:\n" +
                   $"Manufacture: {Manufacture}\n" +
                   $"MAC Address: {MACAddress}\n" +
                   $"Type: {Type}";
        }
    }
}
