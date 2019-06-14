namespace Net
{
    partial class MainForm
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
            this.Mail = new System.Windows.Forms.Button();
            this.BatteryText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Ram = new System.Windows.Forms.Label();
            this.CPU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(792, 545);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 32);
            this.Mail.TabIndex = 0;
            this.Mail.Text = "Отправить";
            this.Mail.UseVisualStyleBackColor = true;
            this.Mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // BatteryText
            // 
            this.BatteryText.AutoSize = true;
            this.BatteryText.Location = new System.Drawing.Point(845, 9);
            this.BatteryText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BatteryText.Name = "BatteryText";
            this.BatteryText.Size = new System.Drawing.Size(44, 18);
            this.BatteryText.TabIndex = 1;
            this.BatteryText.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 2;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(709, 189);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 32);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Обновить";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Ram
            // 
            this.Ram.AutoSize = true;
            this.Ram.Location = new System.Drawing.Point(845, 60);
            this.Ram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(44, 18);
            this.Ram.TabIndex = 4;
            this.Ram.Text = "label1";
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Location = new System.Drawing.Point(845, 102);
            this.CPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(44, 18);
            this.CPU.TabIndex = 5;
            this.CPU.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BatteryText);
            this.Controls.Add(this.Mail);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mail;
        private System.Windows.Forms.Label BatteryText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Ram;
        private System.Windows.Forms.Label CPU;
    }
}