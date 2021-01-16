using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestAlone
{
    public partial class GestionTypeDonation : Form
    {
        #region ##
        string cs = @"server=localhost;userid=root;password=;database=perfectgest";
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;
        #endregion  ##
        public GestionTypeDonation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetTD_Click(object sender, EventArgs e)
        {
            btnSaveTD.Text = "Enregistrer";
            lblMsgATD.Text = "";
            tbATD.Text = "";
            tbATD.Focus();
        }

        private void tbATD_Enter(object sender, EventArgs e)
        {
            tbATD.Text = "";
            lblMsgATD.Text = "";
        }

        private void GestionTypeDonation_Load(object sender, EventArgs e)
        {
            lblMsgATD.Text = "";
            tbATD.Focus();
        }

        private void btnSaveTD_Click(object sender, EventArgs e)
        {
            if (tbATD.Text == "")
            {
                lblMsgATD.Text = "Saisissez Un Type De Donation";
            }
            else
            {
                lblMsgATD.Text = "";
                // enrégistrement ou suppression : 

                // enrégistrement : 
                if (jeVeuxModifier.numElement == 0)
                {
                    // enregistrement : 
                    try
                    {
                        conn = new MySqlConnection(cs);
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into type_donation(numGerant, libTypeDonation) values(@a, @b)";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@a", LogInfo.UserID);
                        cmd.Parameters.AddWithValue("@b", tbATD.Text.Trim());
                        cmd.ExecuteNonQuery();

                        tbATD.Text = "";
                        tbATD.Focus();
                        MessageBox.Show("L'élément a été bien enrégistré.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    // modification et changement de l'atat du bouton ajouter : 
                    try
                    {

                        conn = new MySqlConnection(cs);
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "update type_donation set libTypeDonation = @a  where numTypeDonation = @b";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@a",tbATD.Text.Trim());
                        cmd.Parameters.AddWithValue("@b", jeVeuxModifier.numElement);
                        cmd.ExecuteNonQuery();

                        jeVeuxModifier.numElement = 0;
                        tbATD.Text = "";
                        btnSaveTD.Text = "Enregistrer";
                        MessageBox.Show(" L'élément a été correctement Modifié.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                        if (conn != null)
                        {
                            conn.Close();
                        }

                    }

                }
                jeVeuxModifier.numElement = 0;
            }
        }

        private void GestionTypeDonation_Activated(object sender, EventArgs e)
        {
            // population du dgv type donation : 
            dgvTypeDonation.Rows.Clear();

            // selection des éléments dans la base de données : 
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                string stm = "SELECT * FROM type_donation where statutTypeDonation = 1 order by numTypeDonation desc";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();
                // population of the dgv:
                while (rdr.Read())
                {
                    string a = rdr.GetInt32(0).ToString();
                    string b = rdr.GetString(1);
                    dgvTypeDonation.Rows.Add(
                       new object[] 
                        { 
                            a,
                            b,
                            "Modifier",
                            "Supprimer"
                        }

                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        private void dgvTypeDonation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // modification et suppression : 


            #region suppression


            if (e.RowIndex != -1)
            {

                if (e.ColumnIndex == 2)
                {

                    if (MessageBox.Show(" Voulez-vous vraiment Modifier cet élément? ", "Confirmation De Modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // initialisation de j :
                        jeVeuxModifier.numElement = Convert.ToInt32(dgvTypeDonation.Rows[e.RowIndex].Cells["a"].Value.ToString());
                        tbATD.Focus();
                        tbATD.Text = dgvTypeDonation.Rows[e.RowIndex].Cells["b"].Value.ToString();
                        btnSaveTD.Text = "Modifier";

                    }

                }
                else if (e.ColumnIndex == 3)
                {
                    if (btnSaveTD.Text == "Modifier")
                    {
                        btnSaveTD.Text = "Ajouter";
                    }
                    // recupere l'id :
                    string numTD = dgvTypeDonation.Rows[e.RowIndex].Cells["a"].Value.ToString();

                    if (MessageBox.Show(" Voulez-vous vraiment supprimer cet élément? ", "Confirmation De Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // on peut supprimer :
                        try
                        {

                            conn = new MySqlConnection(cs);
                            conn.Open();

                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "update type_donation set statutTypeDonation = 0  where numTypeDonation= @a";
                            cmd.Prepare();

                            cmd.Parameters.AddWithValue("@a", Convert.ToInt32(numTD));
                            cmd.ExecuteNonQuery();

                            MessageBox.Show(" L'élément a été correctement supprimé.");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {

                            if (conn != null)
                            {
                                conn.Close();
                            }

                        }

                    }

                }


            }
            #endregion suppression
        }
    }
}
