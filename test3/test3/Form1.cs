using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.TextEvent += UserControl1_TextSubmitted;
            
            userControl11.TextEvent += eve;
            userControl11.TextEvent += third;
        }

        private void UserControl1_TextSubmitted(object sender, string e)
        {
            // UserControl1에서 전달된 값(e)을 사용
            MessageBox.Show("전달된 값: " + e);
            textBox1.Text = e;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            userControl11.vari = textBox2.Text;
            textBox2.Text = "";
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userControl11.vari);
        }

        private void eve(object sender, string e)
        {
            MessageBox.Show("2번");
        }
        private void third(object sender, string e)
        {
            MessageBox.Show("3번");
        }
    }
}
