using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork_winform
{
    public partial class Form1 : Form
    {
        Stack inst = new Stack();
        string stdDetails = "{0, -10}{1, -15}{2, -50}";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(string.Format(stdDetails, "ID", "S/R", "Stack"));
            inst.readData();
        }

        private void read_data_Click(object sender, EventArgs e)
        { 
            foreach(var elem in inst.array)
            {
                List<string> lst = new List<string>();
                for (int i = 0; i < elem.Count; i++)
                {
                    Stack.Node temp = elem.top;

                    lst.Clear();
                    while (temp != null)
                    {
                        lst.Add(temp.data.ToString());
                        temp = temp.link;
                    }
                }
                lst.Reverse();
                string line = string.Join(" ", lst.ToArray());
                if (elem.IsSourse == true)
                {
                    string ii = "S";
                    listBox1.Items.Add(string.Format(stdDetails, elem.ID, ii, line));
                }
                else if (elem.IsReciever == true)
                {
                    string ii = "R";
                    listBox1.Items.Add(string.Format(stdDetails, elem.ID, ii, line));
                }
                else
                {
                    string ii = "-";
                    listBox1.Items.Add(string.Format(stdDetails, elem.ID, ii, line));
                }
            }
        }

        private void write_data_Click(object sender, EventArgs e)
        {
            inst.writeData();
        }

        private void pop_source_Click(object sender, EventArgs e)
        {
            inst.array[inst.id_of_source].Pop();
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(stdDetails, "ID", "S/R", "Stack"));
            read_data_Click(sender, e);
        }

        private void put_in_reciever_Click(object sender, EventArgs e)
        {
            inst.array[inst.id_of_reciever].Push(Convert.ToDouble(num_to_put.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(stdDetails, "ID", "S/R", "Stack"));
            read_data_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = inst.array[inst.id_of_source].Peek();
            inst.array[inst.id_of_source].Pop();
            inst.array[inst.id_of_reciever].Push(x);
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(stdDetails, "ID", "S/R", "Stack"));
            read_data_Click(sender, e);
        }

        private void make_stack_rs_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_textbox.Text);
            string mode = rs_textbox.Text;

            if (mode == "S")
            {
                inst.array[inst.id_of_source].IsSourse = false;
                inst.array[id-1].IsSourse = true;
                inst.id_of_source = id-1;
            }
            if (mode == "R")
            {
                inst.array[inst.id_of_reciever].IsReciever = false;
                inst.array[id-1].IsReciever = true;
                inst.id_of_reciever = id-1;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(stdDetails, "ID", "S/R", "Stack"));
            read_data_Click(sender, e);
        }
    }
}
