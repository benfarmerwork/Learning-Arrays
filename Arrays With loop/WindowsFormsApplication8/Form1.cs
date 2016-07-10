using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] lotter_numbers;
            lotter_numbers = new int[49];
            
            for (int i = 0; i < (lotter_numbers.Length); i++)
            {
                lotter_numbers[i] = i + 1;
                listBox1.Items.Add(lotter_numbers[i]);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int aNumber = int.Parse(textBox1.Text);
            int[] arraySize;
            arraySize = new int[aNumber];
            for (int i = 0; i < (arraySize.Length); i++)
            {
                arraySize[i] = i + 1;
                listBox1.Items.Add(arraySize[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] Arraylength;
            Arraylength = new int[10];
            int times = int.Parse(textBox1.Text);

            for (int i = 0; i < (Arraylength.Length) ; i++)
            {
                Arraylength[i] = i * times;
                listBox1.Items.Add(times + "times" + i + "= " + Arraylength[i]);
            }

        }
    }
}
