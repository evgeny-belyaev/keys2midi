using System.Linq;

namespace app.config
{
    public class Channel
    {
        public byte[] Command { get; set; }
        public HotKey HotKey { get; set; }

        public string CommandToString()
        {
            return string.Join(",", this.Command);
        }
    }
}