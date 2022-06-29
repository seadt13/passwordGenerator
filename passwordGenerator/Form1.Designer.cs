namespace passwordGenerator
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
            this.password = new System.Windows.Forms.Label();
            this.lbPasswordLength = new System.Windows.Forms.Label();
            this.tbPasswordLength = new System.Windows.Forms.TrackBar();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Cursor = System.Windows.Forms.Cursors.Default;
            this.password.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(210, 173);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(521, 50);
            this.password.TabIndex = 0;
            this.password.Text = "*****";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPasswordLength
            // 
            this.lbPasswordLength.AutoSize = true;
            this.lbPasswordLength.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPasswordLength.Location = new System.Drawing.Point(265, 307);
            this.lbPasswordLength.Name = "lbPasswordLength";
            this.lbPasswordLength.Size = new System.Drawing.Size(402, 50);
            this.lbPasswordLength.TabIndex = 1;
            this.lbPasswordLength.Text = "Password Length: 5";
            // 
            // tbPasswordLength
            // 
            this.tbPasswordLength.Location = new System.Drawing.Point(210, 361);
            this.tbPasswordLength.Name = "tbPasswordLength";
            this.tbPasswordLength.Size = new System.Drawing.Size(521, 56);
            this.tbPasswordLength.TabIndex = 2;
            this.tbPasswordLength.Scroll += new System.EventHandler(this.tbPasswordLength_Scroll);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.BackColor = System.Drawing.Color.Firebrick;
            this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopyPassword.Location = new System.Drawing.Point(210, 423);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(521, 46);
            this.btnCopyPassword.TabIndex = 3;
            this.btnCopyPassword.Text = "Copy to Clipboard";
            this.btnCopyPassword.UseVisualStyleBackColor = false;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(946, 601);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.tbPasswordLength);
            this.Controls.Add(this.lbPasswordLength);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label password;
        private Label lbPasswordLength;
        private TrackBar tbPasswordLength;
        private Button btnCopyPassword;
    }
}