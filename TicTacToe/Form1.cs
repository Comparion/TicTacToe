using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public static string nazwa1, nazwa2;
        Form2 Form2_ = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(textPlayer1.Text.Length > 0 && textPlayer2.Text.Length > 0)
            {
                if (textPlayer1.Text.Length < 3 || textPlayer2.Text.Length < 3)
                {
                    MessageBox.Show("Nazwa gracza min. 3 znaki!");
                }
                else
                {
                    nazwa1 = textPlayer1.Text;
                    nazwa2 = textPlayer2.Text;
                    // Pokazanie Form2
                    Form2_.Show();
                    // Ukrycie Form1
                    this.Hide();
                    // GomokuObj.Start();
                }
            }
            else
            {
                MessageBox.Show("Brak nazwy gracza!");
            }
        }
    }
}
