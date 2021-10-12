
namespace CreateBoltArray
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
            this.boltButton = new System.Windows.Forms.Button();
            this.bStanTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSizeTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boltButton
            // 
            this.boltButton.Location = new System.Drawing.Point(90, 117);
            this.boltButton.Name = "boltButton";
            this.boltButton.Size = new System.Drawing.Size(106, 60);
            this.boltButton.TabIndex = 0;
            this.boltButton.Text = "Create Bolts";
            this.boltButton.UseVisualStyleBackColor = true;
            this.boltButton.Click += new System.EventHandler(this.boltButton_Click);
            // 
            // bStanTB
            // 
            this.bStanTB.Location = new System.Drawing.Point(120, 28);
            this.bStanTB.Name = "bStanTB";
            this.bStanTB.Size = new System.Drawing.Size(100, 20);
            this.bStanTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bolt Standard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bolt Size";
            // 
            // bSizeTB
            // 
            this.bSizeTB.Location = new System.Drawing.Point(120, 70);
            this.bSizeTB.Name = "bSizeTB";
            this.bSizeTB.Size = new System.Drawing.Size(100, 20);
            this.bSizeTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSizeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStanTB);
            this.Controls.Add(this.boltButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boltButton;
        private System.Windows.Forms.TextBox bStanTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bSizeTB;
    }
}

