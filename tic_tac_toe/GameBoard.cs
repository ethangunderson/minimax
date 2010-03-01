using System.Collections.Generic;

namespace tic_tac_toe
{
  public enum Player
  {
    X = 1,
    O = -1,
    Open = 0,
  }

  /// <summary>
  /// Abstract class for creating new game boards, contains all of the logic needed for the AI to play the game.
  /// </summary>
  public abstract class GameBoard
  {
    /// <summary>
    /// Array that contains all of the spaces on the board.
    /// </summary>
    public Player[,] squares;

    /// <summary>
    /// Gets or sets a space on the board.
    /// </summary>
    public abstract Player this[int x, int y] { get; set; }

    /// <summary>
    /// Determines if all spaces on the board are full.
    /// </summary>
    public abstract bool IsFull { get; }

    /// <summary>
    /// Gets the maximum size of the board.
    /// </summary>
    public abstract int Size { get; }

    /// <summary>
    /// List of the open spaces available on the current board.
    /// </summary>
    public abstract List<Space> OpenSquares { get; }

    /// <summary>
    /// Determines if there is a winner on the current board.
    /// </summary>
    public abstract Player Winner { get; }

    /// <summary>
    /// Makes a deap copy of the current board
    /// </summary>
    public abstract GameBoard Clone();
  }

  /// <summary>
  /// Describes a space on the board.
  /// </summary>
  public struct Space
  {
    public int X;
    public int Y;
    public double Rank;

    public Space(int x, int y)
    {
      this.X = x;
      this.Y = y;
      Rank = 0;
    }
  }
}
