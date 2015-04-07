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


namespace GestionAD
{
    public partial class fm_listUsers : Form
    {
        public fm_listUsers()
        {
            InitializeComponent();
            try
            {

                DirectoryEntry Ldap = new DirectoryEntry("LDAP://DC1.epsib2.com", "root", "esxib2projet!");
                lb_domain.Text = "Connexion réussie";
            }

            catch (Exception Ex)
            {

                lb_domain.Text = Ex.Message;

            }
        }

        private void fm_listUsers_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
