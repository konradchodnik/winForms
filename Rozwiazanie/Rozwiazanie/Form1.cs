using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozwiazanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Osoby> ListaOsob = null;

        //calkosc okna - okno glowne
        private void Form1_Load(object sender, EventArgs e)
        {
            InicjalizacjaDanych();
        }

        void InicjalizacjaDanych()
        {
            //lista
            ListaOsob = Dzialania.ListaOsob;

            //label id 
            idOsoby_label.Text = Dzialania.OstatnieId.ToString();
            idOsoby_textBox.Text = Dzialania.OstatniNrKl.ToString();

            id_usun_label.Text = "";

            listaEdytowana_listBox.Items.Clear();
            Lista_Usuwanie_listBox.Items.Clear();

            int licznik = 1;
            foreach (Osoby k in ListaOsob)
            {
                listaEdytowana_listBox.Items.Add(string.Format("{0}. {1} {2} {3}", licznik, k.Imie, k.Nazwisko, k.Email));
                Lista_Usuwanie_listBox.Items.Add(string.Format("{0}. {1} {2} {3}", licznik, k.Imie, k.Nazwisko, k.Email));
           
                ListViewItem item = new ListViewItem(licznik.ToString());
                item.SubItems.Add(k.NrKl.ToString());
                item.SubItems.Add(k.Imie);
                item.SubItems.Add(k.Nazwisko);
                item.SubItems.Add(k.Adres);
                item.SubItems.Add(k.Telefon);
                item.SubItems.Add(k.Email);

                licznik++;
            }

        }


        //Dodawanie
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(imie_dodaj_textbox.Text) && !string.IsNullOrWhiteSpace(nazwisko_dodaj_textbox.Text))
            {
                if (Dzialania.Dodaj(Convert.ToInt32(idOsoby_textBox.Text), 
                    imie_dodaj_textbox.Text, nazwisko_dodaj_textbox.Text, adres_dodaj_textbox.Text, 
                    telefon_dodaj_textbox.Text, email_dodaj_textbox.Text))
                {
                    InicjalizacjaDanych();
                    WyczyscPolaDodajKlienta();
                }

            }
            else
            {
                MessageBox.Show("Login i haslo musi byc podane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void WyczyscPolaDodajKlienta()
        {
            idOsoby_label.Text = Dzialania.OstatnieId.ToString();
            idOsoby_textBox.Text = Dzialania.OstatniNrKl.ToString();
            imie_dodaj_textbox.Text = "";
            nazwisko_dodaj_textbox.Text = "";
            adres_dodaj_textbox.Text = "";
            telefon_dodaj_textbox.Text = "";
            email_dodaj_textbox.Text = "";

        }
        //End Dodawanie


        //Edytuj
        private void button2_Click(object sender, EventArgs e)
        {
            if (listaEdytowana_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz klienta, ktorego chcesz aktualizowac", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Dzialania.Edytuj(Convert.ToInt32(id_edytuj_textbox.Text), imie_edytuj_textBox.Text,
                    nazwisko_edytuj_textBox.Text, adres_edytuj_textBox.Text, telefon_edytuj_textBox.Text,
                    email_edytuj_textBox.Text))
                {
                    int id = listaEdytowana_listBox.SelectedIndex;
                    InicjalizacjaDanych();
                    listaEdytowana_listBox.SelectedIndex = id;
                }
            }
        }


        //edytuj Lista
        private void lista_edytuj_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listaEdytowana_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz klienta, ktorego chcesz aktualizowac", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] tab = listaEdytowana_listBox.Text.Split(new string[] { ".", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (tab.Length >= 2)
                {
                    var osobal = ListaOsob.FirstOrDefault(x => x.Equals(tab[1].Trim()) && x.Nazwisko.Equals(tab[2].Trim()));

                    if (osobal != null)
                    {
                        id_edytuj_label.Text = osobal.Id.ToString();
                        id_edytuj_textbox.Text = osobal.NrKl.ToString();
                        imie_edytuj_textBox.Text = osobal.Imie;
                        nazwisko_edytuj_textBox.Text = osobal.Nazwisko;
                        adres_edytuj_textBox.Text = osobal.Adres;
                        telefon_edytuj_textBox.Text = osobal.Telefon;
                        email_edytuj_textBox.Text = osobal.Email;

                    }
                }
                else
                {
                    MessageBox.Show("Brak imienia/nazwiska", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        //End Edytuj


        //Usun
        private void button3_Click(object sender, EventArgs e)
        {

            if (Lista_Usuwanie_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz klienta do usuniecia", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (!string.IsNullOrWhiteSpace(id_usun_label.Text))
                {
                    //DialogResult dialog = MessageBox.Show("Czy napewni chcesz usunac?");
                    if (Dzialania.Usun(Convert.ToInt32(id_usun_label.Text)))
                    {
                        InicjalizacjaDanych();
                    }
                }
            }
        }
        //Usun - Lista
        private void lista_usun_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista_Usuwanie_listBox.SelectedIndex != -1)
            {
                string[] tab = Lista_Usuwanie_listBox.Text.Split(new string[] { ".", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (tab.Length >= 2)
                {
                    var osobal = ListaOsob.FirstOrDefault(x => x.Imie.Equals(tab[1].Trim()) && x.Nazwisko.Equals(tab[2].Trim()));

                    if (osobal != null)
                    {
                        id_usun_label.Text = osobal.NrKl.ToString();
                    }
                    else
                    {
                        id_usun_label.Text = "";
                    }
                }

            }
            else
            {
                id_usun_label.Text = "";
            }
        }

        //End Usun
    }
}
