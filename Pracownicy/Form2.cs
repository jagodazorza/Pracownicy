using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy
{
    public partial class Form2 : Form
    {
        public string imie = "";
        public string stanowisko = "";
        public int wiek = 0;
        public string nazwisko = "";

        public Pracownik praco;
        public Form3 paren;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Pracownik p, Form3 form1)
        {
            praco = p;
            paren = form1;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            praco.imie = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            praco.nazwisko = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            praco.wiek = int.Parse(textBox3.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            praco.stanowisko = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paren.Dodawanie(praco);
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
