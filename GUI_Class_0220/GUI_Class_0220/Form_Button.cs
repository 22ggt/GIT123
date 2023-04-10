using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_0220
{
    public partial class Form_Button : Form
    {
        public Form_Button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下")
                button1.Text = "我已經被按過了";
            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
            else
                button1.Text = "請按我一下";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕被按過";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp = label2.Text;
            int count = 1;
            try
            {
                count = Int32.Parse(temp) + 1;
            }catch(Exception e1)
            {
                //label2.Text = "0";
            }

            //label2.Text = count+"";
            label2.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short sizeNum = 10;
            button4.Size= new Size(button4.Width+sizeNum, button4.Height+sizeNum);
        }
    }
}
