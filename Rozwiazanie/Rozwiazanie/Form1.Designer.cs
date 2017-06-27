namespace Rozwiazanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DODAJ = new System.Windows.Forms.TabPage();
            this.button1_dodaj = new System.Windows.Forms.Button();
            this.email_dodaj_textbox = new System.Windows.Forms.TextBox();
            this.telefon_dodaj_textbox = new System.Windows.Forms.TextBox();
            this.adres_dodaj_textbox = new System.Windows.Forms.TextBox();
            this.nazwisko_dodaj_textbox = new System.Windows.Forms.TextBox();
            this.imie_dodaj_textbox = new System.Windows.Forms.TextBox();
            this.idOsoby_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idOsoby_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.email_edytuj_textBox = new System.Windows.Forms.TextBox();
            this.telefon_edytuj_textBox = new System.Windows.Forms.TextBox();
            this.adres_edytuj_textBox = new System.Windows.Forms.TextBox();
            this.nazwisko_edytuj_textBox = new System.Windows.Forms.TextBox();
            this.imie_edytuj_textBox = new System.Windows.Forms.TextBox();
            this.id_edytuj_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_edytuj_label = new System.Windows.Forms.Label();
            this.listaEdytowana_listBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.Lista_Usuwanie_listBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.id_usun_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DODAJ.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DODAJ);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // DODAJ
            // 
            this.DODAJ.Controls.Add(this.button1_dodaj);
            this.DODAJ.Controls.Add(this.email_dodaj_textbox);
            this.DODAJ.Controls.Add(this.telefon_dodaj_textbox);
            this.DODAJ.Controls.Add(this.adres_dodaj_textbox);
            this.DODAJ.Controls.Add(this.nazwisko_dodaj_textbox);
            this.DODAJ.Controls.Add(this.imie_dodaj_textbox);
            this.DODAJ.Controls.Add(this.idOsoby_textBox);
            this.DODAJ.Controls.Add(this.label6);
            this.DODAJ.Controls.Add(this.label5);
            this.DODAJ.Controls.Add(this.label4);
            this.DODAJ.Controls.Add(this.label3);
            this.DODAJ.Controls.Add(this.label2);
            this.DODAJ.Controls.Add(this.idOsoby_label);
            this.DODAJ.Location = new System.Drawing.Point(4, 22);
            this.DODAJ.Name = "DODAJ";
            this.DODAJ.Padding = new System.Windows.Forms.Padding(3);
            this.DODAJ.Size = new System.Drawing.Size(763, 299);
            this.DODAJ.TabIndex = 0;
            this.DODAJ.Text = "Dodaj";
            this.DODAJ.UseVisualStyleBackColor = true;
            // 
            // button1_dodaj
            // 
            this.button1_dodaj.Location = new System.Drawing.Point(345, 238);
            this.button1_dodaj.Name = "button1_dodaj";
            this.button1_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button1_dodaj.TabIndex = 12;
            this.button1_dodaj.Text = "Dodaj";
            this.button1_dodaj.UseVisualStyleBackColor = true;
            this.button1_dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // email_dodaj_textbox
            // 
            this.email_dodaj_textbox.Location = new System.Drawing.Point(292, 193);
            this.email_dodaj_textbox.Name = "email_dodaj_textbox";
            this.email_dodaj_textbox.Size = new System.Drawing.Size(186, 20);
            this.email_dodaj_textbox.TabIndex = 11;
            // 
            // telefon_dodaj_textbox
            // 
            this.telefon_dodaj_textbox.Location = new System.Drawing.Point(292, 159);
            this.telefon_dodaj_textbox.Name = "telefon_dodaj_textbox";
            this.telefon_dodaj_textbox.Size = new System.Drawing.Size(186, 20);
            this.telefon_dodaj_textbox.TabIndex = 10;
            // 
            // adres_dodaj_textbox
            // 
            this.adres_dodaj_textbox.Location = new System.Drawing.Point(292, 118);
            this.adres_dodaj_textbox.Name = "adres_dodaj_textbox";
            this.adres_dodaj_textbox.Size = new System.Drawing.Size(186, 20);
            this.adres_dodaj_textbox.TabIndex = 9;
            // 
            // nazwisko_dodaj_textbox
            // 
            this.nazwisko_dodaj_textbox.Location = new System.Drawing.Point(292, 84);
            this.nazwisko_dodaj_textbox.Name = "nazwisko_dodaj_textbox";
            this.nazwisko_dodaj_textbox.Size = new System.Drawing.Size(186, 20);
            this.nazwisko_dodaj_textbox.TabIndex = 8;
            // 
            // imie_dodaj_textbox
            // 
            this.imie_dodaj_textbox.Location = new System.Drawing.Point(292, 50);
            this.imie_dodaj_textbox.Name = "imie_dodaj_textbox";
            this.imie_dodaj_textbox.Size = new System.Drawing.Size(186, 20);
            this.imie_dodaj_textbox.TabIndex = 7;
            // 
            // idOsoby_textBox
            // 
            this.idOsoby_textBox.Location = new System.Drawing.Point(292, 19);
            this.idOsoby_textBox.Name = "idOsoby_textBox";
            this.idOsoby_textBox.Size = new System.Drawing.Size(186, 20);
            this.idOsoby_textBox.TabIndex = 6;
            this.idOsoby_textBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imie";
            // 
            // idOsoby_label
            // 
            this.idOsoby_label.AutoSize = true;
            this.idOsoby_label.Font = new System.Drawing.Font("Meiryo", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idOsoby_label.Location = new System.Drawing.Point(143, 26);
            this.idOsoby_label.Name = "idOsoby_label";
            this.idOsoby_label.Size = new System.Drawing.Size(25, 21);
            this.idOsoby_label.TabIndex = 0;
            this.idOsoby_label.Text = "Id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.email_edytuj_textBox);
            this.tabPage2.Controls.Add(this.telefon_edytuj_textBox);
            this.tabPage2.Controls.Add(this.adres_edytuj_textBox);
            this.tabPage2.Controls.Add(this.nazwisko_edytuj_textBox);
            this.tabPage2.Controls.Add(this.imie_edytuj_textBox);
            this.tabPage2.Controls.Add(this.id_edytuj_textbox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.id_edytuj_label);
            this.tabPage2.Controls.Add(this.listaEdytowana_listBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edytuj";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Lista osob w bazie danych";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Edytuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // email_edytuj_textBox
            // 
            this.email_edytuj_textBox.Location = new System.Drawing.Point(115, 186);
            this.email_edytuj_textBox.Name = "email_edytuj_textBox";
            this.email_edytuj_textBox.Size = new System.Drawing.Size(192, 20);
            this.email_edytuj_textBox.TabIndex = 12;
            // 
            // telefon_edytuj_textBox
            // 
            this.telefon_edytuj_textBox.Location = new System.Drawing.Point(115, 151);
            this.telefon_edytuj_textBox.Name = "telefon_edytuj_textBox";
            this.telefon_edytuj_textBox.Size = new System.Drawing.Size(192, 20);
            this.telefon_edytuj_textBox.TabIndex = 11;
            // 
            // adres_edytuj_textBox
            // 
            this.adres_edytuj_textBox.Location = new System.Drawing.Point(115, 116);
            this.adres_edytuj_textBox.Name = "adres_edytuj_textBox";
            this.adres_edytuj_textBox.Size = new System.Drawing.Size(192, 20);
            this.adres_edytuj_textBox.TabIndex = 10;
            // 
            // nazwisko_edytuj_textBox
            // 
            this.nazwisko_edytuj_textBox.Location = new System.Drawing.Point(115, 84);
            this.nazwisko_edytuj_textBox.Name = "nazwisko_edytuj_textBox";
            this.nazwisko_edytuj_textBox.Size = new System.Drawing.Size(192, 20);
            this.nazwisko_edytuj_textBox.TabIndex = 9;
            // 
            // imie_edytuj_textBox
            // 
            this.imie_edytuj_textBox.Location = new System.Drawing.Point(115, 52);
            this.imie_edytuj_textBox.Name = "imie_edytuj_textBox";
            this.imie_edytuj_textBox.Size = new System.Drawing.Size(192, 20);
            this.imie_edytuj_textBox.TabIndex = 8;
            // 
            // id_edytuj_textbox
            // 
            this.id_edytuj_textbox.Location = new System.Drawing.Point(115, 21);
            this.id_edytuj_textbox.Name = "id_edytuj_textbox";
            this.id_edytuj_textbox.Size = new System.Drawing.Size(192, 20);
            this.id_edytuj_textbox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Imie";
            // 
            // id_edytuj_label
            // 
            this.id_edytuj_label.AutoSize = true;
            this.id_edytuj_label.Location = new System.Drawing.Point(23, 29);
            this.id_edytuj_label.Name = "id_edytuj_label";
            this.id_edytuj_label.Size = new System.Drawing.Size(16, 13);
            this.id_edytuj_label.TabIndex = 1;
            this.id_edytuj_label.Text = "Id";
            // 
            // listaEdytowana_listBox
            // 
            this.listaEdytowana_listBox.FormattingEnabled = true;
            this.listaEdytowana_listBox.Location = new System.Drawing.Point(416, 42);
            this.listaEdytowana_listBox.Name = "listaEdytowana_listBox";
            this.listaEdytowana_listBox.Size = new System.Drawing.Size(326, 238);
            this.listaEdytowana_listBox.TabIndex = 0;
            this.listaEdytowana_listBox.SelectedIndexChanged += new System.EventHandler(this.lista_edytuj_listBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Lista_Usuwanie_listBox);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.id_usun_label);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(763, 299);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usun";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Wybierz wiersz do usuniecia";
            // 
            // Lista_Usuwanie_listBox
            // 
            this.Lista_Usuwanie_listBox.FormattingEnabled = true;
            this.Lista_Usuwanie_listBox.Location = new System.Drawing.Point(400, 39);
            this.Lista_Usuwanie_listBox.Name = "Lista_Usuwanie_listBox";
            this.Lista_Usuwanie_listBox.Size = new System.Drawing.Size(337, 225);
            this.Lista_Usuwanie_listBox.TabIndex = 3;
            this.Lista_Usuwanie_listBox.SelectedIndexChanged += new System.EventHandler(this.lista_usun_listBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "usun";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_usun_label
            // 
            this.id_usun_label.AutoSize = true;
            this.id_usun_label.Location = new System.Drawing.Point(108, 56);
            this.id_usun_label.Name = "id_usun_label";
            this.id_usun_label.Size = new System.Drawing.Size(19, 13);
            this.id_usun_label.TabIndex = 1;
            this.id_usun_label.Text = "Id ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybrales nr: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.DODAJ.ResumeLayout(false);
            this.DODAJ.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DODAJ;
        private System.Windows.Forms.Button button1_dodaj;
        private System.Windows.Forms.TextBox email_dodaj_textbox;
        private System.Windows.Forms.TextBox telefon_dodaj_textbox;
        private System.Windows.Forms.TextBox adres_dodaj_textbox;
        private System.Windows.Forms.TextBox nazwisko_dodaj_textbox;
        private System.Windows.Forms.TextBox imie_dodaj_textbox;
        private System.Windows.Forms.TextBox idOsoby_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idOsoby_label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox email_edytuj_textBox;
        private System.Windows.Forms.TextBox telefon_edytuj_textBox;
        private System.Windows.Forms.TextBox adres_edytuj_textBox;
        private System.Windows.Forms.TextBox nazwisko_edytuj_textBox;
        private System.Windows.Forms.TextBox imie_edytuj_textBox;
        private System.Windows.Forms.TextBox id_edytuj_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label id_edytuj_label;
        private System.Windows.Forms.ListBox listaEdytowana_listBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox Lista_Usuwanie_listBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label id_usun_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

