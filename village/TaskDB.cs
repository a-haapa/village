﻿using System.Data;
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

        public static DataTable HaeMokki(int henkilomaara)
        {
            //Tietojen haku "Mökki" taulusta toiminta-alueen ja henkilömäärän mukaan
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro FROM {tablename5}, {tablename6} WHERE mokki.toimintaalue_id=toimintaalue.toimintaalue_id and mokki.henkilomaara='{henkilomaara}'", connection);

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
                SQLiteCommand cmd = new SQLiteCommand($"SELECT mokki_id,mokkinimi,henkilomaara,mokinhinta,mokinalv,katuosoite,postinro FROM {tablename5}", connection);

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
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename5} WHERE mokki.mokki_id='{id}'", connection);

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

        public static DataTable HaePalvelut()
        {
            //Tietojen haku "Palvelu" taulusta
            if (File.Exists(filename))
            {
                SQLiteConnection connection = new SQLiteConnection($"Data source={filename}; Version=3");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM {tablename7}", connection);

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
                    SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {tablename7} (palvelu_id,toimintaalue_id,nimi,tyyppi,kuvaus,hinta,alv)" +
                        $"VALUES ('{p.Palvelu_id}','{p.ToimintaAlue}','{p.Nimi}','{p.Tyyppi}','{p.Kuvaus}','{p.Hinta}','{p.Alv}')", connection);
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
    }
}