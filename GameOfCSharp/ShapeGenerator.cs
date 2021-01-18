using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfCSharp
{
    class ShapeGenerator
    {
        public ShapeGenerator()
        {

        }

        //Clears

        public void clear3x3(Board board, int x,int y)
        {
            if (x > (board.getSize() - 1) || x < 2 || y < 2 || y > (board.getSize() - 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = false;

            cellBoard[x, y - 1] = false;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = false;

            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = false;
            cellBoard[x + 1, y + 1] = false;
        }

        public void clear5x5(Board board, int x, int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x-2, y-2] = false;
            cellBoard[x-2, y-1] = false;
            cellBoard[x-2, y] = false;
            cellBoard[x-2, y+1] = false;
            cellBoard[x-2, y+2] = false;

            cellBoard[x-1, y-2] = false;
            cellBoard[x-1, y-1] = false;
            cellBoard[x-1, y] = false;
            cellBoard[x-1, y+1] = false;
            cellBoard[x-1, y+2] = false;

            cellBoard[x, y-2] = false;
            cellBoard[x, y-1] = false;
            cellBoard[x, y] = false;
            cellBoard[x, y+1] = false;
            cellBoard[x, y+2] = false;

            cellBoard[x+1, y-2] = false;
            cellBoard[x+1, y-1] = false;
            cellBoard[x+1, y] = false;
            cellBoard[x+1, y+1] = false;
            cellBoard[x+1, y+2] = false;

            cellBoard[x+2, y-2] = false;
            cellBoard[x+2, y-1] = false;
            cellBoard[x+2, y] = false;
            cellBoard[x+2, y+1] = false;
            cellBoard[x+2, y+2] = false;
        }

        public void clear7x7(Board board, int x, int y)
        {
            if (x > (board.getSize() - 3) || x < 4 || y < 4 || y > (board.getSize() - 3))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -3; i <= 3; i++)
            {
                for(int j = -3; j <= 3; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear9x9(Board board, int x, int y)
        {
            if (x > (board.getSize() - 4) || x < 5 || y < 5 || y > (board.getSize() - 4))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -4; i <= 4; i++)
            {
                for (int j = -4; j <= 4; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }

        }

        public void clear11x11(Board board, int x, int y)
        {
            if (x > (board.getSize() - 5) || x < 6 || y < 6 || y > (board.getSize() - 5))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -5; i <= 5; i++)
            {
                for (int j = -5; j <= 5; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }

        }

        public void clear13x13(Board board, int x, int y)
        {
            if (x > (board.getSize() - 6) || x < 7 || y < 7 || y > (board.getSize() - 6))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -6; i <= 6; i++)
            {
                for (int j = -6; j <= 6; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear15x15(Board board, int x, int y)
        {
            if (x > (board.getSize() - 7) || x < 8 || y < 8 || y > (board.getSize() - 7))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -7; i <= 7; i++)
            {
                for (int j = -7; j <= 7; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear17x17(Board board, int x, int y)
        {
            if (x > (board.getSize() - 8) || x < 9 || y < 9 || y > (board.getSize() - 8))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -8; i <= 8; i++)
            {
                for (int j = -8; j <= 8; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear19x19(Board board, int x, int y)
        {
            if (x > (board.getSize() - 9) || x < 10 || y < 10 || y > (board.getSize() - 9))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -9; i <= 9; i++)
            {
                for (int j = -9; j <= 9; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear21x21(Board board, int x, int y)
        {
            if (x > (board.getSize() - 10) || x < 11 || y < 11 || y > (board.getSize() - 10))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -10; i <= 10; i++)
            {
                for (int j = -10; j <= 10; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear23x23(Board board, int x, int y)
        {
            if (x > (board.getSize() - 11) || x < 12 || y < 12 || y > (board.getSize() - 11))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -11; i <= 11; i++)
            {
                for (int j = -1; j <= 11; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        public void clear25x25(Board board, int x, int y)
        {
            if (x > (board.getSize() - 12) || x < 13 || y < 13 || y > (board.getSize() - 12))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            for (int i = -12; i <= 12; i++)
            {
                for (int j = -12; j <= 12; j++)
                {
                    cellBoard[x + i, y + j] = false;
                }
            }
        }

        //Methuselahs

        public void addGlidersDozen(Board board,int x,int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 2, y - 2] = false;
            cellBoard[x - 2, y - 1] = true;
            cellBoard[x - 2, y] = true;
            cellBoard[x - 2, y + 1] = true;
            cellBoard[x - 2, y + 2] = false;

            cellBoard[x - 1, y - 2] = false;
            cellBoard[x - 1, y - 1] = true;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = false;
            cellBoard[x - 1, y + 2] = false;

            cellBoard[x, y - 2] = false;
            cellBoard[x, y - 1] = false;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = false;
            cellBoard[x, y + 2] = false;

            cellBoard[x + 1, y - 2] = false;
            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = false;
            cellBoard[x + 1, y + 1] = true;
            cellBoard[x + 1, y + 2] = false;

            cellBoard[x + 2, y - 2] = false;
            cellBoard[x + 2, y - 1] = true;
            cellBoard[x + 2, y] = true;
            cellBoard[x + 2, y + 1] = true;
            cellBoard[x + 2, y + 2] = false;
        }



        //Moving cell formatins


        public void addGlider(Board board,int x, int y)
        {
            if(x > (board.getSize()-1) || x<2 || y<2 || y > (board.getSize() - 1)){
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = true;

            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = true;

            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = true;
        }

        public void addGosperGun(Board board, int x, int y)
        {
            this.leftGunPart(board, x - 4, y + 1);
            this.rightGunPart(board, x + 6, y - 1);

            this.addBlock(board, x - 17, y + 1);
            this.addBlock(board, x + 17, y - 1);

        }

        private void leftGunPart(Board board,int x,int y)
        {
            bool[,] cellBoard = board.getBoard();

            cellBoard[x-3, y-1] = true;
            cellBoard[x-3, y] = true;
            cellBoard[x-3, y+1] = true;

            cellBoard[x-2, y-2] = true;
            cellBoard[x-2, y+2] = true;
            
            cellBoard[x-1, y-3] = true;
            cellBoard[x-1, y+3] = true;
            
            cellBoard[x, y-3] = true;
            cellBoard[x, y+3] = true;
            
            cellBoard[x+1, y] = true;
            
            cellBoard[x+2, y-2] = true;
            cellBoard[x+2, y+2] = true;
            
            cellBoard[x+3, y-1] = true;
            cellBoard[x+3, y] = true;
            cellBoard[x+3, y+1] = true;
            
            cellBoard[x+4, y] = true;
        }

        private void rightGunPart(Board board, int x, int y)
        {
            bool[,] cellBoard = board.getBoard();

            cellBoard[x-3, y-1] = true;
            cellBoard[x-3, y] = true;
            cellBoard[x-3, y+1] = true;

            cellBoard[x-2, y-1] = true;
            cellBoard[x-2, y] = true;
            cellBoard[x-2, y+1] = true;
            
            cellBoard[x-1, y-2] = true;
            cellBoard[x-1, y+2] = true;
            
            cellBoard[x+1, y-3] = true;
            cellBoard[x+1, y-2] = true;
            cellBoard[x+1, y+2] = true;
            cellBoard[x+1, y+3] = true;
        }

        public void addSpaceShipLight(Board board, int x, int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x-2, y-2] = true;
            cellBoard[x-2, y] = true;

            cellBoard[x-1, y+1] = true;
            
            cellBoard[x, y+1] = true;
            
            cellBoard[x+1, y-2] = true;
            cellBoard[x+1, y+1] = true;
            
            cellBoard[x+2, y-1] = true;
            cellBoard[x+2, y] = true;
            cellBoard[x+2, y+1] = true;
        }

        public void addSpaceShipMedium(Board board, int x, int y)
        {
            if (x > (board.getSize() - 3) || x < 4 || y < 4 || y > (board.getSize() - 3))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x-3, y-1] = true;
            cellBoard[x-3, y+1] = true;

            cellBoard[x-2, y-2] = true;

            cellBoard[x-1, y-2] = true;
            cellBoard[x-1, y+2] = true;

            cellBoard[x, y-2] = true;

            cellBoard[x+1, y-2] = true;
            cellBoard[x+1, y+1] = true;

            cellBoard[x+2, y-2] = true;
            cellBoard[x+2, y-1] = true;
            cellBoard[x+2, y] = true;
        }

        public void addSpaceShipHeavy(Board board, int x, int y)
        {
            if (x > (board.getSize() - 3) || x < 4 || y < 4 || y > (board.getSize() - 3))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x-3, y-1] = true;
            cellBoard[x-3, y+1] = true;

            cellBoard[x-2, y-2] = true;

            cellBoard[x-1, y-2] = true;
            cellBoard[x-1, y+2] = true;

            cellBoard[x, y-2] = true;
            cellBoard[x, y+2] = true;

            cellBoard[x+1, y-2] = true;

            cellBoard[x+2, y-2] = true;
            cellBoard[x+2, y+1] = true;

            cellBoard[x+3, y-2] = true;
            cellBoard[x+3, y-1] = true;
            cellBoard[x+3, y] = true;
        }


        //Ticking cell formations


        public void addBlinkerH(Board board,int x, int y)
        {
            if (x > (board.getSize() - 1) || x < 2 || y < 2 || y > (board.getSize() - 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = true;
            cellBoard[x - 1, y + 1] = false;

            cellBoard[x, y - 1] = false;
            cellBoard[x, y] = true;
            cellBoard[x, y + 1] = false;

            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = false;
        }

        public void addBlinkerV(Board board, int x, int y)
        {
            if (x > (board.getSize() - 1) || x < 2 || y < 2 || y > (board.getSize() - 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = false;

            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = true;
            cellBoard[x, y + 1] = true;

            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = false;
            cellBoard[x + 1, y + 1] = false;
        }

        public void addToad(Board board, int x, int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 2, y - 2] = false;
            cellBoard[x - 2, y - 1] = false;
            cellBoard[x - 2, y] = false;
            cellBoard[x - 2, y + 1] = true;
            cellBoard[x - 2, y + 2] = false;

            cellBoard[x - 1, y - 2] = false;
            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = true;
            cellBoard[x - 1, y + 1] = true;
            cellBoard[x - 1, y + 2] = false;

            cellBoard[x, y - 2] = false;
            cellBoard[x, y - 1] = false;
            cellBoard[x, y] = true;
            cellBoard[x, y + 1] = true;
            cellBoard[x, y + 2] = false;

            cellBoard[x + 1, y - 2] = false;
            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = false;
            cellBoard[x + 1, y + 2] = false;

            cellBoard[x + 2, y - 2] = false;
            cellBoard[x + 2, y - 1] = false;
            cellBoard[x + 2, y] = false;
            cellBoard[x + 2, y + 1] = false;
            cellBoard[x + 2, y + 2] = false;
        }

        public void addBeacon(Board board, int x, int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 2, y - 2] = true;
            cellBoard[x - 2, y - 1] = true;
            cellBoard[x - 2, y] = false;
            cellBoard[x - 2, y + 1] = false;
            cellBoard[x - 2, y + 2] = false;

            cellBoard[x - 1, y - 2] = true;
            cellBoard[x - 1, y - 1] = true;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = false;
            cellBoard[x - 1, y + 2] = false;

            cellBoard[x, y - 2] = false;
            cellBoard[x, y - 1] = false;
            cellBoard[x, y] = true;
            cellBoard[x, y + 1] = true;
            cellBoard[x, y + 2] = false;

            cellBoard[x + 1, y - 2] = false;
            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = true;
            cellBoard[x + 1, y + 2] = false;

            cellBoard[x + 2, y - 2] = false;
            cellBoard[x + 2, y - 1] = false;
            cellBoard[x + 2, y] = false;
            cellBoard[x + 2, y + 1] = false;
            cellBoard[x + 2, y + 2] = false;
        }


        //Still cell formations


        public void addBlock(Board board,int x,int y)
        {
            if (x > (board.getSize() - 1) || x < 2 || y < 2 || y > (board.getSize() - 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = false;

            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = true;
            cellBoard[x, y + 1] = false;

            cellBoard[x + 1, y - 1] = true;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = false;
        }

        public void addBeehive(Board board,int x, int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 2, y - 2] = false;
            cellBoard[x - 2, y - 1] = false;
            cellBoard[x - 2, y] = true;
            cellBoard[x - 2, y + 1] = false;
            cellBoard[x - 2, y + 2] = false;

            cellBoard[x - 1, y - 2] = false;
            cellBoard[x - 1, y - 1] = true;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = true;
            cellBoard[x - 1, y + 2] = false;

            cellBoard[x, y - 2] = false;
            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = true;
            cellBoard[x, y + 2] = false;

            cellBoard[x + 1, y - 2] = false;
            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = false;
            cellBoard[x + 1, y + 2] = false;

            cellBoard[x + 2, y - 2] = false;
            cellBoard[x + 2, y - 1] = false;
            cellBoard[x + 2, y] = false;
            cellBoard[x + 2, y + 1] = false;
            cellBoard[x + 2, y + 2] = false;
        }

        public void addLoaf(Board board, int x, int y)
        {
            if (x > (board.getSize() - 2) || x < 3 || y < 3 || y > (board.getSize() - 2))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 2, y - 2] = false;
            cellBoard[x - 2, y - 1] = false;
            cellBoard[x - 2, y] = true;
            cellBoard[x - 2, y + 1] = false;
            cellBoard[x - 2, y + 2] = false;

            cellBoard[x - 1, y - 2] = false;
            cellBoard[x - 1, y - 1] = true;
            cellBoard[x - 1, y] = false;
            cellBoard[x - 1, y + 1] = true;
            cellBoard[x - 1, y + 2] = false;

            cellBoard[x, y - 2] = false;
            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = false;
            cellBoard[x, y + 2] = true;

            cellBoard[x + 1, y - 2] = false;
            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = true;
            cellBoard[x + 1, y + 2] = false;

            cellBoard[x + 2, y - 2] = false;
            cellBoard[x + 2, y - 1] = false;
            cellBoard[x + 2, y] = false;
            cellBoard[x + 2, y + 1] = false;
            cellBoard[x + 2, y + 2] = false;
        }

        public void addBoat(Board board, int x, int y)
        {
            if (x > (board.getSize() - 1) || x < 2 || y < 2 || y > (board.getSize() - 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = true;
            cellBoard[x - 1, y] = true;
            cellBoard[x - 1, y + 1] = false;

            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = true;

            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = false;
        }

        public void addTub(Board board, int x, int y)
        {
            if (x > (board.getSize() - 1) || x < 2 || y < 2 || y > (board.getSize() - 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            bool[,] cellBoard = board.getBoard();

            cellBoard[x - 1, y - 1] = false;
            cellBoard[x - 1, y] = true;
            cellBoard[x - 1, y + 1] = false;

            cellBoard[x, y - 1] = true;
            cellBoard[x, y] = false;
            cellBoard[x, y + 1] = true;

            cellBoard[x + 1, y - 1] = false;
            cellBoard[x + 1, y] = true;
            cellBoard[x + 1, y + 1] = false;
        }

    }
}
