using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    using System;
    // okreslenie czy  w polu będzie kółko czy krzyzyk
    public enum FieldType { ftCircle = 1, ftCross = 10};
    // struktura opisująca gracza
    public struct Player
    {
        // nazwa gracza
        public string Name;
        //ilosc zwycieztw
        public int Winnings;
        // reprezenujacy go znak (kółko, krzyzyk)
        public FieldType Type;
    }
    
    class Gomoku
    {
        // tablica reprezentująca pole do gry
        private FieldType[,] FField = new FieldType[3, 3];
        // zmienna oznaczajaca zycieztwo
        private bool FWinner;
        // ID gracza który wykonuje ruch
        private int FActive;
        // tablica reprezenujaca dwóch graczy
        private Player[] FPlayer = new Player[2];
        private string GetPlayer1()
        {
        return FPlayer [0].Name;
        }

        private void SetPlayer1(string Name)
        {
            FPlayer[0].Name = Name;
        }

        private string GetPlayer2()
        {
            return FPlayer[1].Name;
        }

        private void SetPlayer2(string Name)
        {
            FPlayer[1].Name = Name;
        }
        // właściwości które zwracają informacje o graczach, a także ustawiają jego nazwe dzięki słowu kluczowemu value które ma szczególną 
        // funkcję wewnątrz ciała właścciwości ( reprezentuje wartość przypisaną do właciwości w akcesorze set)
        public string Player1
        {
            get
            {
                return GetPlayer1();
            }
            set
            {
                SetPlayer1(value);
            }
        }

        public string Player2
        {
            get
            {
                return GetPlayer2();
            }
            set
            {
                SetPlayer2(value);
            }
        }
        // właściwośći ktore zwracają z akcesorami get które zwracaja ilość wygranych graczy
        public int Player1W
        {
            get
            {
                return FPlayer[0].Winnings;
            }
        }

        public int Player2W
        {
            get
            {
                return FPlayer[1].Winnings;
            }
        }
        private Player GetActive()
        {
            return FPlayer[this.FActive];
        }
        public bool Winner
        {
            get
            {
                return FWinner;
            }
        }
        // właściwośc zwracająca aktywnego gracza
        public Player Active
        {
            get
            {
                return GetActive();
            }
        }

        public FieldType[,] Field
        {
            get
            {
                return FField;
            }
            
        }
        // metoda sprawdza czy gracz nr 1 lub 2, wygrał gre
        private void Sum(int Value)
        {
            if (Value == 3 || Value == 30)
            {
                FPlayer[FActive].Winnings++;
                FWinner = true;
            }
        }

        // algorytm sprawdza czy któryś z graczy wygrał gre
        private void CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                Sum((int)FField[i, 0] + (int)FField[i, 1] + (int)FField[i, 2]);
                Sum((int)FField[0, i] + (int)FField[1, i] + (int)FField[2, i]);
            }

            Sum((int)FField[0, 0] + (int)FField[1, 1] + (int)FField[2, 2]);
            Sum((int)FField[0, 2] + (int)FField[1, 1] + (int)FField[2, 0]);
        }

        /* rozpoczyna właściwą grę */
        public void Start()
        {
            // przyporządkowanie symbolu danemu graczowi
            FPlayer[0].Type = FieldType.ftCircle;
            FPlayer[1].Type = FieldType.ftCross;

            FWinner = false;
            // czyszczenie tablicy 
            System.Array.Clear(FField, 0, FField.Length);
        }

     
        // Metoda służy do ustawiania symbolu na danym polu
        public bool Set(int X, int Y)
        {
            // ponieważ indeks tablic rozpoczyna się od zera, należy zmniejszyć 
            // wartości współrzędnych bo user podaje współrzędne numerowane od 1
            --X;
            --Y;

            // ustawienie znaku na danym polu
            FField[X, Y] = GetActive().Type;
            // sprawdzenie czy należy zakończyć grę?
            CheckWinner();

            // jeżeli nikt nie wygrał - zamiana graczy
            if (!Winner)
            {
                Zamiana();
            }
            return true;
        }

        public void Zamiana()
        {
            FActive = (FActive == 0 ? 1 : 0);
        }
    }
}
