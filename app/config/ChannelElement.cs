using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.config
{
    public class ChannelElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get => (string) this["name"];
            set => this["name"] = value;
        }

        [ConfigurationProperty("command", IsRequired =false, IsKey = false)]
        public string Command
        {
            get => (string)this["command"];
            set => this["command"] = value;
        }

        [ConfigurationProperty("hotkey", IsRequired = false, IsKey = false)]
        public string Hotkey
        {
            get => (string)this["hotkey"];
            set => this["hotkey"] = value;
        }

    }
}
