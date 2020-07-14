using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Input_textBox.Text != string.Empty)
            {
                Output_textBox.Text = string.Empty;
                List<char> charList = Input_textBox.Text.ToCharArray().ToList();
                charList.ForEach(c => { Output_textBox.Text += EncryptDecrypt(c, (int)numericUpDown.Value, comboBox.SelectedIndex); });
            }
            else
            {
                MessageBox.Show("Please write something!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public string EncryptDecrypt(char c, int multiplication, int mode)
        {
            int number = Convert.ToBoolean(mode) ? (int)c / multiplication : (int)c * multiplication;
            return ((char)number).ToString();
        }
    }
}
