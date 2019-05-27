using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_prog_4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string x;
        public override string Text { get; set; }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {

                

                ((Control)sender).Hide();

                button4.Visible = true;
                textBox1.Visible = true;
                label1.Text = "Podaj swoje imię (10 znaków)";
                
            }
        }
  
        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
            {
                this.BackgroundImage = Properties.Resources._48672_8_bit_8_bit_scenery;
                pictureBox1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                label1.Text = "Jesteś nad pięknym morzem bałtyckim XD o zachodzie słońca przechadzasz się jak na wakacjowicza przystało co chcesz zrobić "+x+"?";

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == true)
            {
                button3.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
                textBox1.Visible = true;
                label1.Text = "Podaj swoje imię (10 znaków)";


            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled == true)
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "POOLE NIE MOŻE BYĆ PUSTE";
                    return;
                }
                else
                {
                    
                    textBox1.Visible = false;
                    ((Control)sender).Hide();
                    label1.Text = "Gotowy zacząć grę?";
                     x = textBox1.Text;
                    label2.Text = ("Imię:" + x);
                    button2.Visible = true;
                    button3.Visible = true;
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
