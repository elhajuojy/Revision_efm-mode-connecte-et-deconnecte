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
using CrystalDecisions.Windows.Forms;

namespace Revision_efm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection ctn;
        SqlCommand cmd;
        SqlCommand cmd1;
        DataTable table;
        DataTable table1;
        BindingSource bs = new BindingSource();
        SqlDataAdapter dr;
        SqlCommandBuilder bldr;
        DataSet ds;
        DataTable tb ;

        //private void recherche(string code)
        //{
        //    cmd = new SqlCommand("select * from medecin  where codemedcin="+code,ctn);
        //    ctn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
            
        //    table.Load(dr);
        //    int pos = -1;
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        if (table.Rows[i][0].ToString() == textCode.Text)
        //        {
        //            pos = i;
        //            break;
        //        }
        //    }
        //    return pos;



        //}

        //private void afficher(int pos)
        //{


        //    textCode.Text = table.Rows[pos][0].ToString();
        //    textNom.Text = table.Rows[pos][1].ToString();
        //    textTele.Text = table.Rows[pos][2].ToString();
        //    dateEmb.Value =DateTime.Parse( table.Rows[pos][3].ToString());
        //    cbSepecilite.Text = table.Rows[pos][4].ToString();
        //    dataGridView1.DataSource = table;
            
           
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            ctn = new SqlConnection(@"Data Source=elhajuojy-lapto\mehdi;Initial Catalog=Gest_RDV;Integrated Security=True");
            cmd = new SqlCommand("select * from medecin", ctn);
            cmd1 = new SqlCommand("select distinct(specialitemedecin) from medecin", ctn);
            dr = new SqlDataAdapter(cmd);
            tb = new DataTable();
            dr.Fill(tb);









            //ctn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //table = new DataTable();
            //table.Load(dr);
            //ctn.Close();
            //ctn.Open();
            //SqlDataReader dr1 = cmd1.ExecuteReader();
            //table1 = new DataTable();
            //table1.Load(dr1);
            //ctn.Close();

            bs.DataSource =tb ;

            //textCode.DataBindings.Add("Text", bs, "codemedcin");
            //textNom.DataBindings.Add("Text", bs, "nommedecin");
            //textTele.DataBindings.Add("Text", bs, "telmedecin");
            //dateEmb.DataBindings.Add("Value", bs, "dateEmbauche");
            //cbSepecilite.DataBindings.Add("Text", bs, "specialitemedecin");
            

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.DataSource = bs;
           // cbSepecilite.DataSource = bs;
           // cbSepecilite.DisplayMember = "specialitemedecin";
            


        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textCode.Text = "";
            textNom.Text = "";
            textTele.Text = "";
            dateEmb.Value = DateTime.Now;
          
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            DataRow ligne = tb.NewRow();
            ligne[0] = textCode.Text;
            ligne[1] = textNom.Text;
            ligne[2] = textTele.Text;
            ligne[3] = dateEmb.Value;
            ligne[4] = cbSepecilite.Text;
            tb.Rows.Add(ligne);
            dataGridView1.DataSource = ds;




            //mode connecte
            //cmd = new SqlCommand("insert into medecin values('"+textCode.Text+ "','"+textNom.Text+ "','" + textTele.Text + "','" + dateEmb.Value + "','" + cbSepecilite.Text+ "');", ctn);
            //ctn.Open();
            //cmd.ExecuteNonQuery();
            //ctn.Close();
            //MessageBox.Show("bien Ajouter");
            //Form1_Load(sender, e);



        }

        private void btnRchercher_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i][0].ToString() == textCode.Text)
                {
                    textCode.Text = tb.Rows[i][0].ToString();
                    textNom.Text = tb.Rows[i][1].ToString();
                    textTele.Text = tb.Rows[i][2].ToString();
                    dateEmb.Value =DateTime.Parse(tb.Rows[i][3].ToString());
                    break;
                }
            }








            //cmd = new SqlCommand("select * from medecin  where codemedcin=" +textCode.Text, ctn);
            //ctn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    textCode.Text = dr[0].ToString();
            //    textNom.Text = dr[1].ToString();
            //    textTele.Text = dr[2].ToString();
            //    dateEmb.Value = DateTime.Parse(dr[3].ToString());
            //    cbSepecilite.Text = dr[4].ToString();
            //}
            //ctn.Close();
           


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            try
            {
                tb.DefaultView.Sort = "codemedcin ASC";

                int index = tb.DefaultView.Find(textCode.Text);

                tb.Rows[index].Delete();
                //dt.AcceptChanges();

                MessageBox.Show("bien Supprimer");

                dataGridView1.DataSource = tb;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            };



            //cmd = new SqlCommand("delete from medecin  where codemedcin ='" + textCode.Text + "' ", ctn);
            //ctn.Open();
            //cmd.ExecuteNonQuery();
            //ctn.Close();

            //Form1_Load(sender, e);


        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i][0].ToString() == textCode.Text)
                {
                    tb.Rows[i][1] = textNom.Text;
                    tb.Rows[i][2] = textTele.Text;
                    tb.Rows[i][3] = dateEmb.Value;
                    tb.Rows[i][4] = cbSepecilite.Text;
                    break;
                }
            }

            dataGridView1.DataSource = tb;




            //cmd = new SqlCommand("update medecin set nommedecin='"+textNom.Text+"' ,telmedecin='"+textTele.Text+"',dateEmbauche='"+dateEmb.Value+"',specialitemedecin='"+cbSepecilite.Text+"' where codemedcin='"+textCode.Text+"'", ctn);
            //ctn.Open();
            //cmd.ExecuteNonQuery();
            //ctn.Close();
            //Form1_Load(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            //textCode.Text = table.Rows[0][0].ToString();
            //textNom.Text = table.Rows[0][1].ToString();
            //textTele.Text = table.Rows[0][2].ToString();
            //dateEmb.Value = DateTime.Parse(table.Rows[0][3].ToString());
            //cbSepecilite.Text = table.Rows[0][4].ToString();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            //textCode.Text = table.Rows[table.Rows.Count-1][0].ToString();
            //textNom.Text = table.Rows[table.Rows.Count-1][1].ToString();
            //textTele.Text = table.Rows[table.Rows.Count-1][2].ToString();
            //dateEmb.Value = DateTime.Parse(table.Rows[table.Rows.Count-1][3].ToString());
            //cbSepecilite.Text = table.Rows[table.Rows.Count-1][4].ToString();
            
        }

        private void btnPerviows_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bldr = new SqlCommandBuilder(dr);
            dr.Update(tb);
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(tb);
            (f2.Controls["crystalReportViewer1"] as CrystalReportViewer).ReportSource = report;
            f2.Show();

        }
    }
}
