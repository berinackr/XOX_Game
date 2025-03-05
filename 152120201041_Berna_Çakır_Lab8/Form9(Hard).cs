using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class frm_hard : Form
    {
        public frm_hard()
        {
            InitializeComponent();
        }

        Image X;
        Image O;
        int count = 0; // oyun sayısını kontrol eder
        Button[] buttons; // button dizisi
        char[,] board = { { '_', '_', '_' , '_' , '_'},
                          { '_', '_', '_' , '_' , '_'},
                          { '_', '_', '_' , '_' , '_'},
                          { '_', '_', '_' , '_' , '_'},
                          { '_', '_', '_' , '_' , '_'}};// button durumunu tutan dizi ('_' = boş , 'x' = X, 'o' = O)
        int[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //(0 = boş , 1 = X, 2 = O)

        private void frm_hard_Load(object sender, EventArgs e)
        {
            buttons = new Button[] { button1, button2, button3, button4,button5,
                                     button6, button7, button8, button9, button10,
                                     button11, button12, button13, button14, button15,
                                     button16, button17, button18, button19, button20,
                                     button21, button22, button23, button24, button25, };
            Reset();

            X = Image.FromFile(Application.StartupPath + @"../../../images/LetterX.png"); // X gorseli
            O = Image.FromFile(Application.StartupPath + @"../../../images/LetterO.png"); // O gorseli
        }

        private void Reset()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = '_';
                    values[j + (5 * i)] = 0;
                    buttons[j + (5 * i)].Image = null;
                    buttons[j + (5 * i)].Enabled = true;
                }
            }

            count = 0;
            lblOutput.Text = " ";
            lblSkor.ForeColor = Color.Black;
        }

        class Move
        {
            public int row, col;
        };

        static char player = 'o', opponent = 'x';

        static Boolean isMovesLeft(char[,] board)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (board[i, j] == '_')
                        return true;
            return false;
        }

        static int evaluate(char[,] v)
        {

            for (int row = 0; row < 5; row++)
            {
                if (v[row, 0] == v[row, 1] && v[row, 1] == v[row, 2] && v[row, 2] == v[row, 3] && v[row, 3] == v[row, 4])
                {
                    if (v[row, 0] == player)
                        return +10;
                    else if (v[row, 0] == opponent)
                        return -10;
                }
            }

            for (int col = 0; col < 5; col++)
            {
                if (v[0, col] == v[1, col] && v[1, col] == v[2, col] && v[2, col] == v[3, col] && v[3, col] == v[4, col])
                {
                    if (v[0, col] == player)
                        return +10;

                    else if (v[0, col] == opponent)
                        return -10;
                }
            }

            if (v[0, 0] == v[1, 1] && v[1, 1] == v[2, 2] && v[2, 2] == v[3, 3] && v[3, 3] == v[4, 4])
            {
                if (v[0, 0] == player)
                    return +10;
                else if (v[0, 0] == opponent)
                    return -10;
            }

            if (v[0, 4] == v[1, 3] && v[1, 3] == v[2, 2] && v[2, 2] == v[3, 1] && v[3, 1] == v[4, 0])
            {
                if (v[0, 4] == player)
                    return +10;
                else if (v[0, 4] == opponent)
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

            if (isMovesLeft(board) == false || depth >= 3)
                return 0;

            if (isMax)
            {
                int best = -1000;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
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

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
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

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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
            for (int i = 0; i < 5; i++)
            {
                // Row kontrol
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0] == board[i, 3] && board[i, 0] == board[i, 4])
                {
                    return board[i, 0];
                }
                // Column kontrol
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i] == board[3, i] && board[0, i] == board[4, i])
                {
                    return board[0, i];
                }
            }

            // Diagonal kontrol
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] == board[3, 3] && board[0, 0] == board[4, 4])
            {
                return board[0, 0];
            }
            if (board[0, 4] != ' ' && board[0, 4] == board[1, 3] && board[0, 4] == board[2, 2] && board[0, 4] == board[3, 1] && board[0, 4] == board[4, 0])
            {
                return board[0, 4];
            }

            // Kazanan yoksa
            return ' ';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_difficultyLevel frmback = new frm_difficultyLevel();
            frmback.Show();
            this.Hide();
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
                case "button4": x = 0; y = 3; break;
                case "button5": x = 0; y = 4; break;
                case "button6": x = 1; y = 0; break;
                case "button7": x = 1; y = 1; break;
                case "button8": x = 1; y = 2; break;
                case "button9": x = 1; y = 3; break;
                case "button10": x = 1; y = 4; break;
                case "button11": x = 2; y = 0; break;
                case "button12": x = 2; y = 1; break;
                case "button13": x = 2; y = 2; break;
                case "button14": x = 2; y = 3; break;
                case "button15": x = 2; y = 4; break;
                case "button16": x = 3; y = 0; break;
                case "button17": x = 3; y = 1; break;
                case "button18": x = 3; y = 2; break;
                case "button19": x = 3; y = 3; break;
                case "button20": x = 3; y = 4; break;
                case "button21": x = 4; y = 0; break;
                case "button22": x = 4; y = 1; break;
                case "button23": x = 4; y = 2; break;
                case "button24": x = 4; y = 3; break;
                case "button25": x = 4; y = 4; break;
            }

            if (board[x, y] == '_')//button bos ise x ile doldurur
            {
                board[x, y] = 'x';
                buttons[y + (5 * x)].Image = X;
                values[y + (5 * x)] = 1;
                count++;
            }
            Move bestMove = new Move();
            bestMove = findBestMove(board); // Computer best moove belirlenir
            if (IsWinner() == 'x')// Player kazandı mı kontrol eder
            {
                lblSkor.ForeColor = Color.Green;
                lblOutput.ForeColor = Color.Green;
                lblOutput.Text = "YOU WIN :)";
                foreach (var button in buttons) { button.Enabled = false; }
            }
            if (count != 25)
            {
                board[bestMove.row, bestMove.col] = 'o';
                buttons[bestMove.col + (5 * bestMove.row)].Image = O;
                count++;
            }
            if (IsWinner() == 'o')// Computer kazandı mı kontrol eder
            {
               lblSkor.ForeColor = Color.Red;
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "YOU LOSE!";
                foreach (var button in buttons) { button.Enabled = false; }
            }
            if (IsWinner() == ' ' && count == 25) // Hamle kalmadıgı icin berabere mi kontrol eder
            {
                lblSkor.ForeColor = Color.Blue;
                lblOutput.ForeColor = Color.Blue;
                lblOutput.Text = "DRAW!";
                foreach (var button in buttons) { button.Enabled = false; }
            }
        }

    }
}
