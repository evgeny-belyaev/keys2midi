using System.Windows.Forms;

namespace app
{
    public class HotKey
    {
        public Keys Key { get; set; }
        public KeyModifiers Modifiers { get; set; }
        public override string ToString()
        {
            return $"{this.Modifiers}+{this.Key}";
        }

        public static HotKey Parse(string from)
        {
            return new HotKey();
        }
    }
}