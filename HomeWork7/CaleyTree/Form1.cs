using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int iterate = 0;
        double length = 0.0;
        public Pen pen;
        private void button1_Click(object sender, EventArgs e)
        {
            graphics = this.panel2.CreateGraphics();
            graphics.Clear(panel2.BackColor);
            drawCaleyleyTree(iterate,this.panel2.Width/2,310,length,-Math.PI/2);

        }
        void drawCaleyleyTree(int n, double x0,double y0,double leng,double th)
        {
            if (n==0)
            {
                return;
            }
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCaleyleyTree(n - 1, x1, y1, per1 * leng, th + th1*Math.PI/180);
            drawCaleyleyTree(n - 1, x1, y1, per2 * leng, th - th2*Math.PI/180);
            
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double JudgeInputDouble(string str)
        {
            double num = 0.0;
            if (Double.TryParse(str, out num) && num > 0)
            {
                this.label8.Text = "";
                return num;
            }
                this.label8.Text = "input error!";
            return -1.0;
            
        }
        private int JudgeInputInt(string str)
        {
            int num = 0;
            if (int.TryParse(str, out num) && num > 0)
            {
                return num;
            }
            this.label8.Text = "input error!";
            return -1;

        }
        private void ldegreetxt_TextChanged(object sender, EventArgs e)
        {
            if (JudgeInputDouble(this.ldegreetxt.Text)!=-1.0)
            {
                th1 = JudgeInputDouble(this.ldegreetxt.Text);
            }
        }

        private void rdegreetxt_TextChanged(object sender, EventArgs e)
        {
            if (JudgeInputDouble(this.rdegreetxt.Text) != -1.0)
            {
                th2 = JudgeInputDouble(this.rdegreetxt.Text);
            }
        }

        private void lpertxt_TextChanged(object sender, EventArgs e)
        {
            if (JudgeInputDouble(lpertxt.Text) != -1.0)
            {
                per1 = JudgeInputDouble(lpertxt.Text);
            }
        }

        private void rpertxt_TextChanged(object sender, EventArgs e)
        {
            if (JudgeInputDouble(rpertxt.Text) != -1.0)
            {
                per2 = JudgeInputDouble(rpertxt.Text);
            }
        }

        private void lengtxt_TextChanged(object sender, EventArgs e)
        {
            if (JudgeInputDouble(lengtxt.Text) != -1.0)
            {
                length = JudgeInputDouble(lengtxt.Text);
            }
        }

        private void itratetxt_TextChanged(object sender, EventArgs e)
        {
            if (JudgeInputInt(iteratetxt.Text)!=-1)
            {
                iterate = JudgeInputInt(iteratetxt.Text);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "红色":;
                    pen = Pens.Red;
                    break;
                case "绿色":
                    pen = Pens.Green;
                    break;
                case "蓝色":
                    pen = Pens.Blue;
                    break;
                default:
                    pen = Pens.Blue;

                    break;
            }
        }
    }
}
