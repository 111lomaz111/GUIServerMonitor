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
            this.circularProgressBarCPU.Size = new System.Drawing.Size(308, 300);
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
            this.circularProgressBarCPU.Value = 68;
            this.circularProgressBarCPU.Click += new System.EventHandler(this.circularProgressBarCPU_Click);
            // 
            // buttonValuePlus
            // 
            this.buttonValuePlus.Location = new System.Drawing.Point(371, 147);
            this.buttonValuePlus.Name = "buttonValuePlus";
            this.buttonValuePlus.Size = new System.Drawing.Size(75, 23);
            this.buttonValuePlus.TabIndex = 3;
            this.buttonValuePlus.Text = "+1VALUE";
            this.buttonValuePlus.UseVisualStyleBackColor = true;
            this.buttonValuePlus.Click += new System.EventHandler(this.buttonValuePlus_Click);
            // 
            // buttonValueMinus
            // 
            this.buttonValueMinus.Location = new System.Drawing.Point(371, 176);
            this.buttonValueMinus.Name = "buttonValueMinus";
            this.buttonValueMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonValueMinus.TabIndex = 4;
            this.buttonValueMinus.Text = "-1VALUE";
            this.buttonValueMinus.UseVisualStyleBackColor = true;
            this.buttonValueMinus.Click += new System.EventHandler(this.buttonValueMinus_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(272, 357);
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
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 547);
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
    }
}

