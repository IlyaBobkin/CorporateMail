using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs4sem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static public string username = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                alertlabel.Text = "Ошибка 2023: Введите имя пользователя!";
            }
            else if (textBox1.Text.Contains("/") || textBox1.Text.Contains(".") || textBox1.Text.Contains(",") || textBox1.Text.Contains(";") || textBox1.Text.Contains(":") || textBox1.Text.Contains("!"))
            {
                alertlabel.Text = "Ошибка 2022: Использованы недопустимые символы!";
            }
            else
            {
                username = textBox1.Text;
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }

        }
    }
}
