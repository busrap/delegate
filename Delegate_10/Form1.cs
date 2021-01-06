using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_10
{
    public partial class Form1 : Form
    {
        public delegate void MesajVerHandler(string x); //delegate içerisine aynı tip de oluşturulmuş metod alır.
        public delegate int IntDoldur(int sayi);
            
  

        public Form1()
        {
            InitializeComponent();
        }
        public void MesajVer(string msj)
        {
            MessageBox.Show(msj);
        }
        void LabelDaMesaj(string lblmsg)
        {
            label1.Text = lblmsg;
        }
        void TxtDeMesaj(string txtmsg)
        {
            textBox1.Text = txtmsg;
        }
        void CaptionDaMesaj(string cptMsg)
        {
            this.Text = cptMsg;

        }
        public int Calculate(int y)
        {
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MesajVerHandler mesajVerici = new MesajVerHandler(MesajVer);
            mesajVerici += LabelDaMesaj;
            mesajVerici += TxtDeMesaj;
            mesajVerici += CaptionDaMesaj;
            //mesajVerici.Invoke("büşra");
            mesajVerici("polat");
            IntDoldur ınt_e = new IntDoldur(Calculate);

                 


        }
        
    }
}
