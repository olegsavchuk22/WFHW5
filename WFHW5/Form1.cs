using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextCanged(object sender, EventArgs e)
        {
            int progress = 0;
            if (textBox1.Text != "")
            {
                progress += progressBar1.Step;
            }
            if (textBox2.Text != "")
            {
                progress += progressBar1.Step;
            }
            if (textBox3.Text != "")
            {
                progress += progressBar1.Step;
            }
            if (textBox4.Text != "")
            {
                progress += progressBar1.Step;
            }
            if (textBox5.Text != "")
            {
                progress += progressBar1.Step;
            }
            progressBar1.Value = progress;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                MessageBox.Show($"ПІБ: {textBox1.Text} {textBox2.Text} {textBox3.Text}, Місце роботи: {textBox4.Text}, Посада: {textBox5.Text}", "Повна інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Жодне з полів не може бути пустим", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
