using System.Configuration;

namespace app.config
{
    public class ChannelsSectionHandler : ConfigurationSection
    {
        [ConfigurationProperty("Channels")]
        [ConfigurationCollection(typeof(ChannelElementCollection))]
        public ChannelElementCollection Channels => (ChannelElementCollection)base["Channels"];

        [ConfigurationProperty("Device")]
        [ConfigurationCollection(typeof(Device))]
        public Device Device => (Device)base["Device"];
    }

}