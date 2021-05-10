using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System;
using System.Collections.Generic;

namespace village
{
    public static class TaskDB
    {
        private static string filename;
        private static string tablename;
        private static string tablename2;
        private static string tablename3;
        private static string tablename4;
        private static string tablename5;
        private static string tablename6;
        private static string tablename7;
        private static string tablename8;

        static TaskDB()
        {
            //Tietokannan taulut
            filename = village.Properties.Settings.Default.database;
            tablename = village.Properties.Settings.Default.table1; //asiakas
            tablename2 = village.Properties.Settings.Default.table2; //lasku
            tablename3 = village.Properties.Settings.Default.table3; //varaus
            tablename4 = village.Properties.Settings.Default.table4; //posti
            tablename5 = village.Properties.Settings.Default.table5; //mökki
            tablename6 = village.Properties.Settings.Default.table6;  //toiminta-alue
            tablename7 = village.Properties.Settings.Default.table7;  //palvelu
            tablename8 = village.Properties.Settings.Default.table8;  //varauksen palvelu

        }
        public static DataTable ReadFromAsiakas()
        {
            //Tietojen haku "asiakas" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeToimintaalue()
        {
            //Tietojen haku "Toiminta-alueet" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename6}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeTaID(string str)
        {
            //Tietojen haku "Toiminta-alueet" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT toimintaalue_id FROM {tablename6} WHERE nimi='{str}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }

        public static DataTable HaeToimintaalueMuok(int id) //Luotu oma toiminta-alueen haku muokkausta varten 
        {
            //Tietojen haku "Toiminta-alueet" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename6}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }

        public static bool LisaaToimintaalue(Toimintaalue t)
        {   // Lisää käyttäjän kirjaamat toiminta-aluetiedot kantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename6} (nimi)" +
                        $"VALUES ('{t.Nimi}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static bool LisaaMokki(Mokki m)
        {   // Lisää käyttäjän kirjaamat mökkitiedot tietokantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename5} (mokkinimi,toimintaalue_id,katuosoite,postinro,henkilomaara,kuvaus,varustelu,mokinhinta,mokinalv)" +
                        $"VALUES ('{m.Mokkinimi}','{m.MokinToimintaalue.Toimintaalue_id}','{m.Katuosoite}','{m.Postinro}','{m.Henkilomaara}','{m.Kuvaus}','{m.Varustelu}','{m.Mokinhinta}','{m.Mokinalv}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }

        public static DataTable HaeMokki(int varausid)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT toimintaalue.nimi,mokki_id,mokkinimi,mokinhinta,mokinalv,katuosoite,postinro " +
                    $"FROM {tablename5},{tablename3},{tablename6} WHERE varaus.mokki_mokki_id=mokki.mokki_id and varaus.varaus_id='{varausid}' and mokki.toimintaalue_id=toimintaalue.toimintaalue_id", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeMokki2(int id, DateTime date1, DateTime date2)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro " +
                    $"FROM {tablename5},{tablename6} WHERE mokki.toimintaalue_id='{id}' and mokki.henkilomaara <'{4}' and mokki_id NOT IN " +
                    $"(SELECT mokki_id FROM {tablename3},{tablename5} " +
                    $"WHERE mokki.mokki_id=varaus.mokki_mokki_id and varaus.varattu_alkupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}' and varaus.varattu_loppupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}')", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeMokki4(int id, DateTime date1, DateTime date2)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro " +
                    $"FROM {tablename5} WHERE toimintaalue_id='{id}' and henkilomaara <'{7}' and mokki_id NOT IN " +
                    $"(SELECT mokki_id FROM {tablename3},{tablename5} " +
                    $"WHERE mokki.mokki_id=varaus.mokki_mokki_id and varaus.varattu_alkupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}' and varaus.varattu_loppupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}')", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeMokki5(int id, DateTime date1, DateTime date2)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro " +
                    $"FROM {tablename5} WHERE mokki.toimintaalue_id='{id}' and mokki.henkilomaara BETWEEN '{7}' and '{10}' and mokki_id NOT IN " +
                    $"(SELECT mokki_id FROM {tablename3},{tablename5} " +
                    $"WHERE mokki.mokki_id=varaus.mokki_mokki_id and varaus.varattu_alkupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}' and varaus.varattu_loppupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}')", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeMokki6(int id, DateTime date1, DateTime date2)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro " +
                    $"FROM {tablename5} WHERE mokki.toimintaalue_id='{id}' and mokki.henkilomaara> '{10}' and mokki_id NOT IN " +
                    $"(SELECT mokki_id FROM {tablename3},{tablename5} " +
                    $"WHERE mokki.mokki_id=varaus.mokki_mokki_id and varaus.varattu_alkupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}' and varaus.varattu_loppupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}')", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeMokki3(int id, DateTime date1, DateTime date2)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro " +
                    $"FROM {tablename5},{tablename6} WHERE mokki.toimintaalue_id='{id}' and mokki_id NOT IN " +
                    $"(SELECT mokki_id FROM {tablename3},{tablename5} " +
                    $"WHERE mokki.mokki_id=varaus.mokki_mokki_id and varaus.varattu_alkupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}' and varaus.varattu_loppupvm BETWEEN '{date1.ToString("yyyy-MM-dd")}' and '{date2.ToString("yyyy-MM-dd")}')", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeMokit()
        {
            //Tietojen haku "Mökki" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro,kuvaus,varustelu FROM {tablename5}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable Hae(int id)
        {
            //Hakee yksittäisen mökin id-numeron perusteella
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename5}, {tablename6} WHERE mokki.mokki_id='{id}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        
        

        public static DataTable PoistaToimintaAlue(int id)
        {   //Tietojen poistaminen tietokannassa "Toiminta-Alue" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tablename6} WHERE toimintaalue_id = '{id}'", connection);
                        

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    HaeToimintaalue();
                    return tt;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }

        public static DataTable PoistaMokki(int id)
        {   //Tietojen poistaminen tietokannassa "mökki" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tablename5} WHERE mokki_id = '{id}'", connection);


                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    HaeMokit();
                    return tt;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static bool LisaaAsiakas(Asiakas a)
        {   // Lisää käyttäjän kirjaamat asiakastiedot tietokantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename} (etunimi,sukunimi,postinro,lahiosoite,email,puhelinnro)" +
                        $"VALUES ('{a.Etunimi}','{a.Sukunimi}','{a.Postinro}','{a.Lahiosoite}','{a.Email}','{a.Puhelinnro}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static DataTable HaeAsiakas(Asiakas a)
        {
            //Tietojen haku "asiakas" -taulusta sähköpostiosoitteen perusteella
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename} WHERE email='{a.Email}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeAsID()
        {
            //ID haku "asiakas" -taulusta sähköpostiosoitteen perusteella
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT max(asiakas_id FROM {tablename})", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();

                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeAsiakkaanTiedot()
        {
            //Tietojen haku "asiakas" -taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();

                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeAs(int varausid)
        {
            //Tietojen haku "asiakas" -taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT asiakas.asiakas_id,etunimi,sukunimi,lahiosoite,postinro FROM {tablename},{tablename3} " +
                    $"WHERE varaus.asiakas_id=asiakas.asiakas_id and varaus.varaus_id='{varausid}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();

                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static bool MuokkaaAsiakas(Asiakas a)
        {   //Päivittää tiedot asiakas taulussa 
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"UPDATE {tablename} SET etunimi='{a.Etunimi}', asiakas_id='{a.Asiakas_id}', etunimi ='{a.Etunimi}', sukunimi='{a.Sukunimi}'" +
                        $", lahiosoite='{a.Lahiosoite}', postinro='{a.Postinro}', email='{a.Email}',puhelinnro ='{a.Puhelinnro}' WHERE asiakas_id='{a.Asiakas_id}'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new System.IO.FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static DataTable PoistaAsiakas(int id)
        {   //Tietojen poistaminen tietokannassa "asiakas" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tablename} WHERE asiakas_id = '{id}'", connection);


                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    HaeAsiakkaanTiedot();
                    return tt;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }

        public static bool UpdateSql()
        {   //Päivittää tiedot tietokantaan
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new System.IO.FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static bool MuokkaaToimintaAlue( Toimintaalue t)
        {   //Päivittää tiedot toiminta-alue taulussa 
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"UPDATE {tablename6} SET nimi='{t.Nimi}', toimintaalue_id='{t.Toimintaalue_id}' WHERE toimintaalue_id='{t.Toimintaalue_id}'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new System.IO.FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }

        public static bool MuokkaaMokki(Mokki m)
        {   //Päivittää tiedot mökki taulussa 
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"UPDATE {tablename5} SET mokkinimi='{m.Mokkinimi}', mokki_id='{m.Mokki_id}', henkilomaara='{m.Henkilomaara}', mokinhinta='{m.Mokinhinta}'" +
                        $", katuosoite='{m.Katuosoite}', postinro='{m.Postinro}', kuvaus='{m.Kuvaus}', varustelu='{m.Varustelu}' WHERE mokki_id='{m.Mokki_id}'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new System.IO.FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }

        public static DataTable HaePalvelut()
        {
            //Tietojen haku "Palvelu" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT palvelu_id,toimintaalue.toimintaalue_id,palvelu.nimi,tyyppi,kuvaus,hinta,alv,toimintaalue.nimi" +
                    $" FROM {tablename7},{tablename6} WHERE palvelu.toimintaalue_id = toimintaalue.toimintaalue_id", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaePalvelunNimi(string ta)
        {
            //Tietojen haku "Palvelu" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT palvelu.nimi FROM {tablename6},{tablename7} WHERE palvelu.toimintaalue_id=toimintaalue.toimintaalue_id and toimintaalue.nimi='{ta}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        

        public static bool LisaaPalvelu(Palvelu p)
        {   // Lisää käyttäjän kirjaamat palvelut kantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename7} (toimintaalue_id,nimi,tyyppi,kuvaus,hinta,alv)" +
                        $"VALUES ('{p.toimintaalue.Toimintaalue_id}','{p.Nimi}','{p.Tyyppi}','{p.Kuvaus}','{p.Hinta}','{p.Alv}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static bool LisaaVarauksenPalvelu(varausL v, Palvelu p)
        {   // Lisää käyttäjän kirjaamat palvelut kantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename8} (varaus_id,palvelu_id,lkm) VALUES ((SELECT max(varaus_id) FROM {tablename3}),(SELECT palvelu_id FROM {tablename7} WHERE palvelu.nimi='{p.Nimi}'),'{v.Lukumaara}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static DataTable HaeVarauksenPalvelut(int varausid)
        {
            //THakee varausten palvelut
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT palvelu.nimi,varauksen_palvelut.lkm,palvelu.hinta FROM {tablename7},{tablename8} " +
                    $"WHERE palvelu.palvelu_id=varauksen_palvelut.palvelu_id and varauksen_palvelut.varaus_id='{varausid}' ", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeVaratutPalv()
        {
            //THakee varausten palvelut
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT palvelu.palvelu_id,palvelu.nimi,varauksen_palvelut.lkm FROM {tablename8},{tablename7} " +
                    $"WHERE palvelu.palvelu_id=varauksen_palvelut.palvelu_id ", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable PoistaPalvelu(int id)
        {   //Tietojen poistaminen tietokannassa "Palvelu" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tablename7} WHERE palvelu_id = '{id}'", connection);


                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    HaePalvelut();
                    return tt;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static bool MuokkaaPalvelu(Palvelu pa)
        {   //Päivittää tiedot palvelu taulussa 
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"UPDATE {tablename7} SET nimi='{pa.Nimi}',tyyppi='{pa.Tyyppi}',kuvaus='{pa.Kuvaus}',hinta='{pa.Hinta}',nimi='{pa.Nimi}',alv='{pa.Alv}' WHERE palvelu_id='{pa.Palvelu_id}'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new System.IO.FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
      
        public static bool LisaaVaraus(varausL v)
        {   // Lisää käyttäjän kirjaamat palvelut tietokantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename3} (asiakas_id,mokki_mokki_id,varattu_pvm,vahvistus_pvm,varattu_alkupvm,varattu_loppupvm)" +
                        $"VALUES ('{v.asiakas.Asiakas_id}','{v.Mokki_mokki_id}','{v.Varattu.ToString("yyyy-MM-dd")}','{v.Vahvistus_pvm.ToString("yyyy-MM-dd")}','{v.Varattu_alkupvm.ToString("yyyy-MM-dd")}','{v.Varattu_loppupvm.ToString("yyyy-MM-dd")}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static DataTable HaeVarausPVM()
        {
            //THakee varausten alku ja loppupäivämäärän !!! KESKEN, en tiedä onko sittenkään tarvetta !!!
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT varattu_alkupvm,varattu_loppupvm FROM {tablename3}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeVaraukset()
        {
            //Hakee varaukset
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT varaus.varaus_id,mokki.mokkinimi,varattu_alkupvm,varattu_loppupvm, etunimi,sukunimi " +
                    $"FROM {tablename3} " +
                    $"LEFT JOIN asiakas ON varaus.asiakas_id=asiakas.asiakas_id " +
                    $"LEFT JOIN mokki ON varaus.mokki_mokki_id=mokki.mokki_id", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeVaraus(int varausid)
        {
            //Hakee varaukset
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT varaus_id,varattu_pvm,varattu_alkupvm,varattu_loppupvm FROM {tablename3} WHERE varaus_id='{varausid}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }

        public static DataTable HaeVaID()
        {
            //THakee varauksen Id:n
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT max(varaus_id) FROM {tablename3}", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable PoistaVaraus(int id)
        {   //Tietojen poistaminen tietokannassa "Palvelu" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tablename3} WHERE varaus_id = '{id}'", connection);

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    HaePalvelut();
                    return tt;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static DataTable HaeRaportti(string toimialue, DateTime alku, DateTime loppu)
        {
            //Hakee varaukset
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,varattu_alkupvm,varattu_loppupvm FROM {tablename5},{tablename3},{tablename6} " +
                    $"WHERE mokki.mokki_id=varaus.mokki_mokki_id and varaus.varattu_alkupvm BETWEEN '{alku.ToString("yyyy-MM-dd")}' and '{loppu.ToString("yyyy-MM-dd")}' and mokki.toimintaalue_id=toimintaalue.toimintaalue_id", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static bool LisaaLasku(Lasku l)
        {   // Lisää käyttäjän kirjaamat palvelut tietokantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename2} (varaus_id,summa,alv)" +
                        $"VALUES ((SELECT max(varaus_id) FROM {tablename3}),'{l.summa}','{l.alv}')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }

        }
        public static DataTable HaeLaskut(DateTime alku,DateTime loppu)
        {
            //Hakee laskut toivotulle aikavälille
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT varaus.varaus_id,lasku_id,summa,asiakas_id,varattu_alkupvm,varattu_loppupvm,vahvistus_pvm FROM {tablename2},{tablename3} " +
                    $"WHERE lasku.varaus_id=varaus.varaus_id and varattu_alkupvm BETWEEN '{alku.ToString("yyyy-MM-dd")}' and '{loppu.ToString("yyyy-MM-dd")}' and varattu_loppupvm BETWEEN '{alku.ToString("yyyy-MM-dd")}' and '{loppu.ToString("yyyy-MM-dd")}'", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable HaeKaikkiLaskut()
        {
            //Hakee laskut toivotulle aikavälille
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT varaus.varaus_id,lasku_id,summa,asiakas_id,varattu_alkupvm,varattu_loppupvm,vahvistus_pvm FROM {tablename2},{tablename3} WHERE varaus.varaus_id=lasku.varaus_id", connection);

                //tiedon lukeminen
                SQLiteDataReader rdr = cmd.ExecuteReader();
                DataTable tt = new DataTable();
                tt.Load(rdr);
                rdr.Close();
                connection.Close();
                return tt;
            }
            else
            {
                throw new FileNotFoundException("Tiedostoa ei löytynyt");
            }
        }
        public static DataTable PoistaLasku(int id)
        {   //Tietojen poistaminen tietokannassa "Palvelu" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tablename2} WHERE varaus_id = '{id}'", connection);

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    HaePalvelut();
                    return tt;
                }
                else
                {
                    throw new FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        public static bool MuokkaaVahvistus(Lasku l, DateTime date)
        {   //Päivittää tiedot palvelu taulussa 
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"UPDATE {tablename3} SET vahvistus_pvm='{date.ToString("yyyy-MM-dd")}' WHERE varaus_id='{l.varaus.Varaus_id}'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                else
                {
                    throw new System.IO.FileNotFoundException("Tiedostoa ei löytynyt");
                }
            }
            catch
            {
                throw;
            }
        }
        
    }
}