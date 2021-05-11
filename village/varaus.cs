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
    public partial class varaus : Form
    {
        public varaus(int id, DataTable t, string ta, DateTime alku, DateTime loppu, double lkm)
        {
            //varausformin latauksessa hakee mökkitiedot tietokannasta ja avaa labeleihin
            InitializeComponent();
            //Laskee alvillisen hinnan
            double alvKerroin = t.Rows[0].Field<double>(9) / 100;
            double alviton = t.Rows[0].Field<double>(8);
            double hinta = alviton + (alviton * alvKerroin);
            lblID.Text = id.ToString();
            lblAlku.Text = alku.ToString();
            lblLoppu.Text = loppu.ToString();
            lblHinta.Text = (hinta*lkm).ToString();
            lblToimintaalue.Text = ta;
            lblMokkinimi.Text = t.Rows[0].Field<string>(3);
            lblHenkilomaara.Text = "Henkilömäärä " + t.Rows[0].Field<int>(6).ToString();
            lblKatuosoite.Text = t.Rows[0].Field<string>(4);
            lblPostinro.Text = t.Rows[0].Field<string>(2);
            lblKuvaus.Text = t.Rows[0].Field<string>(5);
            lblVarustelu.Text = t.Rows[0].Field<string>(7);
            //Hakee listboxeihin kyseisen toiminta-alueen palvelut

            lbPalv.DataSource = TaskDB.HaePalvelunNimi(ta);
            lbPalv.ValueMember = "palvelu_id";
            lbPalv.DisplayMember = "nimi";

        }

        private void btnVahvista_Click(object sender, EventArgs e)
        {
            try
            {
                //Jos on valittuna checkbox, niin lisää asiakkaan tietokantaan.
                Asiakas a = new Asiakas();
                
                a.Etunimi = tbEtunimi.Text;
                a.Sukunimi = tbSukunimi.Text;
                a.Lahiosoite = tbOsoite.Text;
                a.Postinro = tbPostinro.Text;
                a.Puhelinnro = tbPuhnro.Text;
                a.Email = tbEmail.Text;
                if (cbTallenna.Checked)
                {
                    TaskDB.LisaaAsiakas(a);
                }
                if (tbID.Text.Length > 0)
                {
                    a.Asiakas_id = int.Parse(tbID.Text);
                }
                else
                {
                    DataTable tt = TaskDB.HaeAsID();
                    a.Asiakas_id = int.Parse(tt.Rows[0].ItemArray[0].ToString());
                }

                //Poimii varauksen tallettamista varten tietoja 
                varausL v = new varausL();
                v.asiakas = a;
                v.Mokki_mokki_id = int.Parse(lblID.Text);
                v.Varattu_alkupvm = DateTime.Parse(lblAlku.Text);
                v.Varattu_loppupvm = DateTime.Parse(lblLoppu.Text);
                v.Varattu = DateTime.Today;
                v.Vahvistus_pvm = DateTime.Parse(lblAlku.Text).AddDays(-6);
                v.Lukumaara = 1;
                
                
                
                TaskDB.LisaaVaraus(v);
                DataTable dt = TaskDB.HaeVaID();
                v.Varaus_id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                double summa = 0;
                Palvelu p = new Palvelu();
                p.Palvelu_id = int.Parse(lbPalv.SelectedValue.ToString());
                TaskDB.LisaaVarauksenPalvelu(v, p);
                DataTable g = TaskDB.HaeHinta(p);
                p.Hinta = double.Parse(dt.Rows[0].ItemArray[0].ToString());

                //Laskutietojen tallennus
                Lasku l = new Lasku();
                l.varaus = v;
                l.summa = summa + double.Parse(lblHinta.Text);
                l.alv = 10;
                TaskDB.LisaaLasku(l);


                varausHallinta uusi = new varausHallinta();
                uusi.Show();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnHaeAsiakas_Click(object sender, EventArgs e)
        {
            try
            {
                //Hakee asiakkaan sähköpostiosoitteen perusteella ja syöttää tiedot textboxeihin valmiiksi
                Asiakas a = new Asiakas();
                a.Email = tbEmail.Text;
                DataTable t = TaskDB.HaeAsiakas(a);

                a.Etunimi = t.Rows[0].Field<string>(2);
                a.Sukunimi = t.Rows[0].Field<string>(3);
                a.Lahiosoite = t.Rows[0].Field<string>(4);
                a.Puhelinnro = t.Rows[0].Field<string>(6);
                a.Postinro = t.Rows[0].Field<string>(1);
                a.Asiakas_id = int.Parse(t.Rows[0].ItemArray[0].ToString());

                tbEtunimi.Text = a.Etunimi;
                tbSukunimi.Text = a.Sukunimi;
                tbOsoite.Text = a.Lahiosoite;
                tbPostinro.Text = a.Postinro;
                tbPuhnro.Text = a.Puhelinnro;
                tbID.Text = a.Asiakas_id.ToString();
            }
             catch
            {
                
                
                throw;
                
            }
        }

        private void btnLisapalvelut_Click(object sender, EventArgs e)
        {

        }

        private void btnValitsePalvelu_Click(object sender, EventArgs e)
        {
            //Siirtää valitut palvelut listalta toiselle
            
        }

        private void btnPoistaValittuPalvelu_Click(object sender, EventArgs e)
        {
            //poistaa palvelun listalta
        }
    }
}
