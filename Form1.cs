using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_assignment
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        public Form1()
        {
            InitializeComponent();
           

            data.Columns.Add("Name");
            data.Columns.Add("Father Name");
            data.Columns.Add("Age");
            data.Columns.Add("Degree");
            data.Columns.Add("Gender");
            data.Columns.Add("18+");
            data.Columns.Add("Campus");
            data.Columns.Add("Skills");
            data.Columns.Add("DOB");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            DataRow row1 = data.NewRow();

            row1["Name"] = textBox1.Text;
            row1["Father Name"] = textBox2.Text;
            row1["Age"] = textBox3.Text;
            row1["Degree"] = comboBox1.SelectedItem;

            if (radioButton1.Checked)
                row1["Gender"] = "Male";
            else
                row1["Gender"] = "Female";
            if (checkBox1.Checked)
                row1["18+"] = "Yes";
            else
               row1["18+"] = "No";

            row1["Campus"] = comboBox2.SelectedItem;

            if(checkBox2.Checked)
                row1["Skills"] = checkBox2.Text;
            if (checkBox3.Checked)
                row1["Skills"] = checkBox3.Text;
            if (checkBox4.Checked)
                row1["Skills"] = checkBox4.Text;
            if (checkBox5.Checked)
                row1["Skills"] = checkBox5.Text;

            row1["DOB"] = dateTimePicker1.Value;
           
            data.Rows.Add(row1);
            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
            


        }

       
    }
}
