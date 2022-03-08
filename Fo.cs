using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allatkorhaz
{
    public partial class Fo : Form
    {
        DB adatbazis;
        User user;
        string jog;
        public Fo(DB adatbazis, User user)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            this.user = user;
        }

        private void SzerepkortBeallitas()
        {
            if (jog == "user")
            {
                btnGazdak.Enabled = false;
                btnKezelesfajtak.Enabled = false;
                btnKutyafajtak.Enabled = false;
                btnKutyak.Enabled = false;
            }
        }

        private void Fo_Shown(object sender, EventArgs e)
        {
            jog = user.Jog.Equals(1) ? "admin" : "user";
            if (user.Jog.Equals(1))
            {
                this.Text = $"Főmenü: {user.TeljesNev} {jog}";
            }
            else
            {
                this.Text = $"Főmenü: {user.TeljesNev} {jog}";
            }
            SzerepkortBeallitas();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKutyafajtak_Click(object sender, EventArgs e)
        {
            KutyafajtakForm frmKutyafajtak = new KutyafajtakForm(adatbazis);
            frmKutyafajtak.ShowDialog();
        }
    }
}
