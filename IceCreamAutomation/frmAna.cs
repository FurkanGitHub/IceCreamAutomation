using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamAutomation
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        frmMusteri masa1;
        frmMusteri masa2;
        frmMusteri masa3;
        frmMusteri masa4;
        frmMusteri masa5;
        frmMusteri masa6;
        frmMusteri masa7;
        frmMusteri masa8;
        frmMusteri masa9;
        frmMusteri masa10;
        frmMusteri masa11;
        frmMusteri masa12;
        frmMusteri masa13;
        frmMusteri masa14;
        frmMusteri masa15;
        frmMusteri masa16;
        frmMusteri masa17;
        frmMusteri masa18;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Kayımoglu Dondurmaya Hoşgeldiniz.", "KAYIMOĞLU");
            timer1.Start();
            timer2.Start();
            timer3.Start();

         
        }

        private void indexC()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { masa1.Visible = true; }
            catch
            {
                masa1 = new frmMusteri(button1);
                masa1.Visible = true;
            }
        }

     
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                masa2.Visible = true;
            }
            catch
            {
                masa2 = new frmMusteri(button2);
                masa2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                masa3.Visible = true;
            }
            catch
            {
                masa3 = new frmMusteri(button3);
                masa3.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { masa4.Visible = true; }
            catch
            {
                masa4 = new frmMusteri(button4);
                masa4.Visible = true;
            }
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            reklam.Text = reklam.Text.Substring(1) + reklam.Text.Substring(0, 1);
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { masa5.Visible = true; }
            catch
            {
                masa5 = new frmMusteri(button5);
                masa5.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { masa6.Visible = true; }
            catch
            {
                masa6 = new frmMusteri(button6);
                masa6.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { masa7.Visible = true; }
            catch
            {
                masa7 = new frmMusteri(button7);
                masa7.Visible = true;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { masa8.Visible = true; }
            catch
            {
                masa8 = new frmMusteri(button8);
                masa8.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try { masa9.Visible = true; }
            catch
            {
                masa9 = new frmMusteri(button9);
                masa9.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try { masa10.Visible = true; }
            catch
            {
                masa10 = new frmMusteri(button10);
                masa10.Visible = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try { masa11.Visible = true; }
            catch
            {
                masa11 = new frmMusteri(button11);
                masa11.Visible = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try { masa12.Visible = true; }
            catch
            {
                masa12 = new frmMusteri(button12);
                masa12.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try { masa13.Visible = true; }
            catch
            {
                masa13 = new frmMusteri(button13);
                masa13.Visible = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try { masa14.Visible = true; }
            catch
            {
                masa14 = new frmMusteri(button14);
                masa14.Visible = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try { masa15.Visible = true; }
            catch
            {
                masa15 = new frmMusteri(button15);
                masa15.Visible = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try { masa16.Visible = true; }
            catch
            {
                masa16 = new frmMusteri(button16);
                masa16.Visible = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try { masa17.Visible = true; }
            catch
            {
                masa17 = new frmMusteri(button17);
                masa17.Visible = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try { masa18.Visible = true; }
            catch
            {
                masa18 = new frmMusteri(button18);
                masa18.Visible = true;
            }
        }

        int anim = 20;

        private void timer2_Tick(object sender, EventArgs e)
        {
            anim += 10;
            panel2.Size = new Size(anim, anim);
            if (anim == 700) timer2.Stop();
            
        }
        int anim2 = 20;
        private void timer3_Tick(object sender, EventArgs e)
        {
            anim2 += 10;
            panel1.Size = new Size(anim, anim);
            if (anim2 == 700) timer3.Stop(); 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bahçe_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

 

    }
}
