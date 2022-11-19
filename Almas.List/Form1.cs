using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almas.List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] student = new string[4];

            student[0] = (dataGridViewListOfStudents.Rows.Count + 1).ToString();
            student[1] = textBoxFirstName.Text;
            student[2] = textBoxSeconName.Text;
            student[3] = textBoxRating.Text;

            dataGridViewListOfStudents.Rows.Add(student[0], student[1], student[2], student[3]);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridViewListOfStudents.Rows.Remove(dataGridViewListOfStudents.SelectedRows[0]);

            textBoxFirstName.Clear();
            textBoxSeconName.Clear();
            textBoxRating.Clear();

        }

        

        private void dataGridViewListOfStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFirstName.Text = dataGridViewListOfStudents.SelectedRows[0].Cells[1].Value.ToString();
            textBoxSeconName.Text = dataGridViewListOfStudents.SelectedRows[0].Cells[2].Value.ToString();
            textBoxRating.Text = dataGridViewListOfStudents.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string[] student = new string[3];

            student[0] = textBoxFirstName.Text;
            student[1] = textBoxSeconName.Text;
            student[2] = textBoxRating.Text;

            dataGridViewListOfStudents.SelectedRows[0].Cells[1].Value = student[0];
            dataGridViewListOfStudents.SelectedRows[0].Cells[2].Value = student[1];
            dataGridViewListOfStudents.SelectedRows[0].Cells[3].Value = student[2];


        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int summ = 0;
            int count = dataGridViewListOfStudents.Rows.Count;

            if(count != 0)
            {
                for (int i = 0; i  < count; i++)
                {
                    int rating = Convert.ToInt32(dataGridViewListOfStudents.Rows[i].Cells[3].Value);
                    summ += rating;

                }
                int average = summ/count;

                textBoxAverage.Text = average.ToString();
            
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            int count = dataGridViewListOfStudents.Rows.Count;

            if(count != 0)
            {
                int min = Convert.ToInt32(dataGridViewListOfStudents.Rows[0].Cells[3].Value);

              if (count  > 1)
                {
                    for (int i = 1; i < dataGridViewListOfStudents.Rows.Count; i++)
                    {
                        int rating = Convert.ToInt32(dataGridViewListOfStudents.Rows[i].Cells[3].Value);
                        if(min > rating)
                        {
                            min = rating;
                        }
                    }



              }


                textBoxMin.Text = min.ToString();


            }




        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            int count = dataGridViewListOfStudents.Rows.Count;

            if (count != 0)
            {
                int min = Convert.ToInt32(dataGridViewListOfStudents.Rows[0].Cells[3].Value);

                if (count < 1)
                {
                    for (int i = 1; i > dataGridViewListOfStudents.Rows.Count; i++)
                    {
                        int rating = Convert.ToInt32(dataGridViewListOfStudents.Rows[i].Cells[3].Value);
                        if (min < rating)
                        {
                            min = rating;
                        }
                    }



                }


                textBoxMax.Text = min.ToString();


            }
        }
    }
}
