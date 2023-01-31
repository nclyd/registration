
namespace Registration
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
            this.pBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnLeftCycle = new System.Windows.Forms.Button();
            this.btnRightCycle = new System.Windows.Forms.Button();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxForename = new System.Windows.Forms.TextBox();
            this.tboxSurname = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxAvatar
            // 
            this.pBoxAvatar.Location = new System.Drawing.Point(83, 36);
            this.pBoxAvatar.Name = "pBoxAvatar";
            this.pBoxAvatar.Size = new System.Drawing.Size(100, 99);
            this.pBoxAvatar.TabIndex = 0;
            this.pBoxAvatar.TabStop = false;
            // 
            // btnLeftCycle
            // 
            this.btnLeftCycle.Location = new System.Drawing.Point(2, 77);
            this.btnLeftCycle.Name = "btnLeftCycle";
            this.btnLeftCycle.Size = new System.Drawing.Size(75, 23);
            this.btnLeftCycle.TabIndex = 1;
            this.btnLeftCycle.Text = "Left";
            this.btnLeftCycle.UseVisualStyleBackColor = true;
            this.btnLeftCycle.Click += new System.EventHandler(this.btnLeftCycle_Click);
            // 
            // btnRightCycle
            // 
            this.btnRightCycle.Location = new System.Drawing.Point(189, 77);
            this.btnRightCycle.Name = "btnRightCycle";
            this.btnRightCycle.Size = new System.Drawing.Size(75, 23);
            this.btnRightCycle.TabIndex = 2;
            this.btnRightCycle.Text = "Right";
            this.btnRightCycle.UseVisualStyleBackColor = true;
            this.btnRightCycle.Click += new System.EventHandler(this.btnRightCycle_Click);
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(102, 190);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(175, 20);
            this.tboxUsername.TabIndex = 3;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(102, 236);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(175, 20);
            this.tboxPassword.TabIndex = 4;
            // 
            // tboxForename
            // 
            this.tboxForename.Location = new System.Drawing.Point(102, 281);
            this.tboxForename.Name = "tboxForename";
            this.tboxForename.Size = new System.Drawing.Size(175, 20);
            this.tboxForename.TabIndex = 5;
            // 
            // tboxSurname
            // 
            this.tboxSurname.Location = new System.Drawing.Point(102, 326);
            this.tboxSurname.Name = "tboxSurname";
            this.tboxSurname.Size = new System.Drawing.Size(175, 20);
            this.tboxSurname.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 193);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 239);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(29, 284);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 9;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(36, 329);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Surname:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(234, 385);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 448);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tboxSurname);
            this.Controls.Add(this.tboxForename);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.btnRightCycle);
            this.Controls.Add(this.btnLeftCycle);
            this.Controls.Add(this.pBoxAvatar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxAvatar;
        private System.Windows.Forms.Button btnLeftCycle;
        private System.Windows.Forms.Button btnRightCycle;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxForename;
        private System.Windows.Forms.TextBox tboxSurname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tboxPassword;
    }
}

