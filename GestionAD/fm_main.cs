using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace GestionAD
{
    public partial class fm_main : Form
    {
        public fm_main()
        {
            InitializeComponent();

            try
            {

                DirectoryEntry Ldap = new DirectoryEntry("LDAP://DC1.epsib2.com", "root", "esxib2projet!");
            }

            catch (Exception Ex)
            {

                lb_connexion.Text = Ex.Message;

            }
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fm_main_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_listUsers listu = new fm_listUsers();
            listu.ShowDialog();
        }
    }
}
