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
    public partial class avaaLasku : Form
    {
        public avaaLasku(int varausid, int lasku_id)
        {
            InitializeComponent();
            dgvVaraus.DataSource = TaskDB.HaeVaraus(varausid);
            dgvMokki.DataSource = TaskDB.HaeMokki(varausid);
            dgvAsiakas.DataSource = TaskDB.HaeAs(varausid);
            dgvPalv.DataSource = TaskDB.HaeVarauksenPalvelut(varausid);
            DataTable t = TaskDB.HaeSumma(lasku_id);
            lbSumma.Text = t.Rows[0].ItemArray[0].ToString();
            double summa = 0;
            double kerroin = 0.1;
            Palvelu p = new Palvelu();
            
            foreach (DataGridViewRow rivi in dgvPalv.Rows)
            {
                if (rivi.Index < dgvPalv.RowCount -1)
                {
                    string str = dgvPalv.Rows[rivi.Index].Cells[3].Value.ToString();
                    summa += Convert.ToDouble(str);
                }

            }
            lbPHinta.Text = (summa + (summa * kerroin)).ToString();
            double kokonaissumma = double.Parse(lbSumma.Text) + double.Parse(lbPHinta.Text);
            lbYht.Text = kokonaissumma.ToString();
        }

        private void btnTulosta_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Lasku.pdf";
            bool fileError = false;
            iTextSharp.text.Font f = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
            Document pdfD = new Document(PageSize.A4);
            pdfD.SetMargins(70, 70, 110, 110);
            Paragraph prg = new Paragraph("Lasku, Newbie Village" + Chunk.NEWLINE + Chunk.NEWLINE, f);

            for (int i = 0; i < dgvAsiakas.Columns.Count; i++)
            {
                string str = dgvAsiakas.Rows[0].Cells[i].Value.ToString();
                prg.Add(str + Chunk.NEWLINE);
            }

            prg.Add(Chunk.NEWLINE);
            prg.Add(Chunk.NEWLINE);
            prg.Add("Mökki");
            prg.Add(Chunk.NEWLINE);
            prg.Add(Chunk.NEWLINE);

            
            Paragraph prg2 = new Paragraph(Chunk.NEWLINE + "Varauksen tiedot" + Chunk.NEWLINE + Chunk.NEWLINE, f);

            Paragraph prg3 = new Paragraph(Chunk.NEWLINE + "Ostetut palvelut: " + Chunk.NEWLINE, f);
            prg3.Add(Chunk.NEWLINE);
            
            

            Paragraph prg4 = new Paragraph(Chunk.NEWLINE + "Laskun summa (sis. alv 10%) " + (double.Parse(lbSumma.Text) + double.Parse(lbPHinta.Text)) + " €", f);
            


            if (dgvMokki.Rows.Count >0)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {   //Tarkistaa, onko saman niminen tiedosto
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {   //Jos on, yrittää poistaa vanhan
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Laskun kirjoittaminen ei onnistunut!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        
                        try
                        {
                            //Lukee Mökki-dgv:n
                            PdfPTable pdf = new PdfPTable(dgvMokki.Columns.Count);
                            pdf.DefaultCell.Padding = 3;
                            pdf.WidthPercentage = 100;
                            pdf.HorizontalAlignment = Element.ALIGN_LEFT;

                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

                            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvMokki.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text));
                                pdf.AddCell(cell);
                            }
                            string pdfcell;
                            foreach (DataGridViewRow row in dgvMokki.Rows)
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
                            //Lukee varauksen
                            BaseFont bf2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                            PdfPTable pdf2 = new PdfPTable(dgvVaraus.Columns.Count);
                            pdf2.DefaultCell.Padding = 3;
                            pdf2.WidthPercentage = 100;
                            pdf2.HorizontalAlignment = Element.ALIGN_LEFT;
                            iTextSharp.text.Font text2 = new iTextSharp.text.Font(bf2, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvVaraus.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text2));
                                pdf2.AddCell(cell);
                            }
                            string pdfcell2;
                            foreach (DataGridViewRow row in dgvVaraus.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfcell2 = null;
                                    }
                                    else
                                    {
                                        pdfcell2 = cell.Value.ToString();
                                        pdf2.AddCell(new Phrase(pdfcell2, text2));
                                    }
                                }
                            }

                            BaseFont bf3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                            PdfPTable pdf3 = new PdfPTable(dgvPalv.Columns.Count);
                            pdf3.DefaultCell.Padding = 3;
                            pdf3.WidthPercentage = 100;
                            pdf3.HorizontalAlignment = Element.ALIGN_LEFT;

                            if (dgvPalv.Rows.Count >0)
                            {
                                //Lukee palvelutiedot
                                iTextSharp.text.Font text3 = new iTextSharp.text.Font(bf3, 10, iTextSharp.text.Font.NORMAL);
                                foreach (DataGridViewColumn column in dgvPalv.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text3));
                                    pdf3.AddCell(cell);
                                }
                                string pdfcell3;
                                foreach (DataGridViewRow row in dgvPalv.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        if (cell.Value == null)
                                        {
                                            pdfcell3 = null;
                                        }
                                        else
                                        {
                                            pdfcell3 = cell.Value.ToString();
                                            pdf3.AddCell(new Phrase(pdfcell3, text3));
                                        }
                                    }
                                }
                            }
                               

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                //Tekee pdf:n
                                PdfWriter.GetInstance(pdfD, stream);
                                pdfD.Open();
                                pdfD.Add(prg);
                                pdfD.Add(pdf);
                                pdfD.Add(prg2);
                                pdfD.Add(pdf2);
                                pdfD.Add(prg3);
                                pdfD.Add(pdf3);
                                pdfD.Add(prg4);
                                pdfD.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Laskun tekeminen onnistui!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error! Laskun kirjoittaminen ei onnistunut" + ex.Message);
                        }
                    }
                }
            }

            this.Close();
        }

        private void dgvPalv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dgvVaraus.SelectedCells[0].RowIndex;
            int varausid = int.Parse(dgvVaraus.Rows[row].Cells[0].Value.ToString());
            varausL v = new varausL();
            v.Varaus_id = varausid;
            
            VarausMuokkaus l = new VarausMuokkaus(v);
            l.Show();
            
            dgvPalv.DataSource = TaskDB.HaeVarauksenPalvelut(varausid);
            
        }

      

        private void btnSulje_Click(object sender, EventArgs e)
        {
            varausHallinta uusi = new varausHallinta();
            uusi.Show();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int row = dgvPalv.SelectedCells[0].RowIndex;
            int id = int.Parse(dgvPalv.Rows[row].Cells[0].Value.ToString());
            int rivi = dgvVaraus.SelectedCells[0].RowIndex;
            int varausid = int.Parse(dgvVaraus.Rows[rivi].Cells[0].Value.ToString());
            TaskDB.PoistaVarauksenPalvelu(id,varausid);
            
            dgvPalv.DataSource = TaskDB.HaeVarauksenPalvelut(varausid);
            double summa = 0;
            double kerroin = 0.1;
            Palvelu p = new Palvelu();

            foreach (DataGridViewRow rivi2 in dgvPalv.Rows)
            {
                if (rivi2.Index < dgvPalv.RowCount - 1)
                {
                    string str = dgvPalv.Rows[rivi2.Index].Cells[3].Value.ToString();
                    summa += Convert.ToDouble(str);
                }

            }
            lbPHinta.Text = (summa + (summa * kerroin)).ToString();
            double kokonaissumma = double.Parse(lbSumma.Text) + double.Parse(lbPHinta.Text);
            lbYht.Text = kokonaissumma.ToString();
        }

        private void avaaLasku_MouseClick(object sender, MouseEventArgs e)
        {
            int rivi = dgvVaraus.SelectedCells[0].RowIndex;
            int varausid = int.Parse(dgvVaraus.Rows[rivi].Cells[0].Value.ToString());

            dgvPalv.DataSource = TaskDB.HaeVarauksenPalvelut(varausid);
            double summa = 0;
            double kerroin = 0.1;
            Palvelu p = new Palvelu();

            foreach (DataGridViewRow rivi3 in dgvPalv.Rows)
            {
                if (rivi3.Index < dgvPalv.RowCount - 1)
                {
                    string str = dgvPalv.Rows[rivi3.Index].Cells[3].Value.ToString();
                    summa += Convert.ToDouble(str);
                }

            }
            lbPHinta.Text = (summa + (summa * kerroin)).ToString();
            double kokonaissumma = double.Parse(lbSumma.Text) + double.Parse(lbPHinta.Text);
            lbYht.Text = kokonaissumma.ToString();
        }

        
    }
}
