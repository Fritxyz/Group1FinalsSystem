namespace LibraryManagementSystem
{
    partial class StartingForm
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
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.picBoxUnShow = new System.Windows.Forms.PictureBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.picBoxUsername = new System.Windows.Forms.PictureBox();
            this.picBoxAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(58)))));
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.White;
            this.txtBoxUsername.Location = new System.Drawing.Point(88, 250);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUsername.MaxLength = 10;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(275, 23);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(58)))));
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxPassword.Location = new System.Drawing.Point(88, 359);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPassword.MaxLength = 10;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(275, 23);
            this.txtBoxPassword.TabIndex = 2;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Location = new System.Drawing.Point(88, 281);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(275, 2);
            this.pnlUsername.TabIndex = 5;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(88, 390);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(275, 2);
            this.pnlPassword.TabIndex = 6;
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnLogIn.Location = new System.Drawing.Point(131, 460);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(141, 46);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnRefresh.Location = new System.Drawing.Point(131, 513);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 46);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picBoxMinimize
            // 
            this.picBoxMinimize.Image = global::LibraryManagementSystem.Properties.Resources.minimize;
            this.picBoxMinimize.Location = new System.Drawing.Point(319, 1);
            this.picBoxMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxMinimize.Name = "picBoxMinimize";
            this.picBoxMinimize.Size = new System.Drawing.Size(36, 33);
            this.picBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimize.TabIndex = 11;
            this.picBoxMinimize.TabStop = false;
            this.picBoxMinimize.Click += new System.EventHandler(this.picBoxMinimize_Click);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Image = global::LibraryManagementSystem.Properties.Resources.close;
            this.picBoxClose.Location = new System.Drawing.Point(363, 1);
            this.picBoxClose.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(36, 33);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxClose.TabIndex = 10;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            // 
            // picBoxUnShow
            // 
            this.picBoxUnShow.Image = global::LibraryManagementSystem.Properties.Resources.unshow_icon;
            this.picBoxUnShow.Location = new System.Drawing.Point(324, 400);
            this.picBoxUnShow.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxUnShow.Name = "picBoxUnShow";
            this.picBoxUnShow.Size = new System.Drawing.Size(39, 32);
            this.picBoxUnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUnShow.TabIndex = 9;
            this.picBoxUnShow.TabStop = false;
            this.picBoxUnShow.Click += new System.EventHandler(this.picBoxUnShow_Click);
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.Image = global::LibraryManagementSystem.Properties.Resources.password_icon__1_;
            this.picBoxPassword.Location = new System.Drawing.Point(28, 338);
            this.picBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(52, 48);
            this.picBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPassword.TabIndex = 4;
            this.picBoxPassword.TabStop = false;
            // 
            // picBoxUsername
            // 
            this.picBoxUsername.Image = global::LibraryManagementSystem.Properties.Resources.user_icon;
            this.picBoxUsername.Location = new System.Drawing.Point(28, 236);
            this.picBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxUsername.Name = "picBoxUsername";
            this.picBoxUsername.Size = new System.Drawing.Size(52, 48);
            this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUsername.TabIndex = 3;
            this.picBoxUsername.TabStop = false;
            // 
            // picBoxAdmin
            // 
            this.picBoxAdmin.Image = global::LibraryManagementSystem.Properties.Resources.admin;
            this.picBoxAdmin.ImageLocation = "assets\\admin.png";
            this.picBoxAdmin.Location = new System.Drawing.Point(131, 74);
            this.picBoxAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxAdmin.Name = "picBoxAdmin";
            this.picBoxAdmin.Size = new System.Drawing.Size(141, 123);
            this.picBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdmin.TabIndex = 0;
            this.picBoxAdmin.TabStop = false;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(403, 606);
            this.Controls.Add(this.picBoxMinimize);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.picBoxUnShow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.picBoxPassword);
            this.Controls.Add(this.picBoxUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.picBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAdmin;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.PictureBox picBoxUsername;
        private System.Windows.Forms.PictureBox picBoxPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picBoxUnShow;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.PictureBox picBoxMinimize;
    }
}