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
        List<User> list = new List<User>();     
        public Form2
            ()
        {
            InitializeComponent();
            if (Serialize.IsFile("users.txt"))
            {
                list = Serialize.LoadFromFile("users.txt");
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            User user = new User();
            foreach (var usr in list)
            {
                if (usr.login == textBox1.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    goto Marker1;
                }
            }
            user.login = textBox1.Text;
            user.password = textBox2.Text;
            list.Add(user);
            MessageBox.Show("Вы успешно зарегистрировались, используйте свой пароль и логин для входа в программу!");
            Serialize.SaveToFile("users.txt", list);
        Marker1:
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Auth_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool user_is_existed = false;
            bool right_password = false;
            foreach (var user in list)
            {
                if (textBox1.Text == user.login && textBox2.Text == user.password)
                {
                    user_is_existed = true;
                }

            }
            if (user_is_existed)
            {
                Form1 Program = new Form1();
                Program.Show();
                this.Hide(); // MessageBox.Show("Такого польззователя не существует, нужно зарегистрироваться!");
            }
            else
            {
                MessageBox.Show("Пользователя не существует, либо пароль или логин неверные");
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        
    }
}
