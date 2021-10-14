
namespace CreateBeamWithUserInput
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
            this.beamButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.profileTB = new System.Windows.Forms.TextBox();
            this.classTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.materialTB = new System.Windows.Forms.TextBox();
            this.psTB = new System.Windows.Forms.TextBox();
            this.anTB = new System.Windows.Forms.TextBox();
            this.asTB = new System.Windows.Forms.TextBox();
            this.pnTB = new System.Windows.Forms.TextBox();
            this.planeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.depthCB = new System.Windows.Forms.ComboBox();
            this.rotationCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // beamButton
            // 
            this.beamButton.Location = new System.Drawing.Point(448, 127);
            this.beamButton.Name = "beamButton";
            this.beamButton.Size = new System.Drawing.Size(174, 77);
            this.beamButton.TabIndex = 0;
            this.beamButton.Text = "Insert Beam";
            this.beamButton.UseVisualStyleBackColor = true;
            this.beamButton.Click += new System.EventHandler(this.beamButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beam Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "On Plane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pos No";
            // 
            // profileTB
            // 
            this.profileTB.Location = new System.Drawing.Point(34, 66);
            this.profileTB.Name = "profileTB";
            this.profileTB.Size = new System.Drawing.Size(100, 20);
            this.profileTB.TabIndex = 8;
            // 
            // classTB
            // 
            this.classTB.Location = new System.Drawing.Point(546, 66);
            this.classTB.Name = "classTB";
            this.classTB.Size = new System.Drawing.Size(100, 20);
            this.classTB.TabIndex = 9;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(425, 66);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 10;
            // 
            // materialTB
            // 
            this.materialTB.Location = new System.Drawing.Point(297, 66);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(100, 20);
            this.materialTB.TabIndex = 11;
            // 
            // psTB
            // 
            this.psTB.Location = new System.Drawing.Point(173, 66);
            this.psTB.Multiline = true;
            this.psTB.Name = "psTB";
            this.psTB.Size = new System.Drawing.Size(35, 20);
            this.psTB.TabIndex = 12;
            // 
            // anTB
            // 
            this.anTB.Location = new System.Drawing.Point(222, 92);
            this.anTB.Multiline = true;
            this.anTB.Name = "anTB";
            this.anTB.Size = new System.Drawing.Size(35, 20);
            this.anTB.TabIndex = 13;
            // 
            // asTB
            // 
            this.asTB.Location = new System.Drawing.Point(173, 92);
            this.asTB.Multiline = true;
            this.asTB.Name = "asTB";
            this.asTB.Size = new System.Drawing.Size(35, 20);
            this.asTB.TabIndex = 14;
            // 
            // pnTB
            // 
            this.pnTB.Location = new System.Drawing.Point(222, 66);
            this.pnTB.Multiline = true;
            this.pnTB.Name = "pnTB";
            this.pnTB.Size = new System.Drawing.Size(35, 20);
            this.pnTB.TabIndex = 15;
            // 
            // planeCB
            // 
            this.planeCB.FormattingEnabled = true;
            this.planeCB.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.planeCB.Location = new System.Drawing.Point(298, 156);
            this.planeCB.Name = "planeCB";
            this.planeCB.Size = new System.Drawing.Size(84, 21);
            this.planeCB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "At Depth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rotation";
            // 
            // depthCB
            // 
            this.depthCB.FormattingEnabled = true;
            this.depthCB.Items.AddRange(new object[] {
            "Middle",
            "Front",
            "Behind"});
            this.depthCB.Location = new System.Drawing.Point(173, 157);
            this.depthCB.Name = "depthCB";
            this.depthCB.Size = new System.Drawing.Size(84, 21);
            this.depthCB.TabIndex = 19;
            // 
            // rotationCB
            // 
            this.rotationCB.FormattingEnabled = true;
            this.rotationCB.Items.AddRange(new object[] {
            "Front",
            "Top",
            "Back",
            "Below"});
            this.rotationCB.Location = new System.Drawing.Point(43, 157);
            this.rotationCB.Name = "rotationCB";
            this.rotationCB.Size = new System.Drawing.Size(84, 21);
            this.rotationCB.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 224);
            this.Controls.Add(this.rotationCB);
            this.Controls.Add(this.depthCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.planeCB);
            this.Controls.Add(this.pnTB);
            this.Controls.Add(this.asTB);
            this.Controls.Add(this.anTB);
            this.Controls.Add(this.psTB);
            this.Controls.Add(this.materialTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.classTB);
            this.Controls.Add(this.profileTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beamButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beamButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox profileTB;
        private System.Windows.Forms.TextBox classTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.TextBox psTB;
        private System.Windows.Forms.TextBox anTB;
        private System.Windows.Forms.TextBox asTB;
        private System.Windows.Forms.TextBox pnTB;
        private System.Windows.Forms.ComboBox planeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox depthCB;
        private System.Windows.Forms.ComboBox rotationCB;
    }
}

