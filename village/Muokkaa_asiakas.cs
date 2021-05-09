using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace village
{
	public partial class Muokkaa_asiakas : Form
	{
		public Muokkaa_asiakas(Asiakas asiakas)
		{
			InitializeComponent();
			tbMuokkaAsiakasID.Text = asiakas.Asiakas_id.ToString();
			tbMuokkaaAsEtunimi.Text = asiakas.Etunimi.ToString();
			tbMuokkaaAsSukunimi.Text = asiakas.Sukunimi.ToString();
			tbMuokkaaAsLahOs.Text = asiakas.Lahiosoite.ToString();
			tbMuokkaaAsPosNum.Text = asiakas.Postinro.ToString();
			tbMuokkaaAsSposti.Text = asiakas.Email.ToString();
			tbMuokkaaAspuhnro.Text = asiakas.Puhelinnro.ToString();
		}

		private void btnPoisAsMuok_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnTalAsMuok_Click(object sender, EventArgs e)
		{
			Asiakas a = new Asiakas();
			a.Asiakas_id = int.Parse(tbMuokkaAsiakasID.Text);
			a.Etunimi = tbMuokkaaAsEtunimi.Text;
			a.Sukunimi = tbMuokkaaAsSukunimi.Text;
			a.Lahiosoite = tbMuokkaaAsLahOs.Text;
			a.Postinro = tbMuokkaaAsPosNum.Text;
			a.Email = tbMuokkaaAsSposti.Text;
			a.Puhelinnro = tbMuokkaaAspuhnro.Text;
			TaskDB.MuokkaaAsiakas(a);
			yllapito formi = new yllapito();
			formi.Show();
			this.Close();
		}
	}
}
