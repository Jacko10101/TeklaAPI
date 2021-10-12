
namespace CreateBeamWithPoints
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
            this.beamBtn = new System.Windows.Forms.Button();
            this.beamNameTb = new System.Windows.Forms.TextBox();
            this.beamNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beamBtn
            // 
            this.beamBtn.Location = new System.Drawing.Point(321, 195);
            this.beamBtn.Name = "beamBtn";
            this.beamBtn.Size = new System.Drawing.Size(136, 65);
            this.beamBtn.TabIndex = 0;
            this.beamBtn.Text = "‌Insert Beam";
            this.beamBtn.UseVisualStyleBackColor = true;
            this.beamBtn.Click += new System.EventHandler(this.beamBtn_Click);
            // 
            // beamNameTb
            // 
            this.beamNameTb.Location = new System.Drawing.Point(336, 133);
            this.beamNameTb.Name = "beamNameTb";
            this.beamNameTb.Size = new System.Drawing.Size(100, 20);
            this.beamNameTb.TabIndex = 1;
            // 
            // beamNameLbl
            // 
            this.beamNameLbl.AutoSize = true;
            this.beamNameLbl.Location = new System.Drawing.Point(269, 136);
            this.beamNameLbl.Name = "beamNameLbl";
            this.beamNameLbl.Size = new System.Drawing.Size(35, 13);
            this.beamNameLbl.TabIndex = 2;
            this.beamNameLbl.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beamNameLbl);
            this.Controls.Add(this.beamNameTb);
            this.Controls.Add(this.beamBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beamBtn;
        private System.Windows.Forms.TextBox beamNameTb;
        private System.Windows.Forms.Label beamNameLbl;
    }
}

