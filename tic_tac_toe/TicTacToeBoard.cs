using System.Collections.Generic;

namespace tic_tac_toe
{
  /// <summary>
  /// Contains all of the functions and logic needed for the game of TicTacToe
  /// </summary>
  class TicTacToeBoard : GameBoard
  {
    public TicTacToeBoard()
    {
      squares = new Player[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
    }

    public override int Size { get { return 9; } }

    public override Player this[int x, int y]
    {
      get
      {
        return squares[x, y];
      }

      set
      {
        squares[x, y] = value;
      }
    }

    public override bool IsFull
    {
      get
      {
        foreach (Player i in squares)
          if (i == Player.Open) { return false; }
        return true;
      }
    }

    public override List<Space> OpenSquares
    {
      get
      {
        List<Space> openSquares = new List<Space>();

        for (int x = 0; x <= 2; x++)
          for (int y = 0; y <= 2; y++)
            if (squares[x, y] == Player.Open)
              openSquares.Add(new Space(x, y));

        return openSquares;
      }
    }

    public override Player Winner
    {
      get
      {
        int count = 0;

        //columns
        for (int x = 0; x < 3; x++)
        {
          count = 0;

          for (int y = 0; y < 3; y++)
            count += (int)squares[x, y];

          if (count == 3)
            return Player.X;
          if (count == -3)
            return Player.O;
        }

        //rows
        for (int x = 0; x < 3; x++)
        {
          count = 0;

          for (int y = 0; y < 3; y++)
            count += (int)squares[y, x];

          if (count == 3)
            return Player.X;
          if (count == -3)
            return Player.O;
        }

        //diagnols right to left
        count = 0;
        count += (int)squares[0, 0];
        count += (int)squares[1, 1];
        count += (int)squares[2, 2];
        if (count == 3)
          return Player.X;
        if (count == -3)
          return Player.O;

        //diagnols left to right
        count = 0;
        count += (int)squares[0, 2];
        count += (int)squares[1, 1];
        count += (int)squares[2, 0];
        if (count == 3)
          return Player.X;
        if (count == -3)
          return Player.O;

        return Player.Open;
      }
    }

    public override GameBoard Clone()
    {
      GameBoard b = new TicTacToeBoard();
      b.squares = (Player[,])this.squares.Clone();
      return b;
    }
  }
}
