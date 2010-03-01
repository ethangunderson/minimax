using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
  public partial class TicTacToeGUI : Form
  {
    GameBoard gb;

    public TicTacToeGUI()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      gb = new TicTacToeBoard();
      LoadBoard();
      button1.Enabled = true;
      button2.Enabled = true;
      button3.Enabled = true;
      button4.Enabled = true;
      button5.Enabled = true;
      button6.Enabled = true;
      button7.Enabled = true;
      button8.Enabled = true;
      button9.Enabled = true;

    }

    /// <summary>
    /// Dirty, but it reloads the board display to account for all moves played so far.
    /// </summary>
    private void LoadBoard()
    {
      if (gb[0, 0] == Player.Open)
        button1.Text = "";
      else
      {
        button1.Text = gb[0, 0].ToString();
        button1.Enabled = false;
      }

      if (gb[0, 1] == Player.Open)
        button2.Text = "";
      else
      {
        button2.Text = gb[0, 1].ToString();
        button2.Enabled = false;
      }

      if (gb[0, 2] == Player.Open)
        button3.Text = "";
      else
      {
        button3.Text = gb[0, 2].ToString();
        button3.Enabled = false;
      }

      if (gb[1, 0] == Player.Open)
        button4.Text = "";
      else
      {
        button4.Text = gb[1, 0].ToString();
        button4.Enabled = false;
      }

      if (gb[1, 1] == Player.Open)
        button5.Text = "";
      else
      {
        button5.Text = gb[1, 1].ToString();
        button5.Enabled = false;
      }

      if (gb[1, 2] == Player.Open)
        button6.Text = "";
      else
      {
        button6.Text = gb[1, 2].ToString();
        button6.Enabled = false;
      }

      if (gb[2, 0] == Player.Open)
        button7.Text = "";
      else
      {
        button7.Text = gb[2, 0].ToString();
        button7.Enabled = false;
      }

      if (gb[2, 1] == Player.Open)
        button8.Text = "";
      else
      {
        button8.Text = gb[2, 1].ToString();
        button8.Enabled = false;
      }

      if (gb[2, 2] == Player.Open)
        button9.Text = "";
      else
      {
        button9.Text = gb[2, 2].ToString();
        button9.Enabled = false;
      }
    }

    /// <summary>
    /// Button click event
    /// </summary>
    private void button_click(object sender, EventArgs e)
    {
      Space s = (Space)sender;

      gb[s.X, s.Y] = Player.O;
      LoadBoard();
      if (CheckForWinners())
        Form1_Load(null, new EventArgs());  //Winner was found, reload the game

      if (gb.OpenSquares.Count == gb.Size) //if all spaces are open, randomly pick one for excitement
      {
        Random r = new Random();
        s = new Space(r.Next(0, 3), r.Next(0, 3));
      }
      else
        s = AI.GetBestMove(gb, Player.X);

      gb[s.X, s.Y] = Player.X;
      LoadBoard();
      if (CheckForWinners())
        Form1_Load(null, new EventArgs());  //Winner was found, reload the game

    }

    /// <summary>
    /// Checks the current board for a winner and acts appropriately
    /// </summary>
    /// <returns></returns>
    public bool CheckForWinners()
    {
      Player? p = gb.Winner;

      if (p == Player.X)
      {
        MessageBox.Show("Computer Wins");
        return true;
      }
      else if (p == Player.O)
      {
        MessageBox.Show("You Win!");
        return true;
      }
      else if (gb.IsFull)
      {
        MessageBox.Show("Cat's Game");
        return true;
      }
      return false;
    }
  }
}
