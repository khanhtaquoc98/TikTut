namespace Tik_TUT.User_Control
{
    partial class UC_Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Profile));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegisterName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegisterCPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegisterPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegisterUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtLoginPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLoginUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtRegisterName);
            this.panel2.Controls.Add(this.txtRegisterCPass);
            this.panel2.Controls.Add(this.txtRegisterPass);
            this.panel2.Controls.Add(this.txtRegisterUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btRegister);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(449, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 450);
            this.panel2.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 344);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel1.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Depth = 0;
            this.txtPhone.Hint = "";
            this.txtPhone.Location = new System.Drawing.Point(30, 302);
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(163, 23);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.TabStop = false;
            this.txtPhone.Text = "           Phone number";
            this.txtPhone.UseSystemPasswordChar = false;
            this.txtPhone.Click += new System.EventHandler(this.materialSingleLineTextField7_Click);
            this.txtPhone.Leave += new System.EventHandler(this.materialSingleLineTextField7_Leave);
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Depth = 0;
            this.txtRegisterName.Hint = "";
            this.txtRegisterName.Location = new System.Drawing.Point(30, 246);
            this.txtRegisterName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.PasswordChar = '\0';
            this.txtRegisterName.SelectedText = "";
            this.txtRegisterName.SelectionLength = 0;
            this.txtRegisterName.SelectionStart = 0;
            this.txtRegisterName.Size = new System.Drawing.Size(180, 23);
            this.txtRegisterName.TabIndex = 7;
            this.txtRegisterName.TabStop = false;
            this.txtRegisterName.Text = "               Fullname";
            this.txtRegisterName.UseSystemPasswordChar = false;
            this.txtRegisterName.Click += new System.EventHandler(this.materialSingleLineTextField6_Click);
            this.txtRegisterName.Leave += new System.EventHandler(this.materialSingleLineTextField6_Leave);
            // 
            // txtRegisterCPass
            // 
            this.txtRegisterCPass.Depth = 0;
            this.txtRegisterCPass.Hint = "";
            this.txtRegisterCPass.Location = new System.Drawing.Point(30, 200);
            this.txtRegisterCPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegisterCPass.Name = "txtRegisterCPass";
            this.txtRegisterCPass.PasswordChar = '\0';
            this.txtRegisterCPass.SelectedText = "";
            this.txtRegisterCPass.SelectionLength = 0;
            this.txtRegisterCPass.SelectionStart = 0;
            this.txtRegisterCPass.Size = new System.Drawing.Size(163, 23);
            this.txtRegisterCPass.TabIndex = 6;
            this.txtRegisterCPass.TabStop = false;
            this.txtRegisterCPass.Text = "       Confirm Password";
            this.txtRegisterCPass.UseSystemPasswordChar = false;
            this.txtRegisterCPass.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            this.txtRegisterCPass.Leave += new System.EventHandler(this.materialSingleLineTextField5_Leave);
            // 
            // txtRegisterPass
            // 
            this.txtRegisterPass.Depth = 0;
            this.txtRegisterPass.Hint = "";
            this.txtRegisterPass.Location = new System.Drawing.Point(30, 150);
            this.txtRegisterPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegisterPass.Name = "txtRegisterPass";
            this.txtRegisterPass.PasswordChar = '\0';
            this.txtRegisterPass.SelectedText = "";
            this.txtRegisterPass.SelectionLength = 0;
            this.txtRegisterPass.SelectionStart = 0;
            this.txtRegisterPass.Size = new System.Drawing.Size(163, 23);
            this.txtRegisterPass.TabIndex = 5;
            this.txtRegisterPass.TabStop = false;
            this.txtRegisterPass.Text = "              Password";
            this.txtRegisterPass.UseSystemPasswordChar = false;
            this.txtRegisterPass.Click += new System.EventHandler(this.materialSingleLineTextField4_Click);
            this.txtRegisterPass.Leave += new System.EventHandler(this.materialSingleLineTextField4_Leave);
            // 
            // txtRegisterUser
            // 
            this.txtRegisterUser.Depth = 0;
            this.txtRegisterUser.Hint = "";
            this.txtRegisterUser.Location = new System.Drawing.Point(30, 100);
            this.txtRegisterUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegisterUser.Name = "txtRegisterUser";
            this.txtRegisterUser.PasswordChar = '\0';
            this.txtRegisterUser.SelectedText = "";
            this.txtRegisterUser.SelectionLength = 0;
            this.txtRegisterUser.SelectionStart = 0;
            this.txtRegisterUser.Size = new System.Drawing.Size(163, 23);
            this.txtRegisterUser.TabIndex = 4;
            this.txtRegisterUser.TabStop = false;
            this.txtRegisterUser.Text = "             Username";
            this.txtRegisterUser.UseSystemPasswordChar = false;
            this.txtRegisterUser.Click += new System.EventHandler(this.txtRegisterUser_Click);
            this.txtRegisterUser.Leave += new System.EventHandler(this.materialSingleLineTextField3_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btRegister
            // 
            this.btRegister.Depth = 0;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Location = new System.Drawing.Point(56, 380);
            this.btRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btRegister.Name = "btRegister";
            this.btRegister.Primary = true;
            this.btRegister.Size = new System.Drawing.Size(183, 43);
            this.btRegister.TabIndex = 9;
            this.btRegister.TabStop = false;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(121, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Register";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bunifuCustomLogin);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.txtLoginPass);
            this.panel1.Controls.Add(this.txtLoginUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(76, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 300);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLogin
            // 
            this.bunifuCustomLogin.AutoSize = true;
            this.bunifuCustomLogin.Location = new System.Drawing.Point(92, 191);
            this.bunifuCustomLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLogin.Name = "bunifuCustomLogin";
            this.bunifuCustomLogin.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLogin.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.Depth = 0;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(56, 217);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.Primary = true;
            this.btLogin.Size = new System.Drawing.Size(183, 43);
            this.btLogin.TabIndex = 3;
            this.btLogin.TabStop = false;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Depth = 0;
            this.txtLoginPass.Hint = "";
            this.txtLoginPass.Location = new System.Drawing.Point(64, 144);
            this.txtLoginPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '\0';
            this.txtLoginPass.SelectedText = "";
            this.txtLoginPass.SelectionLength = 0;
            this.txtLoginPass.SelectionStart = 0;
            this.txtLoginPass.Size = new System.Drawing.Size(152, 23);
            this.txtLoginPass.TabIndex = 2;
            this.txtLoginPass.TabStop = false;
            this.txtLoginPass.Text = "           Password";
            this.txtLoginPass.UseSystemPasswordChar = false;
            this.txtLoginPass.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            this.txtLoginPass.Leave += new System.EventHandler(this.materialSingleLineTextField2_Leave);
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Depth = 0;
            this.txtLoginUser.Hint = "";
            this.txtLoginUser.Location = new System.Drawing.Point(65, 90);
            this.txtLoginUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.PasswordChar = '\0';
            this.txtLoginUser.SelectedText = "";
            this.txtLoginUser.SelectionLength = 0;
            this.txtLoginUser.SelectionStart = 0;
            this.txtLoginUser.Size = new System.Drawing.Size(151, 23);
            this.txtLoginUser.TabIndex = 1;
            this.txtLoginUser.TabStop = false;
            this.txtLoginUser.Text = "          Username";
            this.txtLoginUser.UseSystemPasswordChar = false;
            this.txtLoginUser.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            this.txtLoginUser.Leave += new System.EventHandler(this.materialSingleLineTextField1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(89, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Login";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // UC_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Profile";
            this.Size = new System.Drawing.Size(780, 547);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegisterName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegisterCPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegisterPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegisterUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLogin;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}
