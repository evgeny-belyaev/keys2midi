using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.config;
using NAudio.Midi;

namespace app
{
    class App
    {
        private readonly IntPtr _handle;
        private readonly Action<string> _writeLog;
        private readonly Config _configuration;
        private HotKeyRegister[] registerers;

        private bool[] _state = new[] {true, false, false, false};

        public App(IntPtr handle, Action<string> writeLog)
        {
            _handle = handle;
            _writeLog = writeLog;

            _configuration = new ConfigurationProvider().Configuration;
        }

        public void Start()
        {
            int deviceId = GetDevice(_configuration.DeviceName);
            if (deviceId == -1)
            {
                _writeLog(_configuration.DeviceName + " not found!");
                //return;
            }

            var midiOut = new MidiOut(deviceId);

            this.registerers = this._configuration.Channels.Select((channel, currentChannelIndex) =>
            {
                try
                {
                    var r = new HotKeyRegister(this._handle, currentChannelIndex, channel.HotKey.Modifiers, channel.HotKey.Key);
                    r.HotKeyPressed += (sender, eventArgs) =>
                    {
                        midiOut.SendBuffer(channel.Command);

                        var hotKey = channel.HotKey;
                        _writeLog(currentChannelIndex + " " + hotKey + " sent");
                    };

                    _writeLog(channel.HotKey + " registered");

                    return r;
                }
                catch (Exception x)
                {
                    _writeLog(x.Message);
                }

                return null;

            }).ToArray();

        }

        int GetDevice(string deviceName)
        {
            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                var productName = MidiOut.DeviceInfo(device).ProductName;
                if (productName.IndexOf(deviceName, StringComparison.Ordinal) != -1)
                {
                    return device;
                }
            }

            return -1;
        }
    }
}