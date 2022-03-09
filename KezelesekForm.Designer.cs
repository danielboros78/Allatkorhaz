
namespace Allatkorhaz
{
    partial class KezelesekForm
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
            this.dgvKutyak = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutyanev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fajtanev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gazda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezeles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kezdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutyak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKutyak
            // 
            this.dgvKutyak.AllowUserToAddRows = false;
            this.dgvKutyak.AllowUserToDeleteRows = false;
            this.dgvKutyak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKutyak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kutyanev,
            this.fajtanev,
            this.gazda,
            this.kezeles,
            this.kezdet,
            this.veg,
            this.dij});
            this.dgvKutyak.Location = new System.Drawing.Point(12, 12);
            this.dgvKutyak.MultiSelect = false;
            this.dgvKutyak.Name = "dgvKutyak";
            this.dgvKutyak.ReadOnly = true;
            this.dgvKutyak.RowHeadersVisible = false;
            this.dgvKutyak.RowTemplate.Height = 30;
            this.dgvKutyak.Size = new System.Drawing.Size(687, 453);
            this.dgvKutyak.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(406, 471);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(794, 414);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(92, 50);
            this.btnKilepes.TabIndex = 2;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            // 
            // btnMegsem
            // 
            this.btnMegsem.Enabled = false;
            this.btnMegsem.Location = new System.Drawing.Point(794, 358);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(92, 50);
            this.btnMegsem.TabIndex = 3;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Location = new System.Drawing.Point(794, 302);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(92, 50);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(794, 124);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(92, 50);
            this.btnTorles.TabIndex = 5;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(794, 68);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(92, 50);
            this.btnUj.TabIndex = 6;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(794, 12);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(92, 50);
            this.btnModosit.TabIndex = 7;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // kutyanev
            // 
            this.kutyanev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kutyanev.DataPropertyName = "kutyanev";
            this.kutyanev.HeaderText = "Kutyanév";
            this.kutyanev.Name = "kutyanev";
            this.kutyanev.ReadOnly = true;
            this.kutyanev.Width = 99;
            // 
            // fajtanev
            // 
            this.fajtanev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fajtanev.DataPropertyName = "fajtanev";
            this.fajtanev.HeaderText = "Fajtanév";
            this.fajtanev.Name = "fajtanev";
            this.fajtanev.ReadOnly = true;
            // 
            // gazda
            // 
            this.gazda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gazda.DataPropertyName = "nev";
            this.gazda.HeaderText = "Gazda";
            this.gazda.Name = "gazda";
            this.gazda.ReadOnly = true;
            this.gazda.Width = 82;
            // 
            // kezeles
            // 
            this.kezeles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kezeles.DataPropertyName = "jelleg";
            this.kezeles.HeaderText = "Kezelés";
            this.kezeles.Name = "kezeles";
            this.kezeles.ReadOnly = true;
            this.kezeles.Width = 90;
            // 
            // kezdet
            // 
            this.kezdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kezdet.DataPropertyName = "kezdet";
            this.kezdet.HeaderText = "Kezdet";
            this.kezdet.Name = "kezdet";
            this.kezdet.ReadOnly = true;
            this.kezdet.Width = 84;
            // 
            // veg
            // 
            this.veg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.veg.DataPropertyName = "veg";
            this.veg.HeaderText = "Vég";
            this.veg.Name = "veg";
            this.veg.ReadOnly = true;
            this.veg.Width = 63;
            // 
            // dij
            // 
            this.dij.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dij.DataPropertyName = "dij";
            this.dij.HeaderText = "Díj";
            this.dij.Name = "dij";
            this.dij.ReadOnly = true;
            this.dij.Width = 52;
            // 
            // KezelesekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 620);
            this.ControlBox = false;
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvKutyak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KezelesekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KezelesekForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutyak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKutyak;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutyanev;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtanev;
        private System.Windows.Forms.DataGridViewTextBoxColumn gazda;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezeles;
        private System.Windows.Forms.DataGridViewTextBoxColumn kezdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn veg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dij;
    }
}