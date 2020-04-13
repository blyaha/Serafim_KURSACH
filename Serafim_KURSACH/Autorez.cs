using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serafim_KURSACH
{
    public partial class Autorez : Form
    {
        SerafimEntities serafimEntities = new SerafimEntities();
        public Autorez()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox3.Text =  1) 
            {
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
                {
                    if (textBox2.Text.Length == 6)
                    {
                        if (textBox1.Text.Length >= 6 && textBox2.Text.Length >= 6)
                        {
                            {
                                serafimEntities.USERS.Add(new USERS
                                {
                                    login = textBox1.Text,
                                    pass = textBox2.Text,
                                    role = 1
                                });
                                serafimEntities.SaveChanges();
                                DialogResult result = MessageBox.Show("Регистрация прошла", "БОДРЯК");
                                new Autorez { Owner = this }.Show();
                                Hide();
                            }
                        }
                        else MessageBox.Show(" логин и пароль должны иметь не менЬше 6 знаков");
                    }
                    else MessageBox.Show("бро ");
                }
                else MessageBox.Show("Не всё есть");
            }

        }

    

        private void Autorez_Load(object sender, EventArgs e)
        {

        }
    }
}
 
