using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VierGewinnt
{

    public partial class Form1 : Form
    {
        static Color clr = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorSetRC1();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ColorSetRC2();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ColorSetRC3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorSetRC4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorSetRC5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorSetRC6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorSetRC7();
        }


        public void ColorSetRC1()
        {
            if (RC11.BackColor == Color.White)
            {
                RC11.BackColor = clr;
            }
            else if (RC12.BackColor == Color.White)
            {
                RC12.BackColor = clr;
            }
            else if (RC13.BackColor == Color.White)
            {
                RC13.BackColor = clr;
            }
            else if (RC14.BackColor == Color.White)
            {
                RC14.BackColor = clr;
            }
            else if (RC15.BackColor == Color.White)
            {
                RC15.BackColor = clr;
            }
            else if (RC16.BackColor == Color.White)
            {
                RC16.BackColor = clr;
            }
        }
        public void ColorSetRC2()
        {
            if (RC21.BackColor == Color.White)
            {
                RC21.BackColor = clr;
            }
            else if (RC22.BackColor == Color.White)
            {
                RC22.BackColor = clr;
            }
            else if (RC23.BackColor == Color.White)
            {
                RC23.BackColor = clr;
            }
            else if (RC24.BackColor == Color.White)
            {
                RC24.BackColor = clr;
            }
            else if (RC25.BackColor == Color.White)
            {
                RC25.BackColor = clr;
            }
            else if (RC26.BackColor == Color.White)
            {
                RC26.BackColor = clr;
            }
        }
        public void ColorSetRC3()
        {
            if (RC31.BackColor == Color.White)
            {
                RC31.BackColor = clr;
            }
            else if (RC32.BackColor == Color.White)
            {
                RC32.BackColor = clr;
            }
            else if (RC33.BackColor == Color.White)
            {
                RC33.BackColor = clr;
            }
            else if (RC34.BackColor == Color.White)
            {
                RC34.BackColor = clr;
            }
            else if (RC35.BackColor == Color.White)
            {
                RC35.BackColor = clr;
            }
            else if (RC36.BackColor == Color.White)
            {
                RC36.BackColor = clr;
            }
        }
        public void ColorSetRC4()
        {
            if (RC41.BackColor == Color.White)
            {
                RC41.BackColor = clr;
            }
            else if (RC42.BackColor == Color.White)
            {
                RC42.BackColor = clr;
            }
            else if (RC43.BackColor == Color.White)
            {
                RC43.BackColor = clr;
            }
            else if (RC44.BackColor == Color.White)
            {
                RC44.BackColor = clr;
            }
            else if (RC45.BackColor == Color.White)
            {
                RC45.BackColor = clr;
            }
            else if (RC46.BackColor == Color.White)
            {
                RC46.BackColor = clr;
            }
        }
        public void ColorSetRC5()
        {
            if (RC51.BackColor == Color.White)
            {
                RC51.BackColor = clr;
            }
            else if (RC52.BackColor == Color.White)
            {
                RC52.BackColor = clr;
            }
            else if (RC53.BackColor == Color.White)
            {
                RC53.BackColor = clr;
            }
            else if (RC54.BackColor == Color.White)
            {
                RC54.BackColor = clr;
            }
            else if (RC55.BackColor == Color.White)
            {
                RC55.BackColor = clr;
            }
            else if (RC56.BackColor == Color.White)
            {
                RC56.BackColor = clr;
            }
        }
        public void ColorSetRC6()
        {
            if (RC61.BackColor == Color.White)
            {
                RC61.BackColor = clr;
            }
            else if (RC62.BackColor == Color.White)
            {
                RC62.BackColor = clr;
            }
            else if (RC63.BackColor == Color.White)
            {
                RC63.BackColor = clr;
            }
            else if (RC64.BackColor == Color.White)
            {
                RC64.BackColor = clr;
            }
            else if (RC65.BackColor == Color.White)
            {
                RC65.BackColor = clr;
            }
            else if (RC66.BackColor == Color.White)
            {
                RC66.BackColor = clr;
            }
        }
        public void ColorSetRC7()
        {
            if (RC71.BackColor == Color.White)
            {
                RC71.BackColor = clr;
            }
            else if (RC72.BackColor == Color.White)
            {
                RC72.BackColor = clr;
            }
            else if (RC73.BackColor == Color.White)
            {
                RC73.BackColor = clr;
            }
            else if (RC74.BackColor == Color.White)
            {
                RC74.BackColor = clr;
            }
            else if (RC75.BackColor == Color.White)
            {
                RC75.BackColor = clr;
            }
            else if (RC76.BackColor == Color.White)
            {
                RC76.BackColor = clr;
            }
        }

        private void YellCol_CheckedChanged(object sender, EventArgs e)
        {
            if (RedColl.Checked == true)
            {
                RedColl.Checked = false;
            }
            clr = Color.Yellow;   
        }
        
        private void RedColl_CheckedChanged(object sender, EventArgs e)
        {
            if (YellCol.Checked == true)
            {
                YellCol.Checked = false;
            }
            clr = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //beenden
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //neustart
            YellCol.Checked = false;
            RedColl.Checked = false;
            clr = Color.White;

            RC11.BackColor = clr;
            RC12.BackColor = clr;
            RC13.BackColor = clr;
            RC14.BackColor = clr;
            RC15.BackColor = clr;
            RC16.BackColor = clr;

            RC21.BackColor = clr;
            RC22.BackColor = clr;
            RC23.BackColor = clr;
            RC24.BackColor = clr;
            RC25.BackColor = clr;
            RC26.BackColor = clr;

            RC31.BackColor = clr;
            RC32.BackColor = clr;
            RC33.BackColor = clr;
            RC34.BackColor = clr;
            RC35.BackColor = clr;
            RC36.BackColor = clr;

            RC41.BackColor = clr;
            RC42.BackColor = clr;
            RC43.BackColor = clr;
            RC44.BackColor = clr;
            RC45.BackColor = clr;
            RC46.BackColor = clr;

            RC51.BackColor = clr;
            RC52.BackColor = clr;
            RC53.BackColor = clr;
            RC54.BackColor = clr;
            RC55.BackColor = clr;
            RC56.BackColor = clr;

            RC61.BackColor = clr;
            RC62.BackColor = clr;
            RC63.BackColor = clr;
            RC64.BackColor = clr;
            RC65.BackColor = clr;
            RC66.BackColor = clr;

            RC71.BackColor = clr;
            RC72.BackColor = clr;
            RC73.BackColor = clr;
            RC74.BackColor = clr;
            RC75.BackColor = clr;
            RC76.BackColor = clr;
        }
    }
}
