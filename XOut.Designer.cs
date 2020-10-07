namespace XOutput
{
    partial class XOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XOut));
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.controllerBox = new System.Windows.Forms.GroupBox();
            this.controllerOptions = new System.Windows.Forms.Button();
            this.moveOneDown = new System.Windows.Forms.Button();
            this.controllerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Location = new System.Drawing.Point(12, 88);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(244, 23);
            this.StartStopBtn.TabIndex = 0;
            this.StartStopBtn.Text = "Start";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // controllerBox
            // 
            this.controllerBox.Controls.Add(this.controllerOptions);
            this.controllerBox.Controls.Add(this.moveOneDown);
            this.controllerBox.Location = new System.Drawing.Point(12, 12);
            this.controllerBox.Name = "controllerBox";
            this.controllerBox.Size = new System.Drawing.Size(244, 70);
            this.controllerBox.TabIndex = 1;
            this.controllerBox.TabStop = false;
            this.controllerBox.Text = "`";
            // 
            // controllerOptions
            // 
            this.controllerOptions.Image = global::XOutput.Properties.Resources.gear;
            this.controllerOptions.Location = new System.Drawing.Point(6, 20);
            this.controllerOptions.Name = "controllerOptions";
            this.controllerOptions.Size = new System.Drawing.Size(35, 35);
            this.controllerOptions.TabIndex = 7;
            this.controllerOptions.UseVisualStyleBackColor = true;
            // 
            // moveOneDown
            // 
            this.moveOneDown.Image = global::XOutput.Properties.Resources.arrow_Down;
            this.moveOneDown.Location = new System.Drawing.Point(427, 41);
            this.moveOneDown.Name = "moveOneDown";
            this.moveOneDown.Size = new System.Drawing.Size(27, 23);
            this.moveOneDown.TabIndex = 1;
            this.moveOneDown.UseVisualStyleBackColor = true;
            // 
            // XOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 122);
            this.Controls.Add(this.controllerBox);
            this.Controls.Add(this.StartStopBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XOut";
            this.Text = "XOutput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XOut_Closing);
            this.Load += new System.EventHandler(this.XOut_Load);
            this.Shown += new System.EventHandler(this.XOut_Shown);
            this.controllerBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartStopBtn;

        //private System.Windows.Forms.Button[] options;
        private ControllerOptions optionsWindow;
        private ControllerManager controllerManager;
        private System.Windows.Forms.GroupBox controllerBox;
        private System.Windows.Forms.Button moveOneDown;
        private System.Windows.Forms.Button controllerOptions;
    }
}