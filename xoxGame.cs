using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class xoxGame : Form
    {

        public xoxGame()
        {
            InitializeComponent();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isaret = true;
        int isaret_sayisi = 0;
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isaret)
            {
                b.Text = "X";
                b.BackColor = Color.White;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.Red;
            }
            isaret = !isaret;
            b.Enabled = false;
            isaret_sayisi++;
            kazanan();

        }
        private void kazanan()
        {
            bool kazananvarmi = false;

            //yatay kontrol
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                kazananvarmi = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                kazananvarmi = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                kazananvarmi = true;

           //dikey kontrol
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                kazananvarmi = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                kazananvarmi = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                kazananvarmi = true;

            //çapraz kontrol 
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                kazananvarmi = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                kazananvarmi = true;
            if (kazananvarmi)
            {
                butonlaraftif();
                string kimkazandi = "";
                if (isaret)
                    kimkazandi = "O";
                else
                    kimkazandi = "X";
                MessageBox.Show(kimkazandi + " Kazandı", "Oyun Bitti");
            }
            else
            {
                if (isaret_sayisi == 9)
                    MessageBox.Show(" Berabere", "Oyun Bitti");
            }

        }

        private void butonlaraftif()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isaret = true;
            isaret_sayisi = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.LightSteelBlue;

                }
            }
            catch { }
        }
    }
}
