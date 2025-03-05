using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testScript;


namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        testClass tst = new testClass();
        Image X;
        Image O;
        int count = 0; // oyun sayısını kontrol eder
        Button[] buttons; // button dizisi
        char[,] board = { { '_', '_', '_' },
                          { '_', '_', '_' },
                          { '_', '_', '_' }};// button durumunu tutan dizi ('_' = boş , 'x' = X, 'o' = O)
        int[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //(0 = boş , 1 = X, 2 = O)

        private void Form6_Load(object sender, EventArgs e)
        {
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            Reset();

            X = Image.FromFile(Application.StartupPath + @"../../../images/LetterX.png"); // X gorseli
            O = Image.FromFile(Application.StartupPath + @"../../../images/LetterO.png"); // O gorseli

        }
        private void Reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '_';
                    values[j + (3 * i)] = 0;
                    buttons[j + (3 * i)].Image = null;
                    buttons[j + (3 * i)].Enabled = true;
                }
            }

            count = 0;
            lblSkor.Text = "Skor: ";
            lblOutput.Text = " ";
            lblSkor.ForeColor = Color.Black;
        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {
            if (!(txtStudentNo.Text.All(char.IsDigit)) || txtStudentNo.TextLength != 8)
            {
                txtStudentNo.BackColor = Color.Red;
                txtStudentNo.ForeColor = Color.White;
            }
            else
            {
                txtStudentNo.BackColor = Color.White;
                txtStudentNo.ForeColor = Color.Black;
            }
        }

        // MiniMax Algoritması and Best Computer Move
        class Move
        {
            public int row, col;
        };

        static char player = 'o', opponent = 'x';

        static Boolean isMovesLeft(char[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == '_')
                        return true;
            return false;
        }

        static int evaluate(char[,] v)
        {

            for (int row = 0; row < 3; row++)
            {
                if (v[row, 0] == v[row, 1] &&
                    v[row, 1] == v[row, 2])
                {
                    if (v[row, 0] == player)
                        return +10;
                    else if (v[row, 0] == opponent)
                        return -10;
                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (v[0, col] == v[1, col] &&
                    v[1, col] == v[2, col])
                {
                    if (v[0, col] == player)
                        return +10;

                    else if (v[0, col] == opponent)
                        return -10;
                }
            }

            if (v[0, 0] == v[1, 1] && v[1, 1] == v[2, 2])
            {
                if (v[0, 0] == player)
                    return +10;
                else if (v[0, 0] == opponent)
                    return -10;
            }

            if (v[0, 2] == v[1, 1] && v[1, 1] == v[2, 0])
            {
                if (v[0, 2] == player)
                    return +10;
                else if (v[0, 2] == opponent)
                    return -10;
            }

            return 0;
        }

        static int minimax(char[,] board, int depth, Boolean isMax)
        {
            int score = evaluate(board);

            if (score == 10)
                return score;

            if (score == -10)
                return score;

            if (isMovesLeft(board) == false)
                return 0;

            if (isMax)
            {
                int best = -1000;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '_')
                        {
                            board[i, j] = player;

                            best = Math.Max(best, minimax(board, depth + 1, !isMax));

                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }

            else
            {
                int best = 1000;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '_')
                        {
                            board[i, j] = opponent;

                            best = Math.Min(best, minimax(board, depth + 1, !isMax));

                            board[i, j] = '_';
                        }
                    }
                }
                return best;
            }
        }

        static Move findBestMove(char[,] board)
        {
            int bestVal = -1000;
            Move bestMove = new Move();
            bestMove.row = -1;
            bestMove.col = -1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '_')
                    {
                        board[i, j] = player;

                        int moveVal = minimax(board, 0, false);

                        board[i, j] = '_';

                        if (moveVal > bestVal)
                        {
                            bestMove.row = i;
                            bestMove.col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }

            return bestMove;
        }




        // Kazanan var mı kontrol eder
        private char IsWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                // Row kontrol
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    return board[i, 0];
                }
                // Column kontrol
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[0, i] == board[2, i])
                {
                    return board[0, i];
                }
            }

            // Diagonal kontrol
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                return board[0, 0];
            }
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                return board[0, 2];
            }

            // Kazanan yoksa
            return ' ';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = 0, y = 0;

            switch (btn.Name) // buttonu belirleme
            {
                case "button1": x = 0; y = 0; break;
                case "button2": x = 0; y = 1; break;
                case "button3": x = 0; y = 2; break;
                case "button4": x = 1; y = 0; break;
                case "button5": x = 1; y = 1; break;
                case "button6": x = 1; y = 2; break;
                case "button7": x = 2; y = 0; break;
                case "button8": x = 2; y = 1; break;
                case "button9": x = 2; y = 2; break;
            }

            if (board[x, y] == '_')//button bos ise x ile doldurur
            {
                board[x, y] = 'x';
                buttons[y + (3 * x)].Image = X;
                values[y + (3 * x)] = 1;
                count++;
            }
            Move bestMove = new Move();
            bestMove = findBestMove(board); // Computer best moove belirlenir
            if (IsWinner() == 'x')// Player kazandı mı kontrol eder
            {
                lblSkor.Text = "Skor: " + tst.testFuncXoX(txtStudentNo.Text, "x", Char.ToString(board[0, 0]), Char.ToString(board[0, 1]), Char.ToString(board[0, 2]),
                                                                                  Char.ToString(board[1, 0]), Char.ToString(board[1, 1]), Char.ToString(board[1, 2]),
                                                                                  Char.ToString(board[2, 0]), Char.ToString(board[2, 1]), Char.ToString(board[2, 2]));
                lblSkor.ForeColor = Color.Green;
                lblOutput.ForeColor = Color.Green;
                lblOutput.Text = "YOU WIN :)";
                foreach (var button in buttons) { button.Enabled = false; }
            }
            if (count != 9)
            {
                board[bestMove.row, bestMove.col] = 'o';
                buttons[bestMove.col + (3 * bestMove.row)].Image = O;
                count++;
            }
            if (IsWinner() == 'o')// Computer kazandı mı kontrol eder
            {
                lblSkor.Text = "Skor: " + tst.testFuncXoX(txtStudentNo.Text, "o", Char.ToString(board[0, 0]), Char.ToString(board[0, 1]), Char.ToString(board[0, 2]),
                                                                                  Char.ToString(board[1, 0]), Char.ToString(board[1, 1]), Char.ToString(board[1, 2]),
                                                                                  Char.ToString(board[2, 0]), Char.ToString(board[2, 1]), Char.ToString(board[2, 2]));
                lblSkor.ForeColor = Color.Red;
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "YOU LOSE!";
                foreach (var button in buttons) { button.Enabled = false; }
            }
            if (IsWinner() == ' ' && count == 9) // Hamle kalmadıgı icin berabere mi kontrol eder
            {
                lblSkor.Text = "Skor: " + tst.testFuncXoX(txtStudentNo.Text, "draw", Char.ToString(board[0, 0]), Char.ToString(board[0, 1]), Char.ToString(board[0, 2]),
                                                                                     Char.ToString(board[1, 0]), Char.ToString(board[1, 1]), Char.ToString(board[1, 2]),
                                                                                     Char.ToString(board[2, 0]), Char.ToString(board[2, 1]), Char.ToString(board[2, 2]));
                lblSkor.ForeColor = Color.Blue;
                lblOutput.ForeColor = Color.Blue;
                lblOutput.Text = "DRAW!";
                foreach (var button in buttons) { button.Enabled = false; }
            }
        }


    }
}
