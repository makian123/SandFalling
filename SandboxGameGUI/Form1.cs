using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxGameGUI
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Game sandBox;
        public bool isRunning;
        public int radius;
        public char pixelDef = 's';
        public bool pourable;

        private bool pressed;

        public class Game
        {
            private int xSize, ySize;
            public List<int[]> pourLoc = new List<int[]>();
            public List<char> pourType = new List<char>();
            private List<List<char>> board = new List<List<char>>();
            private List<List<bool>> hasMovedFlag = new List<List<bool>>();
            Bitmap bmp;

            public Game(int xs, int ys, Bitmap input = null)
            {
                xSize = xs;
                ySize = ys;

                if (input == null)
                {
                    bmp = new Bitmap(xSize, ySize);
                    Initialize();
                    PrintBoard();
                }
                else
                {
                    bmp = new Bitmap(xSize, ySize);
                    ExtractColors(input);
                    for (int y = 0; y < ySize; ++y)
                    {
                        List<bool> moved = new List<bool>();
                        for (int x = 0; x < xSize; ++x)
                        {
                            moved.Add(false);
                        }
                        hasMovedFlag.Add(moved);
                    }
                }
            }

            public void Initialize()
            {
                for (int y = 0; y < ySize; ++y)
                {
                    List<char> lvl = new List<char>();
                    List<bool> moved = new List<bool>();
                    for (int x = 0; x < xSize; ++x)
                    {
                        if (y == 0 || y == ySize - 1) lvl.Add('#');
                        else if (x == 0 || x == xSize - 1) lvl.Add('#');
                        else lvl.Add('.');
                        moved.Add(false);
                    }
                    hasMovedFlag.Add(moved);
                    board.Add(lvl);
                }
            }

            public void Simulate()
            {
                char underLeft, under, underRight;
                char left, right;
                char up;

                //Sets all flags to false
                for (int y = ySize - 2; y >= 1; y--)
                    for (int x = 0; x < xSize - 1; ++x)
                        hasMovedFlag[y][x] = false;

                //Uses 2 loops offset by 1 for better results
                for (int y = ySize - 2; y >= 1; y -= 2)
                {
                    for (int x = 1; x < xSize - 1; x++)
                    {
                        if (hasMovedFlag[y][x]) continue;
                        switch (board[y][x])
                        {
                            #region sand
                            case 's':
                                underLeft = board[y + 1][x - 1];
                                under = board[y + 1][x];
                                underRight = board[y + 1][x + 1];

                                if (under == '.' || under == 'w')
                                {
                                    (board[y][x], board[y + 1][x]) = (board[y + 1][x], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x] = true;
                                }
                                else if((underLeft == '.' || underLeft == 'w') && (underRight == '.' || underRight == 'w'))
                                {
                                    Random rand = new Random();
                                    int choice = rand.Next(0, 1000);

                                    if (choice >= 500)
                                    {
                                        (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x - 1] = true;
                                    }
                                    else
                                    {
                                        (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x + 1] = true;
                                    }
                                }
                                else if (underLeft == '.' || underLeft == 'w')
                                {
                                    (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x - 1] = true;
                                }
                                else if (underRight == '.' || underRight == 'w')
                                {
                                    (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x + 1] = true;
                                }
                                break;
                            #endregion
                            #region water
                            case 'w':
                                underLeft = board[y + 1][x - 1];
                                under = board[y + 1][x];
                                underRight = board[y + 1][x + 1];
                                left = board[y][x - 1];
                                right = board[y][x + 1];
                                if (under == '.')
                                {
                                    (board[y][x], board[y + 1][x]) = (board[y + 1][x], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x] = true;
                                }
                                else if (underLeft == '.' && underRight == '.')
                                {
                                    Random rand = new Random();
                                    int choice = rand.Next(0, 1000);

                                    if (choice >= 500)
                                    {
                                        (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x - 1] = true;
                                    }
                                    else
                                    {
                                        (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x + 1] = true;
                                    }
                                }
                                else if (underLeft == '.')
                                {
                                    (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x - 1] = true;
                                }
                                else if (underRight == '.')
                                {
                                    (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x + 1] = true;
                                }
                                else if(left == '.')
                                {
                                    (board[y][x - 1], board[y][x]) = (board[y][x], board[y][x - 1]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x - 1] = true;
                                }
                                else if (right == '.')
                                {
                                    (board[y][x + 1], board[y][x]) = (board[y][x], board[y][x + 1]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x + 1] = true;
                                }
                                break;
                            #endregion
                            #region fire
                            case 'f':
                                up = board[y - 1][x];
                                left = board[y][x - 1];
                                right = board[y][x + 1];
                                under = board[y + 1][x];

                                if (up == 'W')
                                {
                                    board[y - 1][x] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y - 1][x] = true;
                                }
                                if (left == 'W')
                                {
                                    board[y][x - 1] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x - 1] = true;
                                }
                                if (right == 'W')
                                {
                                    board[y][x + 1] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x + 1] = true;
                                }
                                if (under == 'W')
                                {
                                    board[y + 1][x] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x] = true;
                                }
                                board[y][x] = '.';
                                break;
                            #endregion
                            default:
                                break;
                        }
                    }
                }
                for (int y = ySize - 3; y >= 1; y -= 2)
                {
                    for (int x = 1; x < xSize - 1; x++)
                    {
                        if (hasMovedFlag[y][x]) continue;
                        switch (board[y][x])
                        {
                            #region sand
                            case 's':
                                underLeft = board[y + 1][x - 1];
                                under = board[y + 1][x];
                                underRight = board[y + 1][x + 1];

                                if (under == '.' || under == 'w')
                                {
                                    (board[y][x], board[y + 1][x]) = (board[y + 1][x], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x] = true;
                                }
                                else if ((underLeft == '.' || underLeft == 'w') && (underRight == '.' || underRight == 'w'))
                                {
                                    Random rand = new Random();
                                    int choice = rand.Next(0, 1000);

                                    if (choice >= 500)
                                    {
                                        (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x - 1] = true;
                                    }
                                    else
                                    {
                                        (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x + 1] = true;
                                    }
                                }
                                else if (underLeft == '.' || underLeft == 'w')
                                {
                                    (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x - 1] = true;
                                }
                                else if (underRight == '.' || underRight == 'w')
                                {
                                    (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x + 1] = true;
                                }
                                break;
                            #endregion
                            #region water
                            case 'w':
                                underLeft = board[y + 1][x - 1];
                                under = board[y + 1][x];
                                underRight = board[y + 1][x + 1];
                                left = board[y][x - 1];
                                right = board[y][x + 1];
                                if (under == '.')
                                {
                                    (board[y][x], board[y + 1][x]) = (board[y + 1][x], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x] = true;
                                }
                                else if (underLeft == '.' && underRight == '.')
                                {
                                    Random rand = new Random();
                                    int choice = rand.Next(0, 1000);

                                    if (choice >= 500)
                                    {
                                        (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x - 1] = true;
                                    }
                                    else
                                    {
                                        (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                        hasMovedFlag[y][x] = true;
                                        hasMovedFlag[y + 1][x + 1] = true;
                                    }
                                }
                                else if (underLeft == '.')
                                {
                                    (board[y][x], board[y + 1][x - 1]) = (board[y + 1][x - 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x - 1] = true;
                                }
                                else if (underRight == '.')
                                {
                                    (board[y][x], board[y + 1][x + 1]) = (board[y + 1][x + 1], board[y][x]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x + 1] = true;
                                }
                                else if (left == '.')
                                {
                                    (board[y][x - 1], board[y][x]) = (board[y][x], board[y][x - 1]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x - 1] = true;
                                }
                                else if (right == '.')
                                {
                                    (board[y][x + 1], board[y][x]) = (board[y][x], board[y][x + 1]);
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x + 1] = true;
                                }
                                break;
                            #endregion
                            #region fire
                            case 'f':
                                up = board[y - 1][x];
                                left = board[y][x - 1];
                                right = board[y][x + 1];
                                under = board[y + 1][x];

                                if (up == 'W')
                                {
                                    board[y - 1][x] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y - 1][x] = true;
                                }
                                if (left == 'W')
                                {
                                    board[y][x - 1] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x - 1] = true;
                                }
                                if (right == 'W')
                                {
                                    board[y][x + 1] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y][x + 1] = true;
                                }
                                if (under == 'W')
                                {
                                    board[y + 1][x] = 'f';
                                    hasMovedFlag[y][x] = true;
                                    hasMovedFlag[y + 1][x] = true;
                                }
                                board[y][x] = '.';
                                break;
                            #endregion
                            default:
                                break;
                        }
                    }
                }
                Pour();
                PrintBoard();
            }

            public void PrintBoard()
            {
                for (int y = 0; y < ySize; ++y)
                {
                    for (int x = 0; x < xSize; ++x)
                    {
                        switch (board[y][x])
                        {
                            case '.':
                                bmp.SetPixel(x, y, Color.White);
                                break;
                            case 's':
                                bmp.SetPixel(x, y, Color.DarkOrange);
                                break;
                            case 'w':
                                bmp.SetPixel(x, y, Color.Blue);
                                break;
                            case 'W':
                                bmp.SetPixel(x, y, Color.SaddleBrown);
                                break;
                            case 'f':
                                bmp.SetPixel(x, y, Color.OrangeRed);
                                break;
                            default:
                                bmp.SetPixel(x, y, Color.Black);
                                break;

                        }
                    }
                }
            }

            private void Pour()
            {
                for(int i = 0; i < pourLoc.Count; ++i)
                {
                    board[pourLoc[i][0]][pourLoc[i][1]] = pourType[i];
                }
            }
            private void ExtractColors(Bitmap input)
            {
                for (int y = 0; y < input.Height; ++y)
                {
                    List<char> lvl = new List<char>();

                    for (int x = 0; x < input.Width; ++x)
                    {
                        Color curr = input.GetPixel(x, y);
                        if (curr.ToArgb() == Color.White.ToArgb()) lvl.Add('.');
                        else if (curr.ToArgb() == Color.Black.ToArgb()) lvl.Add('#');
                        else if (curr.ToArgb() == Color.DarkOrange.ToArgb()) lvl.Add('s');
                        else if (curr.ToArgb() == Color.Blue.ToArgb()) lvl.Add('w');
                        else lvl.Add('.');
                    }
                    board.Add(lvl);
                }
            }
            public Bitmap GetBMP()
            {
                return bmp;
            }

            public void SetPixel(int x, int y, char pix)
            {
                if(x < board.Count - 1 && x > 0 && y < board[0].Count - 1 && y > 0)
                    board[x][y] = pix;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pressed = false;
            pourable = false;
            pixelDef = 's';
            radius = 10;
            isRunning = false;
            timer.Start();
            bmp = new Bitmap("slika.bmp");
            sandBox = new Game(bmp.Width, bmp.Height, bmp);
            outPic.Width = bmp.Width;
            outPic.Height = bmp.Height;
            this.MinimumSize = new Size(outPic.Width + 50, outPic.Height + 200);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                outPic.Image = sandBox.GetBMP();
                sandBox.Simulate();
            }
            
        }

        #region buttons
        private void playBtn_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
        }
        
        private void increaseRadBtn_Click(object sender, EventArgs e)
        {
            radius++;
            radLabel.Text = "" + radius;
        }
        private void reduceRadBtn_Click(object sender, EventArgs e)
        {
            if (radius > 1) radius--;
            radLabel.Text = "" + radius;
        }

        #region typeButtons
        private void sandBtn_Click(object sender, EventArgs e)
        {
            pixelDef = 's';
        }
        private void barrierBtn_Click(object sender, EventArgs e)
        {
            pixelDef = '#';
        }
        private void airBtn_Click(object sender, EventArgs e)
        {
            pixelDef = '.';
        }
        private void waterBtn_Click(object sender, EventArgs e)
        {
            pixelDef = 'w';
        }
        private void woodBtn_Click(object sender, EventArgs e)
        {
            pixelDef = 'W';
        }
        private void fireBtn_Click(object sender, EventArgs e)
        {
            pixelDef = 'f';
        }
        #endregion

        #endregion

        private void pourableCheck_CheckedChanged(object sender, EventArgs e)
        {
            pourable = !pourable;
        }

        #region addingSandandOther
        private void outPic_MouseDown_1(object sender, MouseEventArgs e)
        {
            int x = Cursor.Position.X - this.Left - 15, y = Cursor.Position.Y - this.Top - 40;
            for (int i = y - radius; i < y + radius; ++i)
            {
                for (int j = x - radius; j < x + radius; ++j)
                {
                    if (!pourable)
                        sandBox.SetPixel(i, j, pixelDef);
                    else
                    {
                        sandBox.pourLoc.Add(new int[2] { i, j });
                        sandBox.pourType.Add(pixelDef);
                    }
                }
            }
            pressed = true;
        }
        private void outPic_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
        }
        private void outPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                int x = Cursor.Position.X - this.Left - 15, y = Cursor.Position.Y - this.Top - 40;
                for (int i = y - radius; i < y + radius; ++i)
                {
                    for (int j = x - radius; j < x + radius; ++j)
                    {
                        if (!pourable)
                            sandBox.SetPixel(i, j, pixelDef);
                        else
                        {
                            sandBox.pourLoc.Add(new int[2] { i, j });
                            sandBox.pourType.Add(pixelDef);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
