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
using System.Text.RegularExpressions;

namespace GestAlone
{
    public partial class Main : Form
    {

        string cs = @"server=localhost;userid=root;password=;database=perfectgest";
        MySqlConnection conn = null;
        MySqlDataReader rdr = null;

        #region : déclaraition des variables d'impression
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        #endregion
        public Main()
        {
            InitializeComponent();
        }




        private void gérerLesTypesDeDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionTypeDonation form = new GestionTypeDonation();
            form.TopMost = true;
            form.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aPropos unFrom = new aPropos();
            unFrom.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            tbND.Text = "";
            tbPD.Text = "";
            tbVD.Text = "";
            tbND.Focus();


            // population du cb : 

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                string stm = "SELECT * FROM type_donation where statutTypeDonation = 1 order by numTypeDonation";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();
                List<typeDonation> list = new List<typeDonation>();

                while (rdr.Read())
                {
                    list.Add(new typeDonation() { numTypeDonation = rdr.GetInt32(0), libTypeDonation = rdr.GetString(1) });
                }
                cbTD.DataSource = list;
                cbTD.ValueMember = "numTypeDonation";
                cbTD.DisplayMember = "libTypeDonation";
            }
            catch (MySqlException ex)
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

            // population du datagridView : 
            dgvD.Rows.Clear();
            // requete de selection de toutes les AA :
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                string stm = "SELECT donation.numDonation as a, type_donation.numTypeDonation as b, donation.dateDonation as c, donation.nomDonateur as d, donation.prenomDonateur as e, type_donation.libTypeDonation as f, donation.qtteDonation as g from donation inner join type_donation on donation.numTypeDon = type_donation.numTypeDonation where donation.statutDonation = 1 ORDER by donation.dateDonation desc ";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                // population of the dgv:
                while (rdr.Read())
                {
                    string a = rdr.GetInt32(0).ToString();
                    string b = rdr.GetInt32(1).ToString();
                    string z = rdr.GetDateTime(2).ToString();
                    string c = rdr.GetString(3);
                    string d = rdr.GetString(4);
                    string g = rdr.GetString(5);
                    string f = rdr.GetInt32(6).ToString();


                    dgvD.Rows.Add(
                       new object[] 
                        { 
                            a, b, z, c, d, g, f, "Modifier", "Supprimer"
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

        private void btnResetD_Click(object sender, EventArgs e)
        {
            lblMsgD.Text = "";
            btnSaveD.Text = "Enregistrer";
            tbND.Text = "";
            tbPD.Text = "";
            tbVD.Text = "";
            tbND.Focus();
        }

        private void tbND_Enter(object sender, EventArgs e)
        {
            lblMsgD.Text = "";
        }

        private void tbPD_Enter(object sender, EventArgs e)
        {
            lblMsgD.Text = "";

        }

        private void tbVD_Enter(object sender, EventArgs e)
        {
            lblMsgD.Text = "";

        }

        private void btnSaveD_Click(object sender, EventArgs e)
        {
            // test du regex : 
            bool estReel = Regex.IsMatch(tbVD.Text.Trim(), @"^\s*([0-9])+\s*$");

            if (tbND.Text == "" || tbPD.Text == "" || tbVD.Text == "")
            {
                lblMsgD.Text = " Veillez remplir tous les champs.";
            }
            else if (estReel == false)
            {
                // message dans le label : 
                lblMsgD.Text = " La valeur du don doit être entière";
            }
            else
            {
                if (jeVeuxModifier.numElement == 0)
                {
                    // enregistrement simple : 
                    // enregistrement : 
                    try
                    {
                        // formatage de la date : 
                        DateTime today = DateTime.Now;

                        conn = new MySqlConnection(cs);
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into donation(numGerant, nomDonateur, prenomDonateur, qtteDonation, dateDonation, numTypeDon) values(@a, @b, @c, @d, @e, @f)";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@a", LogInfo.UserID);
                        cmd.Parameters.AddWithValue("@b", tbND.Text.Trim());
                        cmd.Parameters.AddWithValue("@c", tbPD.Text.Trim());
                        cmd.Parameters.AddWithValue("@d", tbVD.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", today);
                        cmd.Parameters.AddWithValue("@f", cbTD.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();

                        tbND.Text = "";
                        tbPD.Text = "";
                        tbVD.Text = "";
                        tbND.Focus();
                        MessageBox.Show("Le don a été bien enrégistré.");
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
                    // modification : 
                    try
                    {

                        conn = new MySqlConnection(cs);
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "update donation set nomDonateur = @a, prenomDonateur =@b, qtteDonation = @c, numTypeDon =@e where numDonation = @d";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@a", tbND.Text.Trim());
                        cmd.Parameters.AddWithValue("@b", tbPD.Text.Trim());
                        cmd.Parameters.AddWithValue("@c", Convert.ToInt32(tbVD.Text.Trim()));
                        cmd.Parameters.AddWithValue("@e", cbTD.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@d", jeVeuxModifier.numElement);
                        cmd.ExecuteNonQuery();


                        btnSaveD.Text = "Ajouter";
                        tbND.Text = "";
                        tbPD.Text = "";
                        tbVD.Text = "";
                        MessageBox.Show(" Le don a été correctement Modifié.");
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
                // reinitialisation de jeVeuxModifier.
                jeVeuxModifier.numElement = 0;

            }







        }

        private void dgvD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                if (e.ColumnIndex == 7)
                {

                    if (MessageBox.Show(" Voulez-vous vraiment Modifier cet élément? ", "Confirmation De Modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // reformatage de nom et prenom : 

                        // initialisation de j :
                        jeVeuxModifier.numElement = Convert.ToInt32(dgvD.Rows[e.RowIndex].Cells["a"].Value.ToString());
                        cbTD.SelectedValue = Convert.ToInt32(dgvD.Rows[e.RowIndex].Cells["b"].Value.ToString());
                        tbND.Text = dgvD.Rows[e.RowIndex].Cells["c"].Value.ToString();
                        tbPD.Text = dgvD.Rows[e.RowIndex].Cells["e"].Value.ToString();
                        tbVD.Text = dgvD.Rows[e.RowIndex].Cells["d"].Value.ToString();
                        btnSaveD.Text = "Modifier";
                    }

                }
                else if (e.ColumnIndex == 8)
                {

                    // recupere l'id :
                    string numAA = dgvD.Rows[e.RowIndex].Cells["a"].Value.ToString();

                    if (MessageBox.Show(" Voulez-vous vraiment supprimer cet élément? ", "Confirmation De Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // on peut supprimer :
                        try
                        {

                            conn = new MySqlConnection(cs);
                            conn.Open();

                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = " update donation set statutDonation = 0 where numDonation = @a";
                            cmd.Prepare();

                            cmd.Parameters.AddWithValue("@a", Convert.ToInt32(numAA));
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

        }

        private void btnSearchD_Click(object sender, EventArgs e)
        {
            #region Recherche

            if (tbSearchD.Text == "")
            {
                dgvD.Rows.Clear();
                // requete de selection de toutes les AA :
                try
                {
                    conn = new MySqlConnection(cs);
                    conn.Open();
                    string stm = "SELECT donation.numDonation as a, type_donation.numTypeDonation as b, donation.dateDonation as c, donation.nomDonateur as d, donation.prenomDonateur as e, type_donation.libTypeDonation as f, donation.qtteDonation as g from donation inner join type_donation on donation.numTypeDon = type_donation.numTypeDonation where donation.statutDonation = 1 ORDER by donation.dateDonation desc ";
                    MySqlCommand cmd = new MySqlCommand(stm, conn);
                    rdr = cmd.ExecuteReader();

                    // population of the dgv:
                    while (rdr.Read())
                    {
                        string a = rdr.GetInt32(0).ToString();
                        string b = rdr.GetInt32(1).ToString();
                        string z = rdr.GetDateTime(2).ToString();
                        string c = rdr.GetString(3);
                        string d = rdr.GetString(4);
                        string g = rdr.GetString(5);
                        string f = rdr.GetInt32(6).ToString();


                        dgvD.Rows.Add(
                           new object[] 
                        { 
                            a, b, z, c, d, g, f, "Modifier", "Supprimer"
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
            else
            {
                // on fait la recherche pour la valeur : 
                dgvD.Rows.Clear();
                // requete de selection de toutes les AA :
                try
                {

                    conn = new MySqlConnection(cs);
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT donation.numDonation as a, type_donation.numTypeDonation as b, donation.dateDonation as c, donation.nomDonateur as d, donation.prenomDonateur as e, type_donation.libTypeDonation as f, donation.qtteDonation as g from donation inner join type_donation on donation.numTypeDon = type_donation.numTypeDonation where donation.statutDonation = 1 and donation.nomDonateur = @a or donation.prenomDonateur = @a or donation.qtteDonation = @a or type_donation.libTypeDonation = @a ORDER by donation.dateDonation desc ";
                    cmd.Parameters.AddWithValue("@a", tbSearchD.Text.Trim());

                    rdr = cmd.ExecuteReader();

                    // population of the dgv:
                    while (rdr.Read())
                    {
                        string a = rdr.GetInt32(0).ToString();
                        string b = rdr.GetInt32(1).ToString();
                        string z = rdr.GetDateTime(2).ToString();
                        string c = rdr.GetString(3);
                        string d = rdr.GetString(4);
                        string g = rdr.GetString(5);
                        string f = rdr.GetInt32(6).ToString();


                        dgvD.Rows.Add(
                           new object[] 
                        { 
                            a, b, z, c, d, g, f, "Modifier", "Supprimer"
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
                
            #endregion Recherche

            }

        private void btnReportD_Click(object sender, EventArgs e)
        {
            // population du datagridview : 
            dgvReportD.Rows.Clear();
            // requete de selection de toutes les AA :
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                string stm = "SELECT donation.nomDonateur as a, donation.prenomDonateur as b, type_donation.libTypeDonation as c, donation.qtteDonation as d, donation.dateDonation as e, donation.numGerant as f from donation inner join type_donation on donation.numTypeDon = type_donation.numTypeDonation where donation.statutDonation = 1 ORDER by donation.dateDonation desc ";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                int i = 1;
                // population of the dgv:
                while (rdr.Read())
                {
                    
                    string f = rdr.GetDateTime(4).ToString();
                    string a = rdr.GetString(0);
                    string b = rdr.GetString(1);
                    string c = rdr.GetString(2);
                    string d = rdr.GetInt32(3).ToString();
                    string g = rdr.GetInt32(5).ToString();


                    dgvReportD.Rows.Add(
                       new object[] 
                        { 
                            i, a+" "+b, c, d, f
                        }

                    );
                    i++;
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








            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pdReportD; // modif
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                // formatage de la date : 
                String tmp = DateTime.Now.ToString();

                pdReportD.DocumentName = "Etat_Dons_"+tmp;// modif
                pdReportD.Print(); // modif
            }

            //Open the print preview dialog
            //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            //objPPdialog.Document = printDocument1;
            //objPPdialog.ShowDialog();

        }

        private void pdReportD_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvReportD.Columns)
                {
                    iTotalWidth += dgvGridCol.Width - 22;// modif
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pdReportD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = 15; // modif
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvReportD.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgvReportD.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvReportD.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 10;// modif 10
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Etat Des Dons", new Font(dgvReportD.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Etat Des Dons ", new Font(dgvReportD.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dgvReportD.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvReportD.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Etat Des Dons", new Font(new Font(dgvReportD.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvReportD.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

