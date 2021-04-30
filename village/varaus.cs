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
        public varaus(int id, DataTable t, string ta, DateTime alku, DateTime loppu)
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
            lblHinta.Text = hinta.ToString();
            lblToimintaalue.Text = ta;
            lblMokkinimi.Text = t.Rows[0].Field<string>(3);
            lblHenkilomaara.Text = "Henkilömäärä " + t.Rows[0].Field<int>(6).ToString();
            lblKatuosoite.Text = t.Rows[0].Field<string>(4);
            lblPostinro.Text = t.Rows[0].Field<string>(2);
            lblKuvaus.Text = t.Rows[0].Field<string>(5);
            lblVarustelu.Text = t.Rows[0].Field<string>(7);

            listBox1.DataSource = TaskDB.HaePalvelunNimi(ta);
            listBox1.ValueMember = "palvelu_id";
            listBox1.DisplayMember = "nimi";
            
        }

        private void btnVahvista_Click(object sender, EventArgs e)
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

            varausL v = new varausL();
            v.mokki.Mokki_id = int.Parse(lblID.Text);
            v.asiakas.Asiakas_id = a.Asiakas_id;
            v.varattu_alkupvm = DateTime.Parse(lblAlku.Text);
            v.varattu_loppupvm = DateTime.Parse(lblLoppu.Text);
            

            foreach (Palvelu p in listBox2.Items)
            {
                v.palvelut.Add(p);
            }
            TaskDB.LisaaVaraus(v);
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

                tbEtunimi.Text = a.Etunimi;
                tbSukunimi.Text = a.Sukunimi;
                tbOsoite.Text = a.Lahiosoite;
                tbPostinro.Text = a.Postinro;
                tbPuhnro.Text = a.Puhelinnro;
            }
             catch
            {
                
                
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
                
            }
        }

        private void btnLisapalvelut_Click(object sender, EventArgs e)
        {

        }

        private void btnValitsePalvelu_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox2.ValueMember = "palvelu_id";
            listBox2.DisplayMember = "nimi";
        }

        private void btnPoistaValittuPalvelu_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
