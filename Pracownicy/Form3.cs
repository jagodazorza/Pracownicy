﻿using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Pracownicy
{

    public partial class Form3 : Form
    {
        DataGridView dataGridView1 = new DataGridView();
        public string createID()
        {
            Random random = new Random();
            int rand = random.Next(300, 900);
            bool unique = false;
            while (!unique)
            {
                unique = true; // Założenie, że liczba jest unikalna

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int existingValue))
                    {
                        if (existingValue == rand)
                        {
                            unique = false; // Jeśli liczba już istnieje, przerywamy pętlę i szukamy nowej
                            rand = random.Next(300, 900); // Generujemy nową liczbę
                            break;
                        }
                    }
                }
            }
            return rand.ToString();

        }
        public Form3()
        {
            InitializeComponent();

            dataGridView1.Dock = DockStyle.Fill;

            // Utworzenie kolumn
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Imię", "Imię");
            dataGridView1.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("Wiek", "Wiek");
            dataGridView1.Columns.Add("Stanowisko", "Stanowisko");


            Controls.Add(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pracownik p = new Pracownik();
            Form2 form2 = new Form2(p, this);
            form2.Show();
        }

        public void Dodawanie(Pracownik praco)
        {
            dataGridView1.Rows.Add(new object[] { createID(), praco.imie, praco.nazwisko, praco.wiek.ToString(), praco.stanowisko });
        }

        public void Usuwanie()
        {

        }

        private void ExportToCSV(DataGridView dataGridView1, string filePath)
        {
            // Tworzenie nagłówka pliku CSV
            string csvContent = "ID,Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Pomijaj wiersze niemieszczące się w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne wartości w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawartości do pliku CSV
            File.WriteAllText(filePath, csvContent);
            MessageBox.Show("zapisano  " + csvContent + " do pliku " + filePath);

        }

        private void LoadCSVToDataGridView(string filePath)
        {

            // Sprawdź, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Odczytaj zawartość pliku CSV
            string[] lines = File.ReadAllLines(filePath);

            // Tworzenie tabeli danych

            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nagłówka
            string[] headers = lines[0].Split(",");
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(",");
                dataTable.Rows.Add(values);
            }
            // Przypisanie tabeli danych do DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            { ExportToCSV(dataGridView1, openFileDialog1.FileName); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywołanie funkcji wczytującej dane z pliku CSV
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) // Nie usuwamy pustego wiersza na końcu
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
