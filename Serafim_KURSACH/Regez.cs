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

            //AdminMenu f = new AdminMenu();
            //f.Show();
            //this.Hide();
        }
    }
}


 
        //AdminMenu f = new AdminMenu();
       //f.Show();
        //this.Hide();
    
    

