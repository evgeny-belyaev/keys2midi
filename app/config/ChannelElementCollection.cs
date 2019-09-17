using System.Configuration;

namespace app.config
{
    public class ChannelElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ChannelElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ChannelElement)element).Name;
        }
    }
}