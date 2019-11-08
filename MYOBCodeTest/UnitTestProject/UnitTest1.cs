using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLogic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHorizontalWin()
        {
            Char[,] board = { { 'X', 'X', 'X'},
                              { '.', '.', '.'},
                              { '.', '.', '.'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.checkWinHorizontal(), true);
        }

        [TestMethod]
        public void TestVerticalWin()
        {
            Char[,] board = { { '.', '.', 'O'},
                              { '.', '.', 'O'},
                              { '.', '.', 'O'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.checkWinVertical(), true);
        }

        [TestMethod]
        public void TestDiagonalWinTopLeftToBottomRight()
        {
            Char[,] board = { { 'X', '.', '.'},
                              { '.', 'X', '.'},
                              { '.', '.', 'X'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.checkWinDiagonal(), true);
        }

        [TestMethod]
        public void TestDiagonalWinBottomLeftToTopRight()
        {
            Char[,] board = { { '.', '.', 'O'},
                              { '.', 'O', '.'},
                              { 'O', '.', '.'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.checkWinDiagonal(), true);
        }

        [TestMethod]
        public void TestDraw()
        {
            Char[,] board = { { 'O', 'X', 'O'},
                              { 'X', 'X', 'O'},
                              { 'O', 'O', 'X'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.checkDraw(), true);
        }

        [TestMethod]
        public void TestInvalidMove()
        {
            Char[,] board = { { 'O', 'X', 'O'},
                              { 'X', 'X', 'O'},
                              { 'O', 'O', 'X'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.takeTurn(1,1,'X'), false);
        }

        [TestMethod]
        public void TestValidMove()
        {
            Char[,] board = { { '.', 'X', 'O'},
                              { 'X', 'X', 'O'},
                              { 'O', 'O', 'X'}};
            TicTacToe game = new TicTacToe(board);
            Assert.AreEqual(game.takeTurn(1, 1, 'X'), true);
        }
    }
}
