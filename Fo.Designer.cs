
namespace Allatkorhaz
{
    partial class Fo
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
            this.btnKezelesek = new System.Windows.Forms.Button();
            this.btnKutyafajtak = new System.Windows.Forms.Button();
            this.btnGazdak = new System.Windows.Forms.Button();
            this.btnKutyak = new System.Windows.Forms.Button();
            this.btnKezelesfajtak = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKezelesek
            // 
            this.btnKezelesek.Location = new System.Drawing.Point(103, 12);
            this.btnKezelesek.Name = "btnKezelesek";
            this.btnKezelesek.Size = new System.Drawing.Size(362, 58);
            this.btnKezelesek.TabIndex = 0;
            this.btnKezelesek.Text = "Kezelések";
            this.btnKezelesek.UseVisualStyleBackColor = true;
            this.btnKezelesek.Click += new System.EventHandler(this.btnKezelesek_Click);
            // 
            // btnKutyafajtak
            // 
            this.btnKutyafajtak.Location = new System.Drawing.Point(103, 76);
            this.btnKutyafajtak.Name = "btnKutyafajtak";
            this.btnKutyafajtak.Size = new System.Drawing.Size(362, 58);
            this.btnKutyafajtak.TabIndex = 1;
            this.btnKutyafajtak.Text = "Kutyafajták";
            this.btnKutyafajtak.UseVisualStyleBackColor = true;
            this.btnKutyafajtak.Click += new System.EventHandler(this.btnKutyafajtak_Click);
            // 
            // btnGazdak
            // 
            this.btnGazdak.Location = new System.Drawing.Point(103, 140);
            this.btnGazdak.Name = "btnGazdak";
            this.btnGazdak.Size = new System.Drawing.Size(362, 58);
            this.btnGazdak.TabIndex = 2;
            this.btnGazdak.Text = "Gazdák";
            this.btnGazdak.UseVisualStyleBackColor = true;
            // 
            // btnKutyak
            // 
            this.btnKutyak.Location = new System.Drawing.Point(103, 204);
            this.btnKutyak.Name = "btnKutyak";
            this.btnKutyak.Size = new System.Drawing.Size(362, 58);
            this.btnKutyak.TabIndex = 3;
            this.btnKutyak.Text = "Kutyák";
            this.btnKutyak.UseVisualStyleBackColor = true;
            // 
            // btnKezelesfajtak
            // 
            this.btnKezelesfajtak.Location = new System.Drawing.Point(103, 268);
            this.btnKezelesfajtak.Name = "btnKezelesfajtak";
            this.btnKezelesfajtak.Size = new System.Drawing.Size(362, 58);
            this.btnKezelesfajtak.TabIndex = 4;
            this.btnKezelesfajtak.Text = "Kezelésfajták";
            this.btnKezelesfajtak.UseVisualStyleBackColor = true;
            this.btnKezelesfajtak.Click += new System.EventHandler(this.btnKezelesfajtak_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKilepes.Location = new System.Drawing.Point(103, 332);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(362, 58);
            this.btnKilepes.TabIndex = 5;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // Fo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(574, 448);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKezelesfajtak);
            this.Controls.Add(this.btnKutyak);
            this.Controls.Add(this.btnGazdak);
            this.Controls.Add(this.btnKutyafajtak);
            this.Controls.Add(this.btnKezelesek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fo_FormClosing);
            this.Shown += new System.EventHandler(this.Fo_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKezelesek;
        private System.Windows.Forms.Button btnKutyafajtak;
        private System.Windows.Forms.Button btnGazdak;
        private System.Windows.Forms.Button btnKutyak;
        private System.Windows.Forms.Button btnKezelesfajtak;
        private System.Windows.Forms.Button btnKilepes;
    }
}