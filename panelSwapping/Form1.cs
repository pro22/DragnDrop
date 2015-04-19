using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace panelSwapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool panel1_Selected = false;
        bool panel2_Selected = false;
        bool panel3_Selected = false;
        bool panel4_Selected = false;

        Point panelOneILoc = new Point(76, 69);
        Point panelTwoILoc = new Point(401, 69);
        Point panelThreeILoc = new Point(76, 273);
        Point panelFourILoc = new Point(401, 273);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_Selected = true;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2_Selected = true;
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3_Selected = true;
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4_Selected = true;
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1_Selected = false;

            if (isIntersecting(tempX, tempY) == 1 || isIntersecting(tempX, tempY) == 0)
            {
                panel1.Location = panelOneILoc;
            }
            else if (isIntersecting(tempX, tempY) == 2)
            {
                panel1.Location = panelTwoILoc;
                panel2.Location = panelOneILoc;

                Point temp = panelOneILoc;
                panelOneILoc = panelTwoILoc;
                panelTwoILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 3)
            {
                panel1.Location = panelThreeILoc;
                panel3.Location = panelOneILoc;

                Point temp = panelOneILoc;
                panelOneILoc = panelThreeILoc;
                panelThreeILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 4)
            {
                panel1.Location = panelFourILoc;
                panel4.Location = panelOneILoc;

                Point temp = panelOneILoc;
                panelOneILoc = panelFourILoc;
                panelFourILoc = temp;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            panel2_Selected = false;

            if (isIntersecting(tempX, tempY) == 2 || isIntersecting(tempX, tempY) == 0)
            {
                panel2.Location = panelTwoILoc;
            }
            else if (isIntersecting(tempX, tempY) == 1)
            {
                panel2.Location = panelOneILoc;
                panel1.Location = panelTwoILoc;

                Point temp = panelTwoILoc;
                panelTwoILoc = panelOneILoc;
                panelOneILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 3)
            {
                panel2.Location = panelThreeILoc;
                panel3.Location = panelTwoILoc;

                Point temp = panelTwoILoc;
                panelTwoILoc = panelThreeILoc;
                panelThreeILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 4)
            {
                panel2.Location = panelFourILoc;
                panel4.Location = panelTwoILoc;

                Point temp = panelTwoILoc;
                panelTwoILoc = panelFourILoc;
                panelFourILoc = temp;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            panel3_Selected = false;

            if (isIntersecting(tempX, tempY) == 3 || isIntersecting(tempX, tempY) == 0)
            {
                panel3.Location = panelThreeILoc;
            }
            else if (isIntersecting(tempX, tempY) == 1)
            {
                panel3.Location = panelOneILoc;
                panel1.Location = panelThreeILoc;

                Point temp = panelThreeILoc;
                panelThreeILoc = panelOneILoc;
                panelOneILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 2)
            {
                panel3.Location = panelTwoILoc;
                panel2.Location = panelThreeILoc;

                Point temp = panelThreeILoc;
                panelThreeILoc = panelTwoILoc;
                panelTwoILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 4)
            {
                panel3.Location = panelFourILoc;
                panel4.Location = panelThreeILoc;

                Point temp = panelThreeILoc;
                panelThreeILoc = panelFourILoc;
                panelFourILoc = temp;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            panel4_Selected = false;

            if (isIntersecting(tempX, tempY) == 4 || isIntersecting(tempX, tempY) == 0)
            {
                panel4.Location = panelFourILoc;
            }
            else if (isIntersecting(tempX, tempY) == 1)
            {
                panel4.Location = panelOneILoc;
                panel1.Location = panelFourILoc;

                Point temp = panelFourILoc;
                panelFourILoc = panelOneILoc;
                panelOneILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 2)
            {
                panel4.Location = panelTwoILoc;
                panel2.Location = panelFourILoc;

                Point temp = panelFourILoc;
                panelFourILoc = panelTwoILoc;
                panelTwoILoc = temp;
            }
            else if (isIntersecting(tempX, tempY) == 3)
            {
                panel4.Location = panelThreeILoc;
                panel3.Location = panelFourILoc;

                Point temp = panelFourILoc;
                panelFourILoc = panelThreeILoc;
                panelThreeILoc = temp;
            }
        }



        int tempX, tempY;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel1_Selected)
            {
                tempX = (Cursor.Position.X - 50);
                tempY = (Cursor.Position.Y - 50);
                panel1.Location = new Point(tempX, tempY);
            }
        }        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel2_Selected)
            {
                tempX = (Cursor.Position.X - 50);
                tempY = (Cursor.Position.Y - 50);
                panel2.Location = new Point(tempX, tempY);
            }
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel3_Selected)
            {
                tempX = (Cursor.Position.X - 50);
                tempY = (Cursor.Position.Y - 50);
                panel3.Location = new Point(tempX, tempY);
            }
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel4_Selected)
            {
                tempX = (Cursor.Position.X - 50);
                tempY = (Cursor.Position.Y - 50);
                panel4.Location = new Point(tempX, tempY);
            }
        }

        public int isIntersecting(int x, int y)
        {
            Rectangle rect = new Rectangle(x, y, 147, 88);

            Rectangle first = new Rectangle(panelOneILoc.X, panelOneILoc.Y, 147, 88);
            Rectangle second = new Rectangle(panelTwoILoc.X, panelTwoILoc.Y, 147, 88);
            Rectangle third = new Rectangle(panelThreeILoc.X, panelThreeILoc.Y, 147, 88);
            Rectangle fourth = new Rectangle(panelFourILoc.X, panelFourILoc.Y, 147, 88);

            if (rect.IntersectsWith(first))
            {
                return 1;
            }
            else if (rect.IntersectsWith(second))
            {
                return 2;
            }
            else if (rect.IntersectsWith(third))
            {
                return 3;
            }
            else if (rect.IntersectsWith(fourth))
            {
                return 4;
            }
            return 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
