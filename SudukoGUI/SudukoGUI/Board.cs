﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudukoGUI
{
    class Board
    {
        public int[,] PlayerBoard { get; set; }
        public int BoardSize { get; private set; }
        public char BoardStyle;

        public void setBoard()
        {

            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    PlayerBoard[row, col] = 0;

                }
            }
        }

        public override string ToString()
        {

            string output = "";
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    output += $" {PlayerBoard[row, col]} ";
                }
                output += "\n";
            }

            return output;
        }

        public Board(int size, char boardStyle)
        {
            BoardSize = size;
            BoardStyle = boardStyle;
            PlayerBoard = new int[size, size];
            setBoard();
        }
    }
}
