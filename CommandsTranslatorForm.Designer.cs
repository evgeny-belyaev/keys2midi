namespace CSRegisterHotkey
{
    partial class CommandsTranslatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.unregisterButton = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.cc1 = new System.Windows.Forms.TextBox();
            this.cc2 = new System.Windows.Forms.TextBox();
            this.cc3 = new System.Windows.Forms.TextBox();
            this.midiDeviceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Button 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Button 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Button 3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(15, 146);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(142, 33);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // unregisterButton
            // 
            this.unregisterButton.Location = new System.Drawing.Point(174, 146);
            this.unregisterButton.Name = "unregisterButton";
            this.unregisterButton.Size = new System.Drawing.Size(142, 33);
            this.unregisterButton.TabIndex = 7;
            this.unregisterButton.Text = "Unregister";
            this.unregisterButton.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(15, 186);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(301, 291);
            this.log.TabIndex = 8;
            // 
            // cc1
            // 
            this.cc1.Location = new System.Drawing.Point(263, 44);
            this.cc1.Name = "cc1";
            this.cc1.Size = new System.Drawing.Size(53, 20);
            this.cc1.TabIndex = 9;
            this.cc1.Text = "1";
            // 
            // cc2
            // 
            this.cc2.Location = new System.Drawing.Point(263, 78);
            this.cc2.Name = "cc2";
            this.cc2.Size = new System.Drawing.Size(53, 20);
            this.cc2.TabIndex = 10;
            this.cc2.Text = "2";
            // 
            // cc3
            // 
            this.cc3.Location = new System.Drawing.Point(262, 111);
            this.cc3.Name = "cc3";
            this.cc3.Size = new System.Drawing.Size(53, 20);
            this.cc3.TabIndex = 11;
            this.cc3.Text = "3";
            // 
            // midiDeviceName
            // 
            this.midiDeviceName.Enabled = false;
            this.midiDeviceName.Location = new System.Drawing.Point(112, 13);
            this.midiDeviceName.Name = "midiDeviceName";
            this.midiDeviceName.Size = new System.Drawing.Size(203, 20);
            this.midiDeviceName.TabIndex = 12;
            this.midiDeviceName.Text = "loopMIDI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "MIDI device name";
            // 
            // CommandsTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 490);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.midiDeviceName);
            this.Controls.Add(this.cc3);
            this.Controls.Add(this.cc2);
            this.Controls.Add(this.cc1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.unregisterButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "CommandsTranslatorForm";
            this.Text = "MIDI commands translator";
            this.Load += new System.EventHandler(this.CommandsTranlatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button unregisterButton;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox cc1;
        private System.Windows.Forms.TextBox cc2;
        private System.Windows.Forms.TextBox cc3;
        private System.Windows.Forms.TextBox midiDeviceName;
        private System.Windows.Forms.Label label4;
    }
}