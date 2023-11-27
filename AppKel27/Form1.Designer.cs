namespace AppKel27
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UsernameLogin = new TextBox();
            PasswordLogin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 79);
            label1.Name = "label1";
            label1.Size = new Size(103, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 157);
            label2.Name = "label2";
            label2.Size = new Size(127, 35);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(319, 227);
            label3.Name = "label3";
            label3.Size = new Size(120, 35);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // UsernameLogin
            // 
            UsernameLogin.Location = new Point(325, 196);
            UsernameLogin.Margin = new Padding(3, 4, 3, 4);
            UsernameLogin.Name = "UsernameLogin";
            UsernameLogin.Size = new Size(263, 27);
            UsernameLogin.TabIndex = 3;
            // 
            // PasswordLogin
            // 
            PasswordLogin.Location = new Point(325, 266);
            PasswordLogin.Margin = new Padding(3, 4, 3, 4);
            PasswordLogin.Name = "PasswordLogin";
            PasswordLogin.Size = new Size(263, 27);
            PasswordLogin.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(502, 369);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(502, 301);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 345);
            label4.Name = "label4";
            label4.Size = new Size(254, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account? Register here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PasswordLogin);
            Controls.Add(UsernameLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login Page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameLogin;
        private TextBox PasswordLogin;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}