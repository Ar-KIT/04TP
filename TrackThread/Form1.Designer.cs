namespace TrackThread
{
    partial class frmTrackThread
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
            this.lblTrackThread = new System.Windows.Forms.Label();
            this.btnRunThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrackThread
            // 
            this.lblTrackThread.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTrackThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackThread.Location = new System.Drawing.Point(28, 39);
            this.lblTrackThread.Name = "lblTrackThread";
            this.lblTrackThread.Size = new System.Drawing.Size(317, 54);
            this.lblTrackThread.TabIndex = 0;
            this.lblTrackThread.Text = "-Thread Starts-";
            this.lblTrackThread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunThread
            // 
            this.btnRunThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunThread.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRunThread.Location = new System.Drawing.Point(124, 153);
            this.btnRunThread.Name = "btnRunThread";
            this.btnRunThread.Size = new System.Drawing.Size(135, 45);
            this.btnRunThread.TabIndex = 2;
            this.btnRunThread.Text = "Run";
            this.btnRunThread.UseVisualStyleBackColor = true;
            this.btnRunThread.Click += new System.EventHandler(this.btnRunThread_Click);
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 226);
            this.Controls.Add(this.btnRunThread);
            this.Controls.Add(this.lblTrackThread);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrackThread";
            this.Text = "frmTrackThread";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrackThread;
        private System.Windows.Forms.Button btnRunThread;
    }
}

