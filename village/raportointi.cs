using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace village
{
    public partial class raportointi : Form
    {
        public raportointi()
        {
            InitializeComponent();
            dtpAlku.CustomFormat = " ";
            dtpLoppu.CustomFormat = " ";
            cbToimialueet.DataSource = TaskDB.HaeToimintaalue();
            cbToimialueet.ValueMember = "toimintaalue_id";
            cbToimialueet.DisplayMember = "nimi";
            cbToimialueet.SelectedItem = null;
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            //Ajan arvon muuttuessa formaatti muuttuu tyhjästä tähän
            dtpLoppu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            dtpAlku.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void btnHaeRaportti_Click(object sender, EventArgs e)
        {
            DateTime alku = DateTime.Parse(dtpAlku.Text);
            DateTime loppu = DateTime.Parse(dtpLoppu.Text);
            string toimialue = cbToimialueet.Text;
            DataTable tt = TaskDB.HaeRaportti(toimialue, alku, loppu);
            dgvRaportti.DataSource = tt;
            dgvPalvRapsa.DataSource = TaskDB.HaeVaratutPalv(toimialue,alku,loppu);
            int i = dgvPalvRapsa.Rows.Count - 1;
            lbMaara.Text = "Yhteensä: " + i + " kpl";
            lbMaara.Visible = true;

            double paivat = 0;
            int rivi = 0;

            List<int> list = new List<int>();
            try
            {
                foreach (DataRow row in tt.Rows)
                {
                    //Hakee taulukosta päivämäärät sekä dtp:loppupäivän vertailukohteeksi
                    DateTime alkupv = (DateTime)tt.Rows[rivi].ItemArray[2];
                    DateTime loppupv = tt.Rows[rivi].Field<DateTime>(3);
                    DateTime vertaa = DateTime.Parse(dtpLoppu.Text);
                    int id = int.Parse(tt.Rows[rivi].ItemArray[0].ToString());
                    //Jos listassa ei ole ko mökkiä, lisää sen id:n listaan, jotta myöhemmin voidaan laskea mökkien lukumäärä
                    if (!list.Contains(id))
                    {
                        list.Add(id);
                    }
                    rivi++;
                    //Jos päättymispäivä on suurempi, kuin vertauspäivä, lasketaan varatutpäivät vertauspäivän mukaan eli raportointijakson päättymisen mukaan
                    if (loppupv > vertaa)
                    {
                        paivat += (vertaa - alkupv).TotalDays;
                    }
                    else
                    {
                        //Muussa tapauksessa lasketaan loppupäivän mukaan. Tällä lasketaan varatut vuorokaudet kaikkiaan.
                        paivat += (loppupv - alkupv).TotalDays;
                    }
                }
                lbPaivat.Text = "Varatut päivät yhteensä: " + paivat.ToString("00");
                lbPaivat.Visible = true;
                DateTime raporttiAlku = DateTime.Parse(dtpAlku.Text);
                DateTime raporttiLoppu = DateTime.Parse(dtpLoppu.Text);
                //Lasketaan raportoitavien päivien määrä
                double raportoitavaAika = (raporttiLoppu - raporttiAlku).TotalDays;
                //Katsotaan listasta mökkien lukumäärä
                int kerroin = list.Count;
                //Kaikkiaan varattavissa olevien päivien määrä ajanjaksolla
                double mokkipäivatYht = raportoitavaAika * kerroin;
                //Täyttöaste
                double tayttoaste = (paivat / mokkipäivatYht) * 100;
                lbTaytto.Text = "Täyttöaste: " + tayttoaste.ToString("00") + " %";
                lbTaytto.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tiedoissa! " + ex.Message);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPdf1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd4 = new SaveFileDialog();
            sfd4.Filter = "PDF (*.pdf)|*.pdf";
            sfd4.FileName = "Varausten_Raportti.pdf";
            bool fileError = false;
            iTextSharp.text.Font f = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
            iTextSharp.text.Document pdfD = new iTextSharp.text.Document(PageSize.A4);
            pdfD.SetMargins(70, 70, 110, 110);
            Paragraph prg = new Paragraph("Raportti/Varaukset, Newbie Village" + Chunk.NEWLINE + Chunk.NEWLINE, f);
            if (dgvRaportti.Rows.Count > 0)
            {
                if (sfd4.ShowDialog() == DialogResult.OK)
                {   //Tarkistaa, onko saman niminen tiedosto
                    if (File.Exists(sfd4.FileName))
                    {
                        try
                        {   //Jos on, yrittää poistaa vanhan
                            File.Delete(sfd4.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Raportin kirjoittaminen ei onnistunut!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {

                        try
                        {
                            //Lukee raportti-dgv:n
                            PdfPTable pdf = new PdfPTable(dgvRaportti.Columns.Count);
                            pdf.DefaultCell.Padding = 3;
                            pdf.WidthPercentage = 100;
                            pdf.HorizontalAlignment = Element.ALIGN_LEFT;

                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

                            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvRaportti.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text));
                                pdf.AddCell(cell);
                            }
                            string pdfcell;
                            foreach (DataGridViewRow row in dgvRaportti.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfcell = null;
                                    }
                                    else
                                    {
                                        pdfcell = cell.Value.ToString();
                                        pdf.AddCell(new Phrase(pdfcell, text));
                                    }
                                }
                            }
                            using (FileStream stream = new FileStream(sfd4.FileName, FileMode.Create))
                            {
                                //Tekee pdf:n
                                PdfWriter.GetInstance(pdfD, stream);
                                pdfD.Open();
                                pdfD.Add(prg);
                                pdfD.Add(pdf);

                                pdfD.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Raportin tekeminen onnistui!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error! Raportin kirjoittaminen ei onnistunut" + ex.Message);
                        }
                       
                    }
                }
            }

        }

        private void btnpdf2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd5 = new SaveFileDialog();
            sfd5.Filter = "PDF (*.pdf)|*.pdf";
            sfd5.FileName = "Palveluiden_Raportti.pdf";
            bool fileError = false;
            iTextSharp.text.Font f = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
            iTextSharp.text.Document pdfD = new iTextSharp.text.Document(PageSize.A4);
            pdfD.SetMargins(70, 70, 110, 110);
            Paragraph prg = new Paragraph("Raportti/Palvelut, Newbie Village" + Chunk.NEWLINE + Chunk.NEWLINE, f);
            if (dgvPalvRapsa.Rows.Count > 0)
            {
                if (sfd5.ShowDialog() == DialogResult.OK)
                {   //Tarkistaa, onko saman niminen tiedosto
                    if (File.Exists(sfd5.FileName))
                    {
                        try
                        {   //Jos on, yrittää poistaa vanhan
                            File.Delete(sfd5.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Raportin kirjoittaminen ei onnistunut!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {

                        try
                        {
                            //Lukee raportti-dgv:n
                            PdfPTable pdf = new PdfPTable(dgvPalvRapsa.Columns.Count);
                            pdf.DefaultCell.Padding = 3;
                            pdf.WidthPercentage = 100;
                            pdf.HorizontalAlignment = Element.ALIGN_LEFT;

                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

                            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvPalvRapsa.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text));
                                pdf.AddCell(cell);
                            }
                            string pdfcell;
                            foreach (DataGridViewRow row in dgvPalvRapsa.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfcell = null;
                                    }
                                    else
                                    {
                                        pdfcell = cell.Value.ToString();
                                        pdf.AddCell(new Phrase(pdfcell, text));
                                    }
                                }
                            }
                            using (FileStream stream = new FileStream(sfd5.FileName, FileMode.Create))
                            {
                                //Tekee pdf:n
                                PdfWriter.GetInstance(pdfD, stream);
                                pdfD.Open();
                                pdfD.Add(prg);
                                pdfD.Add(pdf);

                                pdfD.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Raportin tekeminen onnistui!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error! Raportin kirjoittaminen ei onnistunut" + ex.Message);
                        }

                    }
                }
            }
        }
    }
    
}

