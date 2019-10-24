namespace Golden_Ratio
{
    partial class FRM_phi
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
            this.PB_main = new System.Windows.Forms.PictureBox();
            this.TB_angle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_angle)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_main
            // 
            this.PB_main.BackColor = System.Drawing.Color.Black;
            this.PB_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_main.Location = new System.Drawing.Point(0, 0);
            this.PB_main.Name = "PB_main";
            this.PB_main.Size = new System.Drawing.Size(800, 450);
            this.PB_main.TabIndex = 0;
            this.PB_main.TabStop = false;
            this.PB_main.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_main_Paint);
            // 
            // TB_angle
            // 
            this.TB_angle.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_angle.Location = new System.Drawing.Point(0, 0);
            this.TB_angle.Maximum = 2000;
            this.TB_angle.Minimum = -1000;
            this.TB_angle.Name = "TB_angle";
            this.TB_angle.Size = new System.Drawing.Size(800, 45);
            this.TB_angle.TabIndex = 1;
            this.TB_angle.Value = 500;
            this.TB_angle.Scroll += new System.EventHandler(this.TB_angle_Scroll);
            // 
            // FRM_phi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_angle);
            this.Controls.Add(this.PB_main);
            this.Name = "FRM_phi";
            this.Text = "Golden Ratio";
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_angle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_main;
        private System.Windows.Forms.TrackBar TB_angle;
    }
}

