using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Allatkorhaz
{
    public partial class KutyafajtakForm : Form
    {
        DB adatbazis;
        int aktID;
        bool modositas = false;
        public KutyafajtakForm(DB adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            AdatokNezetbe();
        }

        private void AdatokNezetbe()
        {
            try
            {
                adatbazis.Conn.Open();
                string sql = "SELECT * FROM fajta ORDER BY fajtanev";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, adatbazis.Conn);
                DataTable fajtakTable = new DataTable();
                da.Fill(fajtakTable);
                dgvFajta.DataSource = fajtakTable;
                ElsoSorBeallitasa();
                adatbazis.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ElsoSorBeallitasa()
        {
            dgvFajta.Rows[0].Selected = true;
            FajtaTextFeltoltes(0);
        }

        private void FajtaTextFeltoltes(int i)
        {
            tbFajta.Text = dgvFajta.Rows[i].Cells[1].Value.ToString();
        }

        private void dgvFajta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int aktualisSor = dgvFajta.CurrentCell.RowIndex;
            aktID = Convert.ToInt32(dgvFajta.Rows[aktualisSor].Cells[0].Value);
            FajtaTextFeltoltes(aktualisSor);
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            VezerlokBeallitasa();
            modositas = true;
            tbFajta.Focus();
        }

        private void VezerlokBeallitasa()
        {
            btnKilepes.Enabled = !btnKilepes.Enabled;
            btnMegsem.Enabled = !btnMegsem.Enabled;
            btnMentes.Enabled = !btnMentes.Enabled;
            btnModosit.Enabled = !btnModosit.Enabled;
            btnTorles.Enabled = !btnTorles.Enabled;
            btnUj.Enabled = !btnUj.Enabled;
            tbFajta.Enabled = !tbFajta.Enabled;
            dgvFajta.Enabled = !dgvFajta.Enabled;
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            VezerlokBeallitasa();
            ElsoSorBeallitasa();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (modositas)
            {
                if (VanFajtaEllenorzes(tbFajta.Text))
                {
                    MessageBox.Show("Már van ilyen!");
                }
                else
                {
                    string sql = $"UPDATE fajta SET fajtanev = '{tbFajta.Text}' WHERE id = '{aktID}'";
                    string uzenet = "Sikeres módosítás!";
                    SqlParancsVegrehajtas(sql, uzenet);
                }

            }
            else
            {
                if (VanFajtaEllenorzes(tbFajta.Text))
                {
                    MessageBox.Show("Már van ilyen!");
                }
                else
                {
                    string sql = $"INSERT INTO fajta(fajtanev) VALUES ('{tbFajta.Text}')";
                    string uzenet = "Sikeres felvétel!";
                    SqlParancsVegrehajtas(sql, uzenet);
                }
            }
            VezerlokBeallitasa();
        }

        private void SqlParancsVegrehajtas(string sql, string uzenet)
        {
            adatbazis.Conn.Open();
            MySqlCommand da = new MySqlCommand(sql, adatbazis.Conn);
            MySqlDataReader reader = da.ExecuteReader();
            adatbazis.Conn.Close();
            MessageBox.Show(uzenet, "Sql parancs végrehajtás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AdatokNezetbe();
        }

        private bool VanFajtaEllenorzes(string fajta)
        {
            adatbazis.Conn.Open();
            string sql = $"SELECT * from fajta where id != '{aktID}' and fajtanev = '{fajta}'";
            MySqlCommand parancs = new MySqlCommand(sql, adatbazis.Conn);
            MySqlDataReader sorok = parancs.ExecuteReader();

            bool van = sorok.HasRows;

            adatbazis.Conn.Close();
            return van;
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            VezerlokBeallitasa();
            modositas = false;
            tbFajta.Focus();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM fajta WHERE id = '{aktID}'";
            string uzenet = "Sikeres törlés!";
            SqlParancsVegrehajtas(sql, uzenet);
        }
    }
}
