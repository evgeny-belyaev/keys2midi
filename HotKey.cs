using System.Windows.Forms;

namespace CSRegisterHotkey
{
    public class HotKey
    {
        public Keys Key { get; set; }
        public KeyModifiers Modifiers { get; set; }
        public override string ToString()
        {
            return $"{this.Modifiers}+{this.Key}";

        }
    }
}