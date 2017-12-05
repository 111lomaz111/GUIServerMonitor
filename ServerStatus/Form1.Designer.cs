namespace ServerStatus
{
    partial class Form1
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
            this.circularProgressBarCPU = new CircularProgressBar.CircularProgressBar();
            this.buttonValuePlus = new System.Windows.Forms.Button();
            this.buttonValueMinus = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.RichTextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.circularProgressBarRam = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // circularProgressBarCPU
            // 
            this.circularProgressBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPU.AnimationSpeed = 500;
            this.circularProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarCPU.InnerMargin = 2;
            this.circularProgressBarCPU.InnerWidth = -1;
            this.circularProgressBarCPU.Location = new System.Drawing.Point(12, 12);
            this.circularProgressBarCPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPU.Name = "circularProgressBarCPU";
            this.circularProgressBarCPU.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarCPU.OuterMargin = -25;
            this.circularProgressBarCPU.OuterWidth = 26;
            this.circularProgressBarCPU.ProgressColor = System.Drawing.Color.Blue;
            this.circularProgressBarCPU.ProgressWidth = 25;
            this.circularProgressBarCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circularProgressBarCPU.Size = new System.Drawing.Size(300, 300);
            this.circularProgressBarCPU.StartAngle = 270;
            this.circularProgressBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPU.SubscriptText = ".230";
            this.circularProgressBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPU.SuperscriptText = "USAGE";
            this.circularProgressBarCPU.TabIndex = 2;
            this.circularProgressBarCPU.Text = "CPU";
            this.circularProgressBarCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPU.Value = 100;
            // 
            // buttonValuePlus
            // 
            this.buttonValuePlus.Location = new System.Drawing.Point(237, 302);
            this.buttonValuePlus.Name = "buttonValuePlus";
            this.buttonValuePlus.Size = new System.Drawing.Size(75, 23);
            this.buttonValuePlus.TabIndex = 3;
            this.buttonValuePlus.Text = "+5 VALUE";
            this.buttonValuePlus.UseVisualStyleBackColor = true;
            this.buttonValuePlus.Click += new System.EventHandler(this.buttonValuePlus_Click);
            // 
            // buttonValueMinus
            // 
            this.buttonValueMinus.Location = new System.Drawing.Point(338, 302);
            this.buttonValueMinus.Name = "buttonValueMinus";
            this.buttonValueMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonValueMinus.TabIndex = 4;
            this.buttonValueMinus.Text = "-5 VALUE";
            this.buttonValueMinus.UseVisualStyleBackColor = true;
            this.buttonValueMinus.Click += new System.EventHandler(this.buttonValueMinus_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(237, 357);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(12, 331);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(626, 20);
            this.textBoxCommand.TabIndex = 9;
            this.textBoxCommand.TextChanged += new System.EventHandler(this.textBoxCommand_TextChanged);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 386);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(626, 149);
            this.textBoxValue.TabIndex = 0;
            this.textBoxValue.Text = "";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(336, 357);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // circularProgressBarRam
            // 
            this.circularProgressBarRam.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarRam.AnimationSpeed = 500;
            this.circularProgressBarRam.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarRam.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarRam.InnerMargin = 2;
            this.circularProgressBarRam.InnerWidth = -1;
            this.circularProgressBarRam.Location = new System.Drawing.Point(338, 12);
            this.circularProgressBarRam.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarRam.Maximum = 2048;
            this.circularProgressBarRam.Name = "circularProgressBarRam";
            this.circularProgressBarRam.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarRam.OuterMargin = -25;
            this.circularProgressBarRam.OuterWidth = 26;
            this.circularProgressBarRam.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarRam.ProgressWidth = 25;
            this.circularProgressBarRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.circularProgressBarRam.Size = new System.Drawing.Size(300, 300);
            this.circularProgressBarRam.StartAngle = 270;
            this.circularProgressBarRam.Step = 1;
            this.circularProgressBarRam.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarRam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarRam.SubscriptText = ".23";
            this.circularProgressBarRam.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarRam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarRam.SuperscriptText = "USAGE";
            this.circularProgressBarRam.TabIndex = 11;
            this.circularProgressBarRam.Text = "RAM";
            this.circularProgressBarRam.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarRam.Value = 2000;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 547);
            this.Controls.Add(this.circularProgressBarRam);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonValueMinus);
            this.Controls.Add(this.buttonValuePlus);
            this.Controls.Add(this.circularProgressBarCPU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularProgressBar.CircularProgressBar circularProgressBarCPU;
        private System.Windows.Forms.Button buttonValuePlus;
        private System.Windows.Forms.Button buttonValueMinus;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.RichTextBox textBoxValue;
        private System.Windows.Forms.Button buttonDisconnect;
        private CircularProgressBar.CircularProgressBar circularProgressBarRam;
    }
}

