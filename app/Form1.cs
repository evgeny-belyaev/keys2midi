using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Midi;

namespace app
{
    public partial class Form1 : Form
    {
        private App _app;

        public Form1()
        {
            InitializeComponent();

            this._app = new App(this.Handle, this.WriteLog);

            _app.Start();
        }

        private void WriteLog(string message)
        {
            this.textBox1.AppendText(message + Environment.NewLine);
        }
    }
}
