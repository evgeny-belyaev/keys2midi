using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.config
{
    class ConfigurationProvider
    {
        public ConfigurationProvider()
        {

            var sectionHandler = ((ChannelsSectionHandler)ConfigurationManager.GetSection("ChannelsSection"));
            var channels = sectionHandler.Channels.Cast<ChannelElement>();

            Configuration = new Config
            {
                DeviceName = sectionHandler.Device.Name,
                Channels = channels.Select(channel => new Channel
                {
                    Command = this.parseCommand(channel.Command),
                    HotKey = this.ParseHotkey(channel.Hotkey)
                }).ToArray()
            };
        }

        private HotKey ParseHotkey(string channelHotkey)
        {
            var hotKey = new HotKey();

            channelHotkey.Split(' ').Aggregate(hotKey, (acc, stringHotkey) =>
            {
                switch (stringHotkey)
                {
                    case "alt":
                    {
                        acc.Modifiers |= KeyModifiers.Alt;
                        break;
                    }
                    case "ctrl":
                    {
                        acc.Modifiers |= KeyModifiers.Control;
                        break;
                        }
                    case "shift":
                    {
                        acc.Modifiers |= KeyModifiers.Shift;
                        break;
                    }
                    default:
                    {
                        if (Enum.TryParse(stringHotkey, out Keys value))
                        {
                            acc.Key = value;
                        }

                        break;
                    }
                }

                return acc;
            });

            return hotKey;
        }

        private byte[] parseCommand(string channelCommand)
        {
            return channelCommand.Split(' ')
                .Where(s => ! string.IsNullOrWhiteSpace(s))
                .Select(stringCommand => Convert.ToByte(stringCommand, 16)).ToArray();
        }

        public Config Configuration { get; set; }
    }
}
