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

namespace GameOfCSharp
{
    public partial class Form1 : Form
    {

        Bitmap bitmap;
        Board newBoard;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Game of life";
            initBoard();
            this.bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            timer1.Enabled = true;
            timer1.Start(); 
        }

        private void initBoard()
        {
            newBoard = new Board(150);
            newBoard.addCell(1, 2);
            newBoard.addCell(2, 3);
            newBoard.addCell(3, 1);
            newBoard.addCell(3, 2);
            newBoard.addCell(3, 3);
            newBoard.generateRandom();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void mainLoop()
        {
            //Console.WriteLine("Loop");
            timer1.Enabled = false;
            newBoard.nextGeneration();
            pictureBox2.Refresh();
        }

        private void GameTick(object sender, EventArgs e)
        {
            //Console.WriteLine("Tick");
            this.mainLoop();
        }

        private void picBoxDraw(object sender, PaintEventArgs e)
        {
            //Console.WriteLine("Draw");
            int cellSize = 4;
            int size = newBoard.getSize();

            //this.newBoard.nextGeneration();

            Graphics g = Graphics.FromImage(this.bitmap);

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (newBoard.getCell(i, j))
                    {
                        g.FillRectangle(Brushes.Black, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                }
            }
            g.Dispose();
            e.Graphics.DrawImage(bitmap,0,0);
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
