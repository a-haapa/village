using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System;

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
        public static DataTable ReadFromMokki()
        {
            //Tietojen haku "Mökki" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename5}", connection);

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
        public static DataTable DeleteFromSQLite()
        {   //Tietojen poistaminen tietokannassa "Asiakas" -kohdasta
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand();

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    DataTable tt = new DataTable();
                    tt.Load(rdr);
                    rdr.Close();
                    connection.Close();
                    ReadFromAsiakas();
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
        public static bool AddToSql(string etunimi, string sukunimi, string lahiosoite, string email, string puhelinnro)
        {   // Lisää käyttäjän kirjaamat tiedot kantaan
            try
            {
                if (File.Exists(filename))
                {
                    SQLiteConnection connection = new SQLiteConnection($"Data source={filename};Version=3");
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename} (etunimi,sukunimi,lahiosoite,postinro,toimipaikka,email,puhelinnro)" +
                        $"VALUES ('{etunimi}','{sukunimi}','{lahiosoite}','{email}','{puhelinnro}')", connection);
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
    }
}