using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace TestEmulator
{
    public partial class frmCreateNewOrg : Form
    {

        //Variable utiliser pour la ConnectionString (le Data Source doit pointer vers le serveur et le Catalog vers la DB)

        private static string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ACPTEST;Integrated Security=True;Pooling=False";

        SqlConnection con = new SqlConnection(conString);

        public frmCreateNewOrg()
        {
            InitializeComponent();
        }

        private void btnCreateNewOrg_Click(object sender, EventArgs e)
        {   

            //TO DO : s'assurer que les champs soient remplis et respectent les normes (sauf pour les accents qui seront modifiés plus tard.)

            //Envoie le contenue des txtBox dans la table Organisation

            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Organisation
            (IdOrgNumber, OrgName, OrgShortName, OrgAccNumber, OrgBranchNumber, OrgInstNumber,
            CreateFileNumber, DataCenterNumber, DoDebit, DoCredit)


        VALUES('" + txtBoxOrgNumber.Text + "','" + txtBoxOrgName.Text + "','" + txtBoxShortName.Text + "','" + txtBoxOrgAccNumber.Text + "','" + txtBoxOrgBranchNumber.Text + "','" + txtBoxOrgInstNumber.Text + "','" + txtBoxDataCenterNumber.Text + "','" + txtBoxCreateFileNumber.Text + "','" + chkBoxDebit.Checked + "','" + chkBoxCredit.Checked + "')", con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Nouvel organisme portant le numéro : " + txtBoxOrgNumber.Text + " à été créé.");
        }

        private void frmCreateNewOrg_Load(object sender, EventArgs e)
        {

        }
      
    }
}
