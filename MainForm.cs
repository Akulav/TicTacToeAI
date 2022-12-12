using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToeAI
{


    public partial class MainForm : Form
    {
        private char[,]board = 
            {{'_', '_', '_' },
            { '_', '_', '_' },
            { '_', '_', '_' }};

        public int player = 0;
        private int index = 0;
        private bool win = false;

        IDictionary<Button, int[]> buttonLocation = new Dictionary<Button, int[]>();
        IDictionary<int[], Button> buttonLocationReversed = new Dictionary<int[], Button>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            player = 0;
            changePlayerLbl();
        }

        private void OBtn_Click(object sender, EventArgs e)
        {
            player = 1;
            changePlayerLbl();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            changePlayerLbl();
            loadButtons();  
        }

        private void loadButtons()
        {
            buttonLocation.Add(button1,new[] {0,0});
            buttonLocation.Add(button2, new[] { 0, 1 });
            buttonLocation.Add(button3, new[] { 0, 2 });
            buttonLocation.Add(button4, new[] { 1, 0 });
            buttonLocation.Add(button5, new[] { 1, 1 });
            buttonLocation.Add(button6, new[] { 1, 2 });
            buttonLocation.Add(button7, new[] { 2, 0 });
            buttonLocation.Add(button8, new[] { 2, 1 });
            buttonLocation.Add(button9, new[] { 2, 2 });
        }

        private void changePlayerLbl()
        {
            if (player == 0) { PlayerLbl.Text = "Playing as X"; }
            else { PlayerLbl.Text = "Playing as O"; }
        }

        private void board_MouseClick(object sender, MouseEventArgs e)
        {
            string Name = ((Button)sender).Name;
            int[] position = buttonLocation[(Button)Controls.Find(Name, true)[0]];
            var currentButton = sender as Button;


            if (player == 0)
            {
                board[position[0],position[1]] = 'x';
                currentButton.Text = "x";
                currentButton.Enabled = false;
                checkWinner();
                if (index < 8)
                {
                    Minimax.player = 'x';
                    Minimax.opponent = 'o';
                    Minimax.Move best = Minimax.findBestMove(board);
                    board[best.row, best.col] = 'o';
                    var Btn = (Button)Controls.Find("button" + getIndex(new[] { best.row, best.col }), true)[0];
                    Btn.Text = "o";
                    Btn.Enabled = false;
                    index += 2;
                    checkWinner();
                }
            }
            else
            {
                board[position[0], position[1]] = 'o';
                currentButton.Text = "o";
                currentButton.Enabled = false;
                checkWinner();
                if (index < 8)
                {
                    Minimax.player = 'o';
                    Minimax.opponent = 'x';
                    Minimax.Move best = Minimax.findBestMove(board);
                    board[best.row, best.col] = 'x';
                    var Btn = (Button)Controls.Find("button" + getIndex(new[] { best.row, best.col }), true)[0];
                    Btn.Text = "x";
                    Btn.Enabled = false;
                    index += 2;
                    checkWinner();
                }
            }
        }

        private int getIndex(int[] pos)
        {
            if (pos[0] == 0) { return pos[1]+1; }
            else if (pos[0] == 1) { return (pos[0] * 3) + pos[1]+1; }
            else if (pos[0] == 2) { return (pos[0] * 3) + pos[1] + 1; }

            else return 0;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void checkWinner()
        {
            if (board[0, 0] == board[0,1] && board[0, 0] == board[0, 2] && board[0,2]!='_')
            {
                winLbl.Text = "Winner is: " + board[0, 0].ToString();
                win = true;
            }

            else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2] && board[1, 0] != '_')
            {
                winLbl.Text = "Winner is: " + board[1, 0].ToString();
                win = true;
            }

            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] && board[2, 0] != '_')
            {
                winLbl.Text = "Winner is: " + board[2,0].ToString();
                win = true;
            }

            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != '_')
            {
                winLbl.Text = "Winner is: " + board[0, 0].ToString();
                win = true;
            }

            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[1, 1] != '_')
            {
                winLbl.Text = "Winner is: " + board[0, 1].ToString();
                win = true;
            }

            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != '_')
            {
                winLbl.Text = "Winner is: " + board[0, 2].ToString();
                win = true;
            }

            else if (board[0,0] == board[1,1] && board[1, 1] == board[2, 2] && board[0, 0] != '_')
            {
                winLbl.Text = "Winner is: " + board[0, 0].ToString();
                win = true;
            }

            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != '_')
            {
                winLbl.Text = "Winner is: " + board[0,2].ToString();
                win = true;
            }

            if (win)
            {
                foreach (var item in buttonLocation)
                {
                    item.Key.Enabled = false;
                }
            }

        }
    }
}