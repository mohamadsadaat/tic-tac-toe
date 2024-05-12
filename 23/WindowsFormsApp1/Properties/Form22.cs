using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Properties
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        int i = 0;
        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (i % 2 == 0)
                {
                    button.Text = "X";
                    button.BackColor = Color.Blue;
                }
                else
                {
                    button.Text = "O";
                    button.BackColor = Color.Red;
                }
                i++;
            }
            Win();
        }
        class Player
        {
            int player1 = 0;
            int player2 = 0;
            public void Newresultplayer1()
            {
                player1++;
            }
            public int getplayer1
            {
                get { return player1; }
            }
            public void Newresultplayer2()
            {
                player2++;
            }
            public int getplayer2
            {
                get { return player2; }
            }
        }
        Player xo = new Player();
        void Win()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                getwin(button1, button2, button3);
            }
            if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                getwin(button6, button4, button5);
            }
            if (button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                getwin(button7, button8, button9);
            }
            if (button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text)
            {
                getwin(button1, button4, button7);
            }
            if (button2.Text != "" && button2.Text == button5.Text && button2.Text == button8.Text)
            {
                getwin(button2, button5, button8);
            }
            if (button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text)
            {
                getwin(button3, button6, button9);
            }
            if (button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text)
            {
                getwin(button1, button5, button9);
            }
            if (button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text)
            {
                getwin(button3, button5, button7);
            }
            if (i == 9)
            {
                negtive();
            }

        }
        void getwin(Button b1, Button b2, Button b3)
        {
            if (b1.Text == "X")
                xo.Newresultplayer1();
            else
                xo.Newresultplayer2();
            i = 0;
            result(xo.getplayer1, xo.getplayer2);
            next();
            clearc();
            result(xo.getplayer1, xo.getplayer2);
        }
        void negtive()
        {
            i = 0;
            clearc();
            result(xo.getplayer1, xo.getplayer2);
        }


        void result(int p1, int p2)
        {
            label1.Text = p1.ToString();
            label2.Text = p2.ToString();
            label3.Text = "player X";
            label3.BackColor = Color.Blue;
            label4.Text = "player O";
            label4.BackColor = Color.Red;
            button10.Text = "new game";
            colorwin();
        }
        void colorwin()
        {
            if (xo.getplayer1 > xo.getplayer2)
            {
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Green;
            }
            if (xo.getplayer1 == xo.getplayer2)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
        }
        void next()
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        void clearc()
        {
            foreach (Control c in Controls)
            {
                c.Text = "";
                c.BackColor = Color.White;
            }
        }

        private void Form22_Load(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "new game";
            Form22 frm2 = new Form22();
            frm2.Show();
            this.Close();
        }
    }
}
