using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Midi;

namespace CSRegisterHotkey
{
    public partial class CommandsTranslatorForm : Form
    {
        private HotKeyRegister r1;
        private HotKeyRegister r2;
        private HotKeyRegister r3;
        private MidiOut midiOut;

        public CommandsTranslatorForm()
        {
            InitializeComponent();
        }

        public HotKey Button1 { get; set; }
        public HotKey Button2 { get; set; }
        public HotKey Button3 { get; set; }

        private void CommandsTranlatorForm_Load(object sender, EventArgs e)
        {
            this.Button1 = new HotKey {Key = Keys.A, Modifiers = KeyModifiers.Alt | KeyModifiers.Control | KeyModifiers.Shift};
            this.Button2 = new HotKey {Key = Keys.S, Modifiers = KeyModifiers.Alt | KeyModifiers.Control | KeyModifiers.Shift};
            this.Button3 = new HotKey {Key = Keys.F, Modifiers = KeyModifiers.Alt | KeyModifiers.Control | KeyModifiers.Shift};

            this.textBox1.Text = this.Button1.ToString();
            this.textBox2.Text = this.Button2.ToString();
            this.textBox3.Text = this.Button3.ToString();

            this.registerButton_Click(null, null);

            int deviceId = GetDevice(this.midiDeviceName.Text);
            if (deviceId == -1)
            {
                MessageBox.Show("***Device not found!");

                return;
            }

            this.midiOut = new MidiOut(deviceId);
        }

        private void WriteLog(string log)
        {
            this.log.Text = this.log.Text + log + "\r\n";
        }

        private HotKey RecordHotKeyFor(TextBox textBox, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            // Check whether the modifier keys are pressed.
            if (e.Modifiers != Keys.None)
            {
                Keys key = Keys.None;
                KeyModifiers modifiers = HotKeyRegister.GetModifiers(e.KeyData, out key);

                // If the pressed key is valid...
                if (key != Keys.None)
                {
                    var hotKey = new HotKey
                    {
                        Key = key,
                        Modifiers = modifiers
                    };

                    // Display the pressed key in the textbox.
                    textBox.Text = hotKey.ToString();
                    // Enable the button.
                    //btnRegister.Enabled = true;

                    return hotKey;
                }
            }

            return null;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Button1 =  this.RecordHotKeyFor(this.textBox1, e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            this.Button2 = this.RecordHotKeyFor(this.textBox2, e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            this.Button3 = this.RecordHotKeyFor(this.textBox3, e);
        }

        private HotKeyRegister RegisterHotKey(HotKey hotKey, EventHandler handler, int id)
        {
            if (hotKey == null)
            {
                return null;
            }

            // Register the hotkey.
            var r = new HotKeyRegister(this.Handle, id, hotKey.Modifiers, hotKey.Key);
            r.HotKeyPressed += handler;

            this.WriteLog(hotKey + " registered.");
 
            return r;
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.r1 = this.RegisterHotKey(this.Button1, this.OnButton1Press, 100);
                this.r2 = this.RegisterHotKey(this.Button2, this.OnButton2Press, 101);
                this.r3 = this.RegisterHotKey(this.Button3, this.OnButton3Press, 102);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
            catch (ApplicationException applicationException)
            {
                MessageBox.Show(applicationException.Message);
            }
        }

        private void OnButton1Press(object sender, EventArgs e)
        {
            this.WriteLog("Button 1 pressed");
            this.SendMidiCommmand(int.Parse(this.cc1.Text));
        }

        private void OnButton2Press(object sender, EventArgs e)
        {
            this.WriteLog("Button 2 pressed");
            this.SendMidiCommmand(int.Parse(this.cc2.Text));
        }

        private void OnButton3Press(object sender, EventArgs e)
        {
            this.WriteLog("Button 3 pressed");
            this.SendMidiCommmand(int.Parse(this.cc3.Text));
        }

        static int GetDevice(string deviceName)
        {
            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                var productName = MidiOut.DeviceInfo(device).ProductName;
                if (productName.IndexOf(deviceName) != -1)
                {
                    return device;
                }
            }

            return -1;
        }


        private void SendMidiCommmand(int cc)
        {
            var controlChangeEvent = new ControlChangeEvent(1, 1,(MidiController)cc, 0);

            this.midiOut.Send(controlChangeEvent.GetAsShortMessage());

            this.WriteLog((MidiController)cc + " MIDI command sent");
        }
    }
}
