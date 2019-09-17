using System.Configuration;

namespace app.config
{
    public class Device : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get => (string)this["name"];
            set => this["name"] = value;
        }

    }
}