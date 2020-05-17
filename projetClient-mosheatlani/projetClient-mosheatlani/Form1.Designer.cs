namespace projetClient_mosheatlani
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.PostalCode = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(144, 115);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 31);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(21, 118);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(118, 25);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "first name :";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(21, 213);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(117, 25);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "last name :";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(144, 213);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(136, 31);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(82, 310);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 25);
            this.ID.TabIndex = 5;
            this.ID.Text = "id :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(144, 304);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(136, 31);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(400, 310);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(60, 25);
            this.Age.TabIndex = 11;
            this.Age.Text = "age :";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(499, 307);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(136, 31);
            this.textBoxAge.TabIndex = 10;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSize = true;
            this.PostalCode.Location = new System.Drawing.Point(349, 219);
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(135, 25);
            this.PostalCode.TabIndex = 9;
            this.PostalCode.Text = "postal code :";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(499, 216);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(136, 31);
            this.textBoxPostalCode.TabIndex = 8;
            this.textBoxPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(331, 118);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(162, 25);
            this.PhoneNumber.TabIndex = 7;
            this.PhoneNumber.Text = "phone number :";
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(499, 118);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(136, 31);
            this.textBoxPhoneNum.TabIndex = 6;
            this.textBoxPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(291, 396);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 48);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 664);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.PostalCode);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label PostalCode;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Button buttonSave;
    }
}

