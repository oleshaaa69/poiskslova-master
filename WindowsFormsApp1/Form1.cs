using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            public void pictureBox2_Click(object sender, EventArgs e)
            {
            int c = 0;
            string stroka = richTextBox1.Text;
            if (textBox1.Text == "")
                MessageBox.Show("Введите текст");

            else
            {
                string[] words = stroka.Split(new Char[] { ',', ' ', '\n' });
                int index = stroka.IndexOf(textBox1.Text);

                for (int i = 0; i < words.Length; i++)
                {                 

                    if (words[i] == textBox1.Text)
                    {                     
                        richTextBox1.SelectionStart = index;
                        richTextBox1.SelectionLength = textBox1.TextLength;
                        richTextBox1.SelectionColor = Color.Green;                      
                        index = richTextBox1.Text.IndexOf(textBox1.Text, index + textBox1.TextLength);
                        c++;
                    }
                }
                if (c == 0)
                {
                    MessageBox.Show("Совпадений не найдено");
                }
            }
            
        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
                richTextBox1.Clear();
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = Color.Black;
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

    }
}
