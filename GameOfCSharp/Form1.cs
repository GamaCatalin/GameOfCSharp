using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace GameOfCSharp
{
    public partial class Form1 : Form
    {

        Bitmap bitmap;
        Board newBoard;
        ShapeGenerator shapeGen = new ShapeGenerator();
        int boardSize;

        public Form1()
        {
            InitializeComponent();
            this.boardSize = 200;
            this.Text = "Game of life";
            this.Height = this.boardSize * 4;
            this.Width = this.boardSize * 4;
            //testBoardInit1();
            //testBoardInit2();
            //testBoardInit3();
            //testBoardInit4();
            testBoardInit5();
            //randomInit();
            this.bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            timer1.Enabled = true;
            timer1.Start(); 
        }

        private void testBoardInit1()
        {
            newBoard = new Board(this.boardSize);
            shapeGen.addGlider(newBoard, 3, 2);
            shapeGen.addBlinkerH(newBoard, 20, 3);
            shapeGen.addBlinkerV(newBoard, 25, 3);
            shapeGen.addBlock(newBoard, 20, 10);
            shapeGen.addBeehive(newBoard, 20, 15);
            shapeGen.addLoaf(newBoard, 10, 30);
            shapeGen.addBoat(newBoard, 10, 40);
            shapeGen.addTub(newBoard, 20, 20);
            shapeGen.addToad(newBoard, 30, 30);
            shapeGen.addBeacon(newBoard, 30, 40);
        }

        private void testBoardInit2()
        {
            newBoard = new Board(this.boardSize);
            newBoard.generateRandom();
            shapeGen.clear13x13(newBoard, 20, 20);
            shapeGen.clear7x7(newBoard, 50, 20);
            shapeGen.clear25x25(newBoard, 75, 75);
        }

        private void testBoardInit3()
        {
            newBoard = new Board(this.boardSize);
            shapeGen.addGlidersDozen(newBoard, this.boardSize/2, this.boardSize/2);
        }

        private void testBoardInit4()
        {
            newBoard = new Board(this.boardSize);
            shapeGen.addGosperGun(newBoard, this.boardSize / 2, this.boardSize / 2);
        }

        private void testBoardInit5()
        {
            newBoard = new Board(this.boardSize);
            shapeGen.addSpaceShipLight(newBoard, 5, (this.boardSize / 3) - 10);
            shapeGen.addSpaceShipMedium(newBoard, 5, 2*(this.boardSize / 3 - 10));
            shapeGen.addSpaceShipHeavy(newBoard, 5, 3*(this.boardSize / 3 - 10));
        }

        private void randomInit()
        {
            newBoard = new Board(this.boardSize);
            newBoard.generateRandom();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void mainLoop()
        {
            timer1.Enabled = false;
            newBoard.nextGeneration();
            pictureBox2.Refresh();
        }

        private void GameTick(object sender, EventArgs e)
        {
            this.mainLoop();
        }

        private void picBoxDraw(object sender, PaintEventArgs e)
        {
            float cellWidth = 4;// pictureBox2.Width/this.boardSize;
            float cellHeight = 4;// pictureBox2.Height / this.boardSize;
            float offset = 1F;
            int size = newBoard.getSize();
            this.bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            Graphics g = Graphics.FromImage(this.bitmap);

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (newBoard.getCell(i, j))
                    {
                        g.FillRectangle(Brushes.Black, i * cellWidth, j * cellHeight, cellWidth-offset, cellHeight-offset);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, i * cellWidth, j * cellHeight, cellWidth-offset, cellHeight-offset);
                    }
                }
            }
            g.Dispose();
            e.Graphics.DrawImage(bitmap,0,0);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void pictureBox2_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
