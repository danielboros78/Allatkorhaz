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
    public partial class Bejelentkezes : Form
    {
        DB adatbazis;
        User user;
        public Bejelentkezes()
        {
            InitializeComponent();
            adatbazis = new DB();
            tbUser.Focus();
        }

        private void Bejelentkezes_Shown(object sender, EventArgs e)
        {

        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBelepes_Click(object sender, EventArgs e)
        {
            string nev = tbUser.Text;
            string pwd = tbPwd.Text;
            try
            {
                if (UresMezoVan(nev, pwd))
                {
                    throw new Exception("Üres adat nem lehet!");
                }
                else
                {
                    adatbazis.Conn.Open();
                    string sql = $"SELECT * FROM dolgozok WHERE dolgozok.nev = '{nev}' AND dolgozok.jelszo = '{pwd}';";
                    var parancs = new MySqlCommand(sql, adatbazis.Conn);
                    var olvaso = parancs.ExecuteReader();
                    
                    if (olvaso.HasRows)
                    {
                        olvaso.Read();
                        int id = olvaso.GetInt32(0);
                        string uNev = olvaso.GetString(1);
                        string jelszo = olvaso.GetString(2);
                        int jog = olvaso.GetInt32(3);
                        string teljesNev = olvaso.GetString(4);

                        user = new User(id, uNev, jelszo, teljesNev, jog);
                        
                        adatbazis.Conn.Close();

                        Hide();
                        Fo frmFo = new Fo(adatbazis,user);
                        frmFo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nem jók a belépési adatok.");
                        adatbazis.Conn.Close();
                    }
                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUser.SelectAll();
                tbUser.Focus();
            }
        }

        private static bool UresMezoVan(string nev, string pwd)
        {
            return nev == "" || pwd == "";
        }
    }
}
