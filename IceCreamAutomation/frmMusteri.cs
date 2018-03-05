using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamAutomation
{
    public partial class frmMusteri : Form
    {
        Button called;

        public frmMusteri(Button btn)
        {
            called = btn;
            InitializeComponent();
        }

        int sayacPosiyon = 0;
        int sayacKulah = 0;
        int sayacHelva = 0;
        int sayacKilo = 0;
        private void frmMusteri_Load(object sender, EventArgs e)
        {

            string[] dondurmalar = new string[] { "BardakSu","SiseSu","Niğde Gazozu","Sade Soda","Meyveli Gazoz", "Sade", "Kakao", "Karadut", "Limon", "Çilek", "YabanMersini", "Cevizli", "TahinliCeviz", "CevizliBalkabagi", "Mozaik", "CikolataParcacikli", "KahveCekirdekli", "Hashasli", "Karamel", "Visne", "Ergen(Kizilcik)", "Hurma", "Diyet"};

           
            paketler.Items.AddRange(dondurmalar);


        }

        #region Fonksiyonlar



        double KulahFiyat()
        {
            double fiyat = 0;
            bool eklendi = false;
            for (int i = 0; i < kulah.Items.Count; i++)
            {
                switch (kulah.Items[i].ToString())
                {
                    case "BardakSu": fiyat += 0.25d; break;
                    case "SiseSu": fiyat += 0.5d; break;

                    case "Niğde Gazozu": fiyat += 1.5d; break;
                    case "Sade Soda": fiyat += 1.0d; break;
                    case "Meyveli Gazoz": fiyat += 1.25d; break;

                    default: if (!eklendi) fiyat += Convert.ToDouble(fiyatKulah.Text); break;

                }
                eklendi = true;
            }

            return fiyat;

        }

        double KiloFiyat()
        {
            double fiyat = 0;
            bool eklendi = false;
            for (int i = 0; i < kilo.Items.Count; i++)
            {
                switch (kilo.Items[i].ToString())
                {
                    case "BardakSu": fiyat += 0.25d; break;
                    case "SiseSu": fiyat += 0.5d; break;

                    case "Niğde Gazozu": fiyat += 1.5d; break;
                    case "Sade Soda": fiyat += 1.0d; break;
                    case "Meyveli Gazoz": fiyat += 1.25d; break;

                    default: if (!eklendi) fiyat += Convert.ToDouble(fiyatKilo.Text); break;

                }
                eklendi = true;
            }

            return fiyat;

        }





        double HelvaFiyat()
        {
            double fiyat = 0;
            bool eklendi = false;
            for (int i = 0; i < kagithelva.Items.Count; i++)
            {
                switch (kagithelva.Items[i].ToString())
                {
                    case "BardakSu": fiyat += 0.25d; break;
                    case "SiseSu": fiyat += 0.5d; break;

                    case "Niğde Gazozu": fiyat += 1.5d; break;
                    case "Sade Soda": fiyat += 1.0d; break;
                    case "Meyveli Gazoz": fiyat += 1.25d; break;

                    default:


                        if (!eklendi)
                        {

                            switch (boyut.Text)
                            {
                                case "Küçük": fiyat += 4.0d; break;
                                case "Orta(Tost)": fiyat += 4.0d; break;
                                case "Büyük": fiyat += 4.5d; break;
                                default: fiyat += 0.0d; break;
                            }

                        }
                        break;

                }
                eklendi = true;
            }

            return fiyat;

        }
        double PorsiyonFiyat()
        {
            double fiyat = 0;

            bool eklendi = false;

            for (int i = 0; i < porsiyon.Items.Count; i++)
            {

                switch (porsiyon.Items[i].ToString())
                {

                    case "BardakSu": fiyat += 0.25d; break;
                    case "SiseSu": fiyat += 0.5d; break;

                    case "Niğde Gazozu": fiyat += 1.5d; break;
                    case "Sade Soda": fiyat += 1.0d; break;
                    case "Meyveli Gazoz": fiyat += 1.25d; break;


                    case "Diyet": fiyat += 4.0d; break;
                    default: if (!eklendi) fiyat += 3.5d; break;


                }
                eklendi = true;
            }

  

            if (fiyat <= 5)
            {
                total.ForeColor = Color.Green;
            }
            else if (fiyat <= 10)
            {
                total.ForeColor = Color.Yellow;
            }
            else if (fiyat <= 20)
            {
                total.ForeColor = Color.Fuchsia;
            }
            else if (fiyat <= 30)
            {
                total.ForeColor = Color.Blue;
            }
            else
            {
                total.ForeColor = Color.Red;
            }



            return fiyat;
        }

        #endregion



        private void button3_Click(object sender, EventArgs e)
        {
            porsiyon.Items.Clear();
        }


        private void Temizle() {
            sepet.Items.Clear();
            total.Text = "0,0";
            sayacPosiyon = 0;
            sayacKulah = 0;
            sayacHelva = 0;
            sayacKilo = 0;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        
      
        private void button5_Click(object sender, EventArgs e)
        {
            if (porsiyon.Items.Count == 0) return;
            string toplam = "Porsiyon";

            sayacPosiyon++;
            toplam += sayacPosiyon.ToString() + "(";

            for (int i = 0; i < porsiyon.Items.Count; i++)
            {

                if (i != 0) {
                    toplam += "+";
                }
              
                toplam += porsiyon.Items[i].ToString();

            }


            toplam += ")";

            sepet.Items.Add(toplam + " --> " + PorsiyonFiyat() + " TL");

            total.Text = (Convert.ToDouble(total.Text)+ PorsiyonFiyat()).ToString();
            porsiyon.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var control = porsiyon.SelectedIndex;
            if (control >= 0)
            {
                string secilen = porsiyon.SelectedItem.ToString();
                porsiyon.Items.Remove(secilen);
            }
            else
            {
                MessageBox.Show("Porsiyon seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

         private void button9_Click(object sender, EventArgs e)
        {
            var control = kulah.SelectedIndex;
            if (control >= 0)
            {
                string secilen = kulah.SelectedItem.ToString();
                kulah.Items.Remove(secilen);
            }
            else
            {
                MessageBox.Show("Külah seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var control = paketler.SelectedIndex;
            if (control >= 0)
            {
                string secilen = paketler.SelectedItem.ToString();

                if (secilen == "BardakSu" || "SiseSu" == secilen)
                {
                    porsiyon.Items.Add(secilen);
                    return;
                }
                if (!porsiyon.Items.Contains(secilen))
                {
                    porsiyon.Items.Add(secilen);

                }
                else { MessageBox.Show("Dondurma zaten ekli..!", "KAYIMOĞLU", MessageBoxButtons.OK); }



            }
            else
            {
                MessageBox.Show("Dondurma seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var control = paketler.SelectedIndex;
            if (control >= 0)
            {
                string secilen = paketler.SelectedItem.ToString();
                if (secilen == "BardakSu" || "SiseSu" == secilen)
                {
                    kulah.Items.Add(secilen);
                    return;
                }
                if (!kulah.Items.Contains(secilen))
                {
                    kulah.Items.Add(secilen);

                }
                else { MessageBox.Show("Dondurma zaten ekli..!", "KAYIMOĞLU", MessageBoxButtons.OK); }



            }
            else
            {
                MessageBox.Show("Dondurma seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kulah.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kulah.Items.Count == 0) return;
            string toplam = "Külah";

            sayacKulah++;
            toplam += sayacKulah.ToString() + "(";

            for (int i = 0; i < kulah.Items.Count; i++)
            {

                if (i != 0)
                {
                    toplam += "+";
                }

                toplam += kulah.Items[i].ToString();

            }


            toplam += ")";

            sepet.Items.Add(toplam + " --> " + KulahFiyat() + " TL");

            total.Text = (Convert.ToDouble(total.Text)+ KulahFiyat()).ToString();
            kulah.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            kagithelva.Items.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kilo.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var control = paketler.SelectedIndex;
            if (control >= 0)
            {
                string secilen = paketler.SelectedItem.ToString();
                if (secilen == "BardakSu" || "SiseSu" == secilen)
                {
                    kagithelva.Items.Add(secilen);
                    return;
                }
                if (!kagithelva.Items.Contains(secilen))
                {
                    kagithelva.Items.Add(secilen);

                }
                else { MessageBox.Show("Dondurma zaten ekli..!", "KAYIMOĞLU", MessageBoxButtons.OK); }



            }
            else
            {
                MessageBox.Show("Dondurma seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var control = paketler.SelectedIndex;
            if (control >= 0)
            {
                string secilen = paketler.SelectedItem.ToString();
                if (secilen == "BardakSu" || "SiseSu" == secilen)
                {
                    kilo.Items.Add(secilen);
                    return;
                }
                if (!kilo.Items.Contains(secilen))
                {
                    kilo.Items.Add(secilen);

                }
                else { MessageBox.Show("Dondurma zaten ekli..!", "KAYIMOĞLU", MessageBoxButtons.OK); }



            }
            else
            {
                MessageBox.Show("Dondurma seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var control = kagithelva.SelectedIndex;
            if (control >= 0)
            {
                string secilen = kagithelva.SelectedItem.ToString();
                kagithelva.Items.Remove(secilen);
            }
            else
            {
                MessageBox.Show("KağıtHelva seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var control = kilo.SelectedIndex;
            if (control >= 0)
            {
                string secilen = kilo.SelectedItem.ToString();
                kilo.Items.Remove(secilen);
            }
            else
            {
                MessageBox.Show("Kilo seçmediniz..!", "KAYIMOĞLU", MessageBoxButtons.OK);
            }
        }
       
        private void button15_Click(object sender, EventArgs e)
        {
            if (kagithelva.Items.Count == 0) return;
            string toplam = "KağıtHelva";

            sayacHelva++;
            toplam += sayacHelva.ToString() + "(";

            for (int i = 0; i < kagithelva.Items.Count; i++)
            {

                if (i != 0)
                {
                    toplam += "+";
                }

                toplam += kagithelva.Items[i].ToString();

            }


            toplam += ")";

            sepet.Items.Add(toplam + " --> " + HelvaFiyat() + " TL");

            total.Text = (Convert.ToDouble(total.Text) + HelvaFiyat()).ToString();
            kagithelva.Items.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (kilo.Items.Count == 0) return;
            string toplam = "Kilo";

            sayacKilo++;
            toplam += sayacKilo.ToString() + "(";

            for (int i = 0; i < kilo.Items.Count; i++)
            {

                if (i != 0)
                {
                    toplam += "+";
                }

                toplam += kilo.Items[i].ToString();

            }


            toplam += ")";

            sepet.Items.Add(toplam + " --> " + KiloFiyat() + " TL");

            total.Text = (Convert.ToDouble(total.Text) + KiloFiyat()).ToString();
            kilo.Items.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (sepet.Items.Count == 0)
            {
                called.BackColor = Color.Blue;
            }
            else { called.BackColor = Color.Green; }

            
        }

        private void button19_Click(object sender, EventArgs e)
        {          
            if(MessageBox.Show("Hesabı ödemek istiyormusunuz ?", "KAYIMOĞLU", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes) {
                Temizle();
                called.BackColor = Color.Maroon;
                this.Close();
            }
        }

        private void paketler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
