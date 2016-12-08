using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmulator
{
    public partial class MenuSelectionOrganisme : Form
    {

        private static string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ACPTEST;Integrated Security=True;Pooling=False";

        SqlConnection con = new SqlConnection(conString);

        public MenuSelectionOrganisme()
        {
            InitializeComponent();
        }

        private void MenuSelectionOrganisme_Load(object sender, EventArgs e)
        {

            
            display();
            
        }

        


        private void btnMenuNouvelOrganisme_Click(object sender, EventArgs e)
        {
            
            frmCreateNewOrg myForm = new frmCreateNewOrg();
            myForm.ShowDialog();


        }
        private void MenuSelectionOrganisme_Display(object sender, EventArgs e)
        {
            display();
        }


        void display()   //Affiche des données de l'organisme, relier au l'ordre des colonnes dans la DB donc faire attention s'il y a eu des mofications à ce niveau
            //Do To : tester l'ajout d'un datasource vers la DB directement sur le tableau d'affiche de la fenêtre.
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Organisation", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[8];
                dataGridView1.Rows[n].Cells[3].Value = item[9];
                

            }

        }
    }
}
