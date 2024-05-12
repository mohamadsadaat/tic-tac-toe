using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (i % 2 == 0)
                { button.Text = "X"; }
                else { button.Text = "O"; }
                i++;
            }
            Win();
        }
        void Win()
        {
            
            if( button1.Text !="" &&button1.Text==button2.Text&& button1.Text == button3.Text)
            {
                getwin(button1,button2,button3);
            }
            if (button3.Text != "" && button3.Text == button4.Text && button3.Text == button5.Text)
            {
                getwin(button3, button4, button5);
            }
            if (button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                getwin(button7, button8, button9);
            }
            if (button1.Text != "" && button1.Text == button3.Text && button1.Text == button7.Text)
            {
                getwin(button1, button3, button7);
            }
            if (button2.Text != "" && button2.Text == button4.Text && button2.Text == button8.Text)
            {
                getwin(button2, button4, button8);
            }
            if (button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text)
            {
                getwin(button3, button6, button9);
            }
            if (button1.Text != "" && button1.Text == button4.Text && button1.Text == button9.Text)
            {
                getwin(button1, button4, button9);
            }
            if (button3.Text != "" && button3.Text == button4.Text && button3.Text == button7.Text)
            {
                getwin(button3, button4, button7);
            }

        }
        bool winer=false;
        void getwin(Button b1,Button b2,Button b3)
        {
            winer = true;
            b1.Text ="win";
            b3.Text = "win";
            b2.Text = "win";
            b1.ForeColor = Color.Green;
            b2.ForeColor = Color.Green;
            b3.ForeColor = Color.Green;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
