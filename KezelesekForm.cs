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
    public partial class KezelesekForm : Form
    {
        DB adatbazis;
        public KezelesekForm(DB adatbazis)
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
                string sql = "SELECT * FROM kezelestipus ORDER BY jelleg";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, adatbazis.Conn);
                DataTable KfajtakTable = new DataTable();
                da.Fill(KfajtakTable);
                dgvKutyak.DataSource = KfajtakTable;
                adatbazis.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
