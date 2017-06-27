using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozwiazanie
{
    public class Bazowa
    {
        private static SQLiteConnection _Polaczenie;

        public static SQLiteConnection Polaczenie
        {

            get
            {
                //sprawdzenie czy plik na dysku istnieje, jesli nie to tworzenie bazy i tabel
                if (!File.Exists(Path.Combine(Application.StartupPath, "BazaDanych.db")))
                {
                    //nowe
                    _Polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "BazaDanych.db")));
                    //otwarcie polaczenia 
                    _Polaczenie.Open();
                    //tworzenie tabel
                    ZapytanieSQL = string.Format("create table if not exists BazaOsob(Id integer primary key autoincrement, NrKl integer, Imie varchar(100), Nazwisko varchar(100), Adres varchar(100), Telefon varchar(100),  Email varchar(100))");

                    komenda = new SQLiteCommand(ZapytanieSQL, Polaczenie);
                    komenda.ExecuteNonQuery();

                    //zamkniecie polaczenia
                    _Polaczenie.Close();
                }
                else
                {
                    //jesli polaczenie jest null'em
                    if (_Polaczenie == null)
                    {
                        //to ponownie utworz baze
                        _Polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "BazaDanych.db")));

                    }
                }
                return _Polaczenie;
            }
        }

        public static SQLiteCommand komenda;

        public static SQLiteDataReader Czytnik;

        public static string ZapytanieSQL = "";


    }
}
