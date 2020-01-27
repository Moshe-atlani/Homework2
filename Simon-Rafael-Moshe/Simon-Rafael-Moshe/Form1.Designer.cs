namespace Simon_Rafael_Moshe
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxVert = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxRouge = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxJaune = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBleu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJaune)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.pictureBoxVert);
            this.groupBox1.Location = new System.Drawing.Point(137, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxVert";
            // 
            // pictureBoxVert
            // 
            this.pictureBoxVert.Location = new System.Drawing.Point(54, 60);
            this.pictureBoxVert.Name = "pictureBoxVert";
            this.pictureBoxVert.Size = new System.Drawing.Size(169, 155);
            this.pictureBoxVert.TabIndex = 2;
            this.pictureBoxVert.TabStop = false;
            this.pictureBoxVert.Click += new System.EventHandler(this.pictureBoxRouge_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Brown;
            this.groupBox2.Controls.Add(this.pictureBoxRouge);
            this.groupBox2.Location = new System.Drawing.Point(466, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxRouge";
            // 
            // pictureBoxRouge
            // 
            this.pictureBoxRouge.Location = new System.Drawing.Point(59, 60);
            this.pictureBoxRouge.Name = "pictureBoxRouge";
            this.pictureBoxRouge.Size = new System.Drawing.Size(169, 155);
            this.pictureBoxRouge.TabIndex = 3;
            this.pictureBoxRouge.TabStop = false;
            this.pictureBoxRouge.Click += new System.EventHandler(this.pictureBoxRouge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gold;
            this.groupBox3.Controls.Add(this.pictureBoxJaune);
            this.groupBox3.Location = new System.Drawing.Point(137, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 274);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBoxJaune";
            // 
            // pictureBoxJaune
            // 
            this.pictureBoxJaune.Location = new System.Drawing.Point(54, 61);
            this.pictureBoxJaune.Name = "pictureBoxJaune";
            this.pictureBoxJaune.Size = new System.Drawing.Size(169, 155);
            this.pictureBoxJaune.TabIndex = 4;
            this.pictureBoxJaune.TabStop = false;
            this.pictureBoxJaune.Click += new System.EventHandler(this.pictureBoxRouge_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Controls.Add(this.pictureBoxBleu);
            this.groupBox4.Location = new System.Drawing.Point(466, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 274);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBoxBleu";
            // 
            // pictureBoxBleu
            // 
            this.pictureBoxBleu.Location = new System.Drawing.Point(59, 61);
            this.pictureBoxBleu.Name = "pictureBoxBleu";
            this.pictureBoxBleu.Size = new System.Drawing.Size(169, 155);
            this.pictureBoxBleu.TabIndex = 5;
            this.pictureBoxBleu.TabStop = false;
            this.pictureBoxBleu.Click += new System.EventHandler(this.pictureBoxRouge_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 855);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJaune)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBoxVert;
        private System.Windows.Forms.PictureBox pictureBoxRouge;
        private System.Windows.Forms.PictureBox pictureBoxJaune;
        private System.Windows.Forms.PictureBox pictureBoxBleu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

