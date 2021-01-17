using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfCSharp
{
    class Board
    {
        private int size;
        private bool[,] board;
        Random randomGen = new Random();


        public Board(int size)
        {
            this.size = size;
            this.board = new bool[size+2, size+2];
            for (int i = 0; i < size + 2; i++)
            {
                for (int j = 0; j < size + 2; j++)
                {
                    this.board[i, j] = false;
                }
            }
        }

        private int getNeighbourNumber(int x, int y)
        {
            int neighbourCounter = 0;

            if (this.board[x - 1, y - 1])
                neighbourCounter++;
            if (this.board[x - 1, y])
                neighbourCounter++;
            if (this.board[x - 1, y + 1])
                neighbourCounter++;
            if (this.board[x, y - 1])
                neighbourCounter++;
            if (this.board[x, y + 1])
                neighbourCounter++;
            if (this.board[x + 1, y - 1])
                neighbourCounter++;
            if (this.board[x + 1, y])
                neighbourCounter++;
            if (this.board[x + 1, y + 1])
                neighbourCounter++;

            return neighbourCounter;
        }


        public void nextGeneration()
        {
            bool[,] tempBoard = new bool[this.size+2, this.size+2];

            for(int i = 1; i <= this.size; i++)
            {
                for(int j = 1; j <= this.size; j++)
                {
                    int neighboursNr = this.getNeighbourNumber(i, j);

                    if (this.board[i, j])
                    {
                        if (neighboursNr == 2 || neighboursNr == 3)
                        {
                            tempBoard[i, j] = true;
                        }
                        else
                        {
                            tempBoard[i, j] = false;
                        }
                    }
                    else
                    {
                        if (neighboursNr == 3)
                        {
                            tempBoard[i, j] = true;
                        }
                        else{
                            tempBoard[i, j] = false;
                        }
                    }
                }
            }

            this.board = (bool[,]) tempBoard.Clone();
        }

        
        public bool[,] getBoard()
        {
            return this.board;
        }

        public int getSize()
        {
            return this.size;
        }

        public void generateRandom()
        {
            for (int i = 1; i <= this.size; i++)
            {
                for (int j = 1; j <= this.size; j++)
                {
                    this.board[i,j] = this.randomGen.Next(2) == 0;
                }
            }
        }

        public void addCell(int x, int y)
        {
            this.board[x, y] = true;
        }

        public void removeCell(int x, int y)
        {
            this.board[x, y] = false;
        }

        public bool getCell(int x, int y)
        {
            return this.board[x, y];
        }

        public String asStringMatrix()
        {
            StringBuilder builder = new StringBuilder();

            for(int i = 1; i <= this.size; i++)
            {
                for(int j = 1; j <= this.size; j++)
                {
                    if (this.board[i, j])
                    {
                        builder.Append("o");
                    }
                    else
                    {
                        builder.Append(" ");
                    }
                }
                builder.Append("\n");
            }

            return builder.ToString();
        }
    }
}
