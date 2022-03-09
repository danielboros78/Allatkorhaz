
namespace Allatkorhaz
{
    partial class KezelesFajtak
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
            this.tbFajta = new System.Windows.Forms.TextBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.dgvKfajta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fajtanev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKfajta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFajta
            // 
            this.tbFajta.Enabled = false;
            this.tbFajta.Location = new System.Drawing.Point(44, 455);
            this.tbFajta.Name = "tbFajta";
            this.tbFajta.Size = new System.Drawing.Size(378, 26);
            this.tbFajta.TabIndex = 10;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(496, 431);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(92, 50);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.Enabled = false;
            this.btnMegsem.Location = new System.Drawing.Point(496, 375);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(92, 50);
            this.btnMegsem.TabIndex = 5;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Location = new System.Drawing.Point(496, 319);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(92, 50);
            this.btnMentes.TabIndex = 6;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(496, 141);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(92, 50);
            this.btnTorles.TabIndex = 7;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(496, 85);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(92, 50);
            this.btnUj.TabIndex = 8;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(496, 29);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(92, 50);
            this.btnModosit.TabIndex = 9;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // dgvKfajta
            // 
            this.dgvKfajta.AllowUserToAddRows = false;
            this.dgvKfajta.AllowUserToDeleteRows = false;
            this.dgvKfajta.ColumnHeadersHeight = 40;
            this.dgvKfajta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKfajta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fajtanev});
            this.dgvKfajta.Location = new System.Drawing.Point(44, 29);
            this.dgvKfajta.MultiSelect = false;
            this.dgvKfajta.Name = "dgvKfajta";
            this.dgvKfajta.ReadOnly = true;
            this.dgvKfajta.RowHeadersVisible = false;
            this.dgvKfajta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKfajta.RowTemplate.Height = 35;
            this.dgvKfajta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKfajta.Size = new System.Drawing.Size(378, 384);
            this.dgvKfajta.TabIndex = 3;
            this.dgvKfajta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFajta_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fajtanev
            // 
            this.fajtanev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fajtanev.DataPropertyName = "jelleg";
            this.fajtanev.HeaderText = "Jelleg";
            this.fajtanev.Name = "fajtanev";
            this.fajtanev.ReadOnly = true;
            // 
            // KezelesFajtak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 531);
            this.ControlBox = false;
            this.Controls.Add(this.tbFajta);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.dgvKfajta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KezelesFajtak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelésfajták";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKfajta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFajta;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.DataGridView dgvKfajta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtanev;
    }
}