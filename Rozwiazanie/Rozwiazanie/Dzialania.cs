using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozwiazanie
{
    public class Dzialania : Bazowa
    {

        public static int OstatnieId
        {
            get
            {
                int id = 0;

                try
                {
                    if (Polaczenie.State == System.Data.ConnectionState.Closed)
                    {
                        Polaczenie.Open();
                    }

                    ZapytanieSQL = string.Format("select Id from BazaOsob order by Id desc limit 1");
                    komenda = new System.Data.SQLite.SQLiteCommand(ZapytanieSQL, Polaczenie);
                    id = Convert.ToInt32(komenda.ExecuteScalar());
                    ++id;

                }
                catch (Exception ex)
                {
                    string byk = string.Format(" Problem podczas pobierania ostatniego Id :\n{0}", ex.Message);
                    MessageBox.Show(byk, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    Polaczenie.Close();
                }

                return id;
            }
        }

        // nrkl
        public static int OstatniNrKl
        {
            get
            {
                int nr = 0;

                try
                {
                    if (Polaczenie.State == System.Data.ConnectionState.Closed)
                    {
                        Polaczenie.Open();
                    }

                    ZapytanieSQL = string.Format("select NrKl from BazaOsob order by NrKl desc limit 1");
                    komenda = new System.Data.SQLite.SQLiteCommand(ZapytanieSQL, Polaczenie);
                    nr = Convert.ToInt32(komenda.ExecuteScalar());
                    ++nr;

                }
                catch (Exception ex)
                {
                    string byk = string.Format(" Problem podczas pobierania ostatniego Nrkl :\n{0}", ex.Message);
                    MessageBox.Show(byk, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    Polaczenie.Close();
                }

                return nr;
            }
        }

        //dodaje nowa osobe 
        public static bool Dodaj(int nrKl, string imie, string nazwisko, string adres, string telefon, string email, bool wyswietlPowiadomienie = true)
        {
            bool wynik = false;

            try
            {
                if (Polaczenie.State == System.Data.ConnectionState.Closed)
                {
                    Polaczenie.Open();
                }

                ZapytanieSQL = string.Format("select Count(Id) from BazaOsob where NrKl = {0}", nrKl);
                komenda = new System.Data.SQLite.SQLiteCommand(ZapytanieSQL, Polaczenie);
                int liczba = Convert.ToInt32(komenda.ExecuteScalar());

                if (liczba == 0)
                {
                    ZapytanieSQL = string.Format("insert into BazaOsob(NrKl, Imie, Nazwisko, Adres, Telefon, Email)" +
                        "values({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", nrKl, imie, nazwisko, adres, telefon, email);
                    komenda.CommandText = ZapytanieSQL;
                    komenda.ExecuteNonQuery();

                    wynik = true;
                    if (wyswietlPowiadomienie)
                    {
                        MessageBox.Show("Poprawnie dodano nowa osobe", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (liczba > 0)
                {
                    MessageBox.Show(string.Format("Osoba o NrKl = {0} juz istnieje", nrKl), "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wynik = false;
                }
            }
            catch (Exception ex)
            {
                string byk = string.Format("Problem podczas dodawania osoby :\n{0}", ex.Message);
                MessageBox.Show(byk, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wynik = false;
            }

            finally
            {
                Polaczenie.Close();
            }

            return wynik;
        }

        //Edytuj nowa osobe 
        public static bool Edytuj(int nrKl, string imie, string nazwisko, string adres, string telefon, string email, bool wyswietlPowiadomienie = true)
        {
            bool wynik = false;

            try
            {
                if (Polaczenie.State == System.Data.ConnectionState.Closed)
                {
                    Polaczenie.Open();
                }

                ZapytanieSQL = string.Format("select Count(Id) from BazaOsob where NrKl = {0}", nrKl);
                komenda = new System.Data.SQLite.SQLiteCommand(ZapytanieSQL, Polaczenie);
                int liczba = Convert.ToInt32(komenda.ExecuteScalar());

                if (liczba == 1)
                {
                    ZapytanieSQL = string.Format("update BazaOsob set Imie = '{0}', Nazwisko = '{1}', Adres ='{2}', Telefon ='{3}', Email = '{4}' where NrKl = {5} ",
                        imie, nazwisko, adres, telefon, email, nrKl);
                    komenda.CommandText = ZapytanieSQL;
                    komenda.ExecuteNonQuery();

                    wynik = true;
                    if (wyswietlPowiadomienie)
                    {
                        MessageBox.Show("Osoba zostala poprawnie edytowana", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (liczba == 0)
                {
                    MessageBox.Show(string.Format("Osoba o NrKl = {0} nie istnieje", nrKl), "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wynik = false;
                }
            }
            catch (Exception ex)
            {
                string byk = string.Format(" Problem podczas edycji osoby :\n{0}", ex.Message);
                MessageBox.Show(byk, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wynik = false;
            }

            finally
            {
                Polaczenie.Close();
            }

            return wynik;
        }

        //usuwanie
        public static bool Usun(int nrKl, bool wyswietlPowiadomienie = true)
        {
            bool wynik = false;

            try
            {
                if (Polaczenie.State == System.Data.ConnectionState.Closed)
                {
                    Polaczenie.Open();
                }

                ZapytanieSQL = string.Format("select Count(Id) from BazaOsob where NrKl = {0}", nrKl);
                komenda = new System.Data.SQLite.SQLiteCommand(ZapytanieSQL, Polaczenie);
                int liczba = Convert.ToInt32(komenda.ExecuteScalar());

                if (liczba == 1)

                {
                    ZapytanieSQL = string.Format("delete from BazaOsob where NrKl = {0}", nrKl);
                    komenda.CommandText = ZapytanieSQL;
                    komenda.ExecuteNonQuery();
                    wynik = true;

                    if (wyswietlPowiadomienie)
                    {
                        MessageBox.Show("Klient Usuniety", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else if (liczba == 0)
                {
                    MessageBox.Show(string.Format("Nie ma osoby z NrKl = {0}", nrKl), "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wynik = false;
                }

            }
            catch (Exception ex)
            {
                string byk = string.Format(" Problem podczas usuwania osoby  :\n{0}", ex.Message);
                MessageBox.Show(byk, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Polaczenie.Close();
            }

            return wynik;
        }

        //metoda zwraca liste klientow
        public static List<Osoby> ListaOsob
        {
            get
            {
                List<Osoby> lista = new List<Osoby>();

                try
                {
                    if (Polaczenie.State == System.Data.ConnectionState.Closed)
                    {
                        Polaczenie.Open();
                    }
                    ZapytanieSQL = "select * from BazaOsob";
                    komenda = new System.Data.SQLite.SQLiteCommand(ZapytanieSQL, Polaczenie);
                    Czytnik = komenda.ExecuteReader();

                    if (Czytnik.HasRows)
                    {
                        while (Czytnik.Read())
                        {
                            lista.Add(new Osoby(Czytnik.GetInt32(0), Czytnik.GetInt32(1), Czytnik["Imie"].ToString(),
                                Czytnik["Nazwisko"].ToString(), Czytnik["Adres"].ToString(), Czytnik["Telefon"].ToString(),
                                Czytnik["Email"].ToString()));
                        }
                        Czytnik.Close();
                    }

                }
                catch (Exception ex)
                {
                    string byk = string.Format("Problem podczas pobierania listy osob  :\n{0}", ex.Message);
                    MessageBox.Show(byk, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    Polaczenie.Close();
                }

                return lista;
            }
        }
        //end klient wlasciwoci

    }

    public class Osoby
    {
        public int Id { get; set; }
        public int NrKl { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }


        //konstruktor domyslny
        public Osoby()
        {


        }

        //konstruktor przeciazony 
        public Osoby(int id, int nrKl, string imie, string nazwisko, string adres, string telefon, string email)
        {
            this.Id = id;
            this.NrKl = nrKl;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Adres = adres;
            this.Telefon = telefon;
            this.Email = email;
        }
    }
}
