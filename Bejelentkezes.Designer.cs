
namespace Allatkorhaz
{
    partial class Bejelentkezes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBelepes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Felhasználó";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(141, 27);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(206, 26);
            this.tbUser.TabIndex = 0;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(141, 135);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(206, 26);
            this.tbPwd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jelszó";
            // 
            // btnBelepes
            // 
            this.btnBelepes.Location = new System.Drawing.Point(29, 299);
            this.btnBelepes.Name = "btnBelepes";
            this.btnBelepes.Size = new System.Drawing.Size(119, 55);
            this.btnBelepes.TabIndex = 2;
            this.btnBelepes.Text = "Belépés";
            this.btnBelepes.UseVisualStyleBackColor = true;
            this.btnBelepes.Click += new System.EventHandler(this.btnBelepes_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(184, 299);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(119, 55);
            this.btnMegsem.TabIndex = 3;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // Bejelentkezes
            // 
            this.AcceptButton = this.btnBelepes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMegsem;
            this.ClientSize = new System.Drawing.Size(359, 378);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnBelepes);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.Shown += new System.EventHandler(this.Bejelentkezes_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBelepes;
        private System.Windows.Forms.Button btnMegsem;
    }
}

