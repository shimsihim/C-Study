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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserControl1_TextSubmitted()
        {
            // UserControl1에서 전달된 값(e)을 사용
            MessageBox.Show("빈값");
            textBox1.Text = "빈 ";
        }

        private void UserControl1_TextSubmitted(string text)
        {
            // UserControl1에서 전달된 값(e)을 사용
            MessageBox.Show("전달된 값: "+text);
            textBox1.Text = text;
        }
    }
}
