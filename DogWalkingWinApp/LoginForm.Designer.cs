namespace DogWalkingWinApp
{
    partial class LoginForm
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
            label1 = new Label();
            _txtUserName = new TextBox();
            label2 = new Label();
            _txtPassword = new TextBox();
            _btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(116, 79);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "User name:";
            // 
            // _txtUserName
            // 
            _txtUserName.Anchor = AnchorStyles.None;
            _txtUserName.Location = new Point(188, 76);
            _txtUserName.Name = "_txtUserName";
            _txtUserName.Size = new Size(134, 23);
            _txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(122, 119);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // _txtPassword
            // 
            _txtPassword.Anchor = AnchorStyles.None;
            _txtPassword.Location = new Point(188, 116);
            _txtPassword.Name = "_txtPassword";
            _txtPassword.PasswordChar = '*';
            _txtPassword.Size = new Size(134, 23);
            _txtPassword.TabIndex = 3;
            // 
            // _btnLogin
            // 
            _btnLogin.Anchor = AnchorStyles.None;
            _btnLogin.Location = new Point(166, 161);
            _btnLogin.Name = "_btnLogin";
            _btnLogin.Size = new Size(75, 23);
            _btnLogin.TabIndex = 4;
            _btnLogin.Text = "Login";
            _btnLogin.UseVisualStyleBackColor = true;
            _btnLogin.Click += _btnLogin_Click;
            // 
            // LoginForm
            // 
            AcceptButton = _btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 247);
            Controls.Add(_btnLogin);
            Controls.Add(_txtPassword);
            Controls.Add(label2);
            Controls.Add(_txtUserName);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox _txtUserName;
        private Label label2;
        private TextBox _txtPassword;
        private Button _btnLogin;
    }
}