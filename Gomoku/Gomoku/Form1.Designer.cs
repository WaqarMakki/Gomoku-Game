namespace Gomoku
{
    partial class GForm
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
            this.Options = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HVsM = new System.Windows.Forms.RadioButton();
            this.HVsH = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Fifteenx15 = new System.Windows.Forms.RadioButton();
            this.Tenx10 = new System.Windows.Forms.RadioButton();
            this.Fivex5 = new System.Windows.Forms.RadioButton();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.Options.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.Controls.Add(this.panel1);
            this.Options.Controls.Add(this.Start);
            this.Options.Controls.Add(this.Fifteenx15);
            this.Options.Controls.Add(this.Tenx10);
            this.Options.Controls.Add(this.Fivex5);
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(791, 116);
            this.Options.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HVsM);
            this.panel1.Controls.Add(this.HVsH);
            this.panel1.Location = new System.Drawing.Point(463, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 81);
            this.panel1.TabIndex = 4;
            // 
            // HVsM
            // 
            this.HVsM.AutoSize = true;
            this.HVsM.Location = new System.Drawing.Point(15, 12);
            this.HVsM.Name = "HVsM";
            this.HVsM.Size = new System.Drawing.Size(82, 21);
            this.HVsM.TabIndex = 1;
            this.HVsM.TabStop = true;
            this.HVsM.Text = "1-Player";
            this.HVsM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HVsM.UseVisualStyleBackColor = true;
            // 
            // HVsH
            // 
            this.HVsH.AutoSize = true;
            this.HVsH.Location = new System.Drawing.Point(15, 48);
            this.HVsH.Name = "HVsH";
            this.HVsH.Size = new System.Drawing.Size(82, 21);
            this.HVsH.TabIndex = 0;
            this.HVsH.TabStop = true;
            this.HVsH.Text = "2-Player";
            this.HVsH.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(41, 21);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(232, 92);
            this.Start.TabIndex = 3;
            this.Start.Text = "Play";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Fifteenx15
            // 
            this.Fifteenx15.AutoSize = true;
            this.Fifteenx15.Location = new System.Drawing.Point(721, 75);
            this.Fifteenx15.Name = "Fifteenx15";
            this.Fifteenx15.Size = new System.Drawing.Size(67, 21);
            this.Fifteenx15.TabIndex = 2;
            this.Fifteenx15.TabStop = true;
            this.Fifteenx15.Text = "15x15";
            this.Fifteenx15.UseVisualStyleBackColor = true;
            // 
            // Tenx10
            // 
            this.Tenx10.AutoSize = true;
            this.Tenx10.Location = new System.Drawing.Point(721, 48);
            this.Tenx10.Name = "Tenx10";
            this.Tenx10.Size = new System.Drawing.Size(67, 21);
            this.Tenx10.TabIndex = 1;
            this.Tenx10.TabStop = true;
            this.Tenx10.Text = "10x10";
            this.Tenx10.UseVisualStyleBackColor = true;
            // 
            // Fivex5
            // 
            this.Fivex5.AutoSize = true;
            this.Fivex5.Location = new System.Drawing.Point(721, 21);
            this.Fivex5.Name = "Fivex5";
            this.Fivex5.Size = new System.Drawing.Size(51, 21);
            this.Fivex5.TabIndex = 0;
            this.Fivex5.TabStop = true;
            this.Fivex5.Text = "5x5";
            this.Fivex5.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Grid.Location = new System.Drawing.Point(0, 122);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1210, 650);
            this.Grid.TabIndex = 4;
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 772);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Options);
            this.Name = "GForm";
            this.Text = "Gomoku";
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Options;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton Fifteenx15;
        private System.Windows.Forms.RadioButton Tenx10;
        private System.Windows.Forms.RadioButton Fivex5;
        private System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton HVsM;
        private System.Windows.Forms.RadioButton HVsH;
    }
}