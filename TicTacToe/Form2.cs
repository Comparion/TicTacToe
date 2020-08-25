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
    public partial class Form2 : Form 
    {
        // zmienna ktora zabezpieczy gre przed remisem
        private int gra = 0;
        private Gomoku GomokuObj;
        public Form2()
        {
            InitializeComponent();
        }
        //funkcja która wypisuje wyniki graczy, resetuje zmienna sprawdzajaca czy wystapil remis, oraz zmienia stany przycisków 
        private void Wygrana()
        { 
            gra = 0;
            label2.Text = GomokuObj.Player1 + ": " + GomokuObj.Player1W;
            label3.Text = GomokuObj.Player2 + ": " + GomokuObj.Player2W;
            button10.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text!="")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                //funkcja jest wykonywana aby przy kazdej nowej rozgrywce, gre rozpoczynała inna osoba
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GomokuObj = new Gomoku();
            GomokuObj.Start();
            GomokuObj.Player1 = Form1.nazwa1;
            GomokuObj.Player2 = Form1.nazwa2;
            label2.Text = GomokuObj.Player1 + ": " + GomokuObj.Player1W;
            label3.Text = GomokuObj.Player2 + ": " + GomokuObj.Player2W;
            PasekStatusu1.Text= "Ruch wykonuje: " + GomokuObj.Active.Name;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // petla wyczysci zawartosc przycisków
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is Button && (Controls[i] as Button).Tag != null)
                {
                    (Controls[i] as Button).Text = "";
                }
            }
            GomokuObj.Zamiana();
            GomokuObj.Start();
            button10.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;
            // przypisanie do przycisku wartości w zaleznosci od tego kto wykonuje ruch
            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";


            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if ((sender as Button).Text != "")
            {
                MessageBox.Show("To pole jest juz zajęte!!!");
                return;
            }
            
            Point p = new Point();
            p = (Point)(sender as Button).Tag;

            (sender as Button).Text = GomokuObj.Active.Type == FieldType.ftCircle ? "O" : "X";

            GomokuObj.Set(p.X, p.Y);
            gra++;
            PasekStatusu1.Text = "Ruch wykonuje: " + GomokuObj.Active.Name;
            if (GomokuObj.Winner)
            {
                MessageBox.Show(String.Format("Brawo dla {0}", GomokuObj.Active.Name), "Wygrana!");
                Wygrana();
            }
            else if (gra == 9)
            {
                MessageBox.Show("REMIS!");
                GomokuObj.Zamiana();
                Wygrana();
            }
        }

        private void PasekStatusu1_Click(object sender, EventArgs e)
        {

        }
    }
}
