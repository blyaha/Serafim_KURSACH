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
    public partial class KNIGI : Form
    {
        SerafimEntities serafimEntities = new SerafimEntities();
        public KNIGI()
        {
            InitializeComponent();
            // dataGridView1.DataSource = SerafimEntities.BOOKS.ToList();


            dataGridView1.DataSource = AppData.Context.BOOKS.ToList();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminMenu f = new AdminMenu();
            f.Show();
            this.Hide();


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы  что, хотите удалить?", "Cepaфим лучший!!!!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (e.ColumnIndex == 7)
                {

                    AppData.Context.BOOKS.Remove((BOOKS)dataGridView1.Rows[e.RowIndex].DataBoundItem);
                    AppData.Context.SaveChanges();

                    


                    //int a = dataGridView1.CurrentRow.Index;
                    //dataGridView1.Rows.Remove(dataGridView1.Rows[a]);

                    dataGridView1.DataSource = AppData.Context.BOOKS.ToList();


                    //AppData.Context.BOOKS.Remove(dataGridView1.SelectedRows as BOOKS);
                    //AppData.Context.SaveChanges();


                    //dataGridView1.DataSource = AppData.Context.BOOKS.ToList();
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В доработке");
            //new add { Owner = this }.Show();
            //Hide();
        }
        
    }
}

