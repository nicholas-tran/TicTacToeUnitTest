using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Tran_CIS3374_Lab06_TicTacToe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tran_CIS3374_Lab06_TicTacToe.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void AssertNineActiveFields()
        {
            //arrange
            int expectedBoardSize = 9;
            Tran_CIS3374_Lab06_TicTacToe.Board board = new Tran_CIS3374_Lab06_TicTacToe.Board();
            //act
            board.CreateBoard();
            //assert
            Assert.AreEqual(expectedBoardSize, board.ticTacToeBoard.Length);
        }

        [TestMethod()]
        public void AssertCurrentPlayerIsX()
        {
            //arrange
            Tran_CIS3374_Lab06_TicTacToe.Board board = new Tran_CIS3374_Lab06_TicTacToe.Board();
            int expectedCurrentPlayer = 1;
            //act
            board.CreateBoard();
            //assert
            Assert.AreEqual(expectedCurrentPlayer, board.CurrentPlayer());
        }

        [TestMethod()]
        public void AssertCurrentPlayerIsO()
        {
            //arrange
            Tran_CIS3374_Lab06_TicTacToe.Board board = new Tran_CIS3374_Lab06_TicTacToe.Board();
            int expectedCurrentPlayer = 2;
            //act
            board.CreateBoard();
            board.ChangePlayer();
            //assert
            Assert.AreEqual(expectedCurrentPlayer, board.CurrentPlayer());
        }

        [TestMethod()]
        public void AssertCurrentPlayerPlacesX()
        {
            //arrange
            Tran_CIS3374_Lab06_TicTacToe.Board board = new Tran_CIS3374_Lab06_TicTacToe.Board();
            int expectedPlacementValue = 1;
            //act
            board.CreateBoard();
            board.MakeMove(5);
            //assert
            Assert.AreEqual(expectedPlacementValue, board.SpaceInUse(5));
        }

        [TestMethod()]
        public void AssertCurrentPlayerPlacesO()
        {
            //arrange
            Tran_CIS3374_Lab06_TicTacToe.Board board = new Tran_CIS3374_Lab06_TicTacToe.Board();
            int expectedPlacementValue = 2;
            //act
            board.CreateBoard();
            board.ChangePlayer();
            board.MakeMove(5);
            //assert
            Assert.AreEqual(expectedPlacementValue, board.SpaceInUse(5));
        }

        [TestMethod()]
        public void AssertPlacementInUnoccupied()
        {
            //arrange
            Tran_CIS3374_Lab06_TicTacToe.Board board = new Tran_CIS3374_Lab06_TicTacToe.Board();
            bool expectedUnoccupiedSpace = true;
            //act
            board.CreateBoard();
            //assert
            Assert.AreEqual(expectedUnoccupiedSpace, board.MakeMove(5));
        }
    }

}

