using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5at7
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int[] value = new int[20];
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (i = 0; i < 20; i++)
                {
                    value[i] = randNum.Next(0,20);
                    listBox2.Items.Add(value[i]);
                    if (i % 4 == 0 && i != 0)
                    {
                        listBox1.Items.Add(value[i]);
                    }
                }
            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
        }
    }
}
