using System.Windows.Forms;

namespace _9game
{
    public partial class Form1 : Form
    {
        int[] perfectBoard = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        int[] board = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        int score = 0;
        bool gameStarted = false;

        // Create an empty scoreboard list
        List<Score> scoreboard = new List<Score>();

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void randomizeBoard()
        {
            //it just works
            for (int i = 0; i < 100; i++) switchPlaces(r.Next(9), r.Next(9));
            setScore(0);
        }
        private void switchPlaces(int index1, int index2)
        {
            /*
            int index2Val = board[index2];
            board[index2] = board[index1];
            board[index1] = index2Val;
            */

            //"tuple"
            (board[index1], board[index2]) = (board[index2], board[index1]);
            setScore(score + 1);

            //showboard() is not here because we use this function multiple times to shuffle the board.
        }

        private void setScore(int val)
        {
            score = val;
            label_Score.Text = "" + score;
        }

        private void showBoard()
        {
            //uuuuhhhhh.......
            label1.Text = "" + board[0];
            label2.Text = "" + board[1];
            label3.Text = "" + board[2];
            label4.Text = "" + board[3];
            label5.Text = "" + board[4];
            label6.Text = "" + board[5];
            label7.Text = "" + board[6];
            label8.Text = "" + board[7];
            label9.Text = "" + board[8];
            label1.ForeColor = board[0] == 0 ? Color.Black : Color.White;
            label2.ForeColor = board[1] == 0 ? Color.Black : Color.White;
            label3.ForeColor = board[2] == 0 ? Color.Black : Color.White;
            label4.ForeColor = board[3] == 0 ? Color.Black : Color.White;
            label5.ForeColor = board[4] == 0 ? Color.Black : Color.White;
            label6.ForeColor = board[5] == 0 ? Color.Black : Color.White;
            label7.ForeColor = board[6] == 0 ? Color.Black : Color.White;
            label8.ForeColor = board[7] == 0 ? Color.Black : Color.White;
            label9.ForeColor = board[8] == 0 ? Color.Black : Color.White;
        }

        private void isBoardFinished()
        {
            //if the board is finished
            bool finished = board.SequenceEqual(perfectBoard);
            if (finished)
            {
                gameStarted = false;
                scoreboard.Add(new Score(score, textBox_Nickname.Text));
                MessageBox.Show($"Cgonrattsgdj! You won in {score} moves!");
                stopTheGame();
            }
        }
        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_Nickname.Text.Trim().Replace(" ", "").Length >= 3)
            {
                startTheGame();
            }
            else
            {
                MessageBox.Show("Invalid nickname. minimum 3 characters without white spaces");
            }
        }

        private void startTheGame()
        {
            setScore(0);
            randomizeBoard();
            showBoard();
            //dont disable the textbox or the form wont have anything to receive keypresses
            textBox_Nickname.ReadOnly = true;
            gameStarted = true;
            stopTheGameToolStripMenuItem.Visible = true;
            cheatNowToolStripMenuItem.Visible = true;
            aboutToolStripMenuItem.Visible = false;
            scoreboardToolStripMenuItem.Visible = false;
            startANewGameToolStripMenuItem.Visible = false;
        }
        private void stopTheGame()
        {
            //dont disable the textbox or the form wont have anything to receive keypresses
            for (int i = 0; i < 9; i++) board[i] = perfectBoard[i];
            showBoard();
            setScore(0);
            textBox_Nickname.ReadOnly = false;
            gameStarted = false;
            stopTheGameToolStripMenuItem.Visible = false;
            cheatNowToolStripMenuItem.Visible = false;
            aboutToolStripMenuItem.Visible = true;
            scoreboardToolStripMenuItem.Visible = true;
            startANewGameToolStripMenuItem.Visible = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (gameStarted)
            {
                int playerIndex = Array.IndexOf(board, 0);
                //up and down key behvaiour is reversed here
                switch (e.KeyChar)
                {
                    case 'w':
                        if (playerIndex > 2) switchPlaces(playerIndex, playerIndex - 3);
                        showBoard();
                        isBoardFinished();
                        break;
                    case 'a':
                        if (playerIndex % 3 > 0) switchPlaces(playerIndex, playerIndex - 1);
                        showBoard();
                        isBoardFinished();
                        break;
                    case 's':
                        if (playerIndex < 6) switchPlaces(playerIndex, playerIndex + 3);
                        showBoard();
                        isBoardFinished();
                        break;
                    case 'd':
                        if (playerIndex % 3 < 2) switchPlaces(playerIndex, playerIndex + 1);
                        showBoard();
                        isBoardFinished();
                        break;
                }
            }
        }

        private void stopTheGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopTheGame();
        }

        private void cheatNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++) board[i] = perfectBoard[i];
            switchPlaces(8, 7);
            showBoard();
        }

        private void scoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scoreboard.Sort((a, b) => a.Value.CompareTo(b.Value));
            string scoreboardText = string.Join(Environment.NewLine, scoreboard.Select(d => d.Name + " - " + d.Value));

            MessageBox.Show(scoreboardText, "Scoreboard");
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void showCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v1: I forgor");
        }
    }

    public class Score
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public Score(int value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}