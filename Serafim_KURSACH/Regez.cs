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
    public partial class Regez : Form
    {
        SerafimEntities serafimEntities = new SerafimEntities();
        public Regez()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Regez_Load(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)

        {
             if (serafimEntities.USERS.SingleOrDefault(
          p => p.login == textBox1.Text && p.pass == textBox2.Text && p.role == 1) != null)
                {
                    Class1.id = textBox1.Text;
                    MessageBox.Show("Крассавэла,все верно");
                    new AdminMenu { Owner = this }.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }

            //AdminMenu f = new AdminMenu();
            //f.Show();
            //this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
            
        }
    }
}


 
        //AdminMenu f = new AdminMenu();
       //f.Show();
        //this.Hide();
    
    

