
namespace CreateFittingAndCutsOnObject
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
            this.beamBTN = new System.Windows.Forms.Button();
            this.beamCutsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beamBTN
            // 
            this.beamBTN.Location = new System.Drawing.Point(306, 107);
            this.beamBTN.Name = "beamBTN";
            this.beamBTN.Size = new System.Drawing.Size(148, 75);
            this.beamBTN.TabIndex = 0;
            this.beamBTN.Text = "Create Beam with fittings";
            this.beamBTN.UseVisualStyleBackColor = true;
            this.beamBTN.Click += new System.EventHandler(this.beamBTN_Click);
            // 
            // beamCutsBTN
            // 
            this.beamCutsBTN.Location = new System.Drawing.Point(306, 273);
            this.beamCutsBTN.Name = "beamCutsBTN";
            this.beamCutsBTN.Size = new System.Drawing.Size(148, 75);
            this.beamCutsBTN.TabIndex = 1;
            this.beamCutsBTN.Text = "Create Beam with cuts";
            this.beamCutsBTN.UseVisualStyleBackColor = true;
            this.beamCutsBTN.Click += new System.EventHandler(this.beamCutsBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beamCutsBTN);
            this.Controls.Add(this.beamBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beamBTN;
        private System.Windows.Forms.Button beamCutsBTN;
    }
}

