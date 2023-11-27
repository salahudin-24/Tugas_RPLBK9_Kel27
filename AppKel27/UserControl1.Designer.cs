namespace AppKel27
{
    partial class UserControl1
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
            UsernameComponent = new LafLightBluebel();
            EditButtonUser = new Button();
            DeleteButtonUser = new Button();
            SuspendLayout();
            // 
            // UsernameComponent
            // 
            UsernameComponent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameComponent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameComponent.Location = new Point(14, 10);
            UsernameComponent.Name = "UsernameComponent";
            UsernameComponent.Size = new Size(122, 100);
            UsernameComponent.TabIndex = 0;
            UsernameComponent.Text = "label1";
            // 
            // EditButtonUser
            // 
            EditButtonUser.AutoSize = true;
            EditButtonUser.Dock = DockStyle.Bottom;
            EditButtonUser.Location = new Point(0, 144);
            EditButtonUser.Margin = new Padding(3, 4, 3, 4);
            EditButtonUser.Name = "EditButtonUser";
            EditButtonUser.Size = new Size(158, 30);
            EditButtonUser.TabIndex = 1;
            EditButtonUser.Text = "Edit";
            EditButtonUser.UseVisualStyleBackColor = true;
            EditButtonUser.Click += EditButtonUser_Click;
            // 
            // DeleteButtonUser
            // 
            DeleteButtonUser.AutoSize = true;
            DeleteButtonUser.BackColor = Color.SteelBlue;
            DeleteButtonUser.Dock = DockStyle.Bottom;
            DeleteButtonUser.Location = new Point(0, 114);
            DeleteButtonUser.Margin = new Padding(3, 4, 3, 4);
            DeleteButtonUser.Name = "DeleteButtonUser";
            DeleteButtonUser.Size = new Size(158, 30);
            DeleteButtonUser.TabIndex = 2;
            DeleteButtonUser.Text = "Delete";
            DeleteButtonUser.UseVisualStyleBackColor = false;
            DeleteButtonUser.Click += DeleteButtonUser_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(DeleteButtonUser);
            Controls.Add(EditButtonUser);
            Controls.Add(UsernameComponent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(158, 174);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameComponent;
        private Button EditButtonUser;
        private Button DeleteButtonUser;
    }
}
