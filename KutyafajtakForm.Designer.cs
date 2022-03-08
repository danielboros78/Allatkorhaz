
namespace Allatkorhaz
{
    partial class KutyafajtakForm
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
            this.dgvFajta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fajtanev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.tbFajta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFajta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFajta
            // 
            this.dgvFajta.AllowUserToAddRows = false;
            this.dgvFajta.AllowUserToDeleteRows = false;
            this.dgvFajta.ColumnHeadersHeight = 40;
            this.dgvFajta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFajta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fajtanev});
            this.dgvFajta.Location = new System.Drawing.Point(93, 55);
            this.dgvFajta.MultiSelect = false;
            this.dgvFajta.Name = "dgvFajta";
            this.dgvFajta.ReadOnly = true;
            this.dgvFajta.RowHeadersVisible = false;
            this.dgvFajta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFajta.RowTemplate.Height = 35;
            this.dgvFajta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFajta.Size = new System.Drawing.Size(378, 384);
            this.dgvFajta.TabIndex = 0;
            this.dgvFajta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFajta_CellClick);
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
            this.fajtanev.DataPropertyName = "fajtanev";
            this.fajtanev.HeaderText = "Fajtanév";
            this.fajtanev.Name = "fajtanev";
            this.fajtanev.ReadOnly = true;
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(545, 55);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(92, 50);
            this.btnModosit.TabIndex = 1;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(545, 111);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(92, 50);
            this.btnUj.TabIndex = 1;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(545, 167);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(92, 50);
            this.btnTorles.TabIndex = 1;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Location = new System.Drawing.Point(545, 345);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(92, 50);
            this.btnMentes.TabIndex = 1;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.Enabled = false;
            this.btnMegsem.Location = new System.Drawing.Point(545, 401);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(92, 50);
            this.btnMegsem.TabIndex = 1;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(545, 457);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(92, 50);
            this.btnKilepes.TabIndex = 1;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            // 
            // tbFajta
            // 
            this.tbFajta.Enabled = false;
            this.tbFajta.Location = new System.Drawing.Point(93, 481);
            this.tbFajta.Name = "tbFajta";
            this.tbFajta.Size = new System.Drawing.Size(378, 26);
            this.tbFajta.TabIndex = 2;
            // 
            // KutyafajtakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 557);
            this.ControlBox = false;
            this.Controls.Add(this.tbFajta);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.dgvFajta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KutyafajtakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutyafajták";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFajta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFajta;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtanev;
        private System.Windows.Forms.TextBox tbFajta;
    }
}