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
using System.IO;

namespace Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<int, int> dict = new Dictionary<int, int>();
        public int dictLenght = 879; //The number of the keys (879 is the end of LATIN stuffs in UTF-16)
        public int dictMinValue = 1000; //The minimum value what can be a value of a key
        public int dictMaxValue = 15000; //The maximum value what can be a value of a key

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            string file = "dictionary.txt";
            if (File.Exists(file))
            {
                DictRead(file);
            }
            else
            {
                MessageBox.Show("Please create a dictionary!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (dict.Any())
            { 
                Output_textBox.Text = string.Empty;
                if (Input_textBox.Text != string.Empty)
                {
                    string inputReverse = new string(Input_textBox.Text.Reverse().ToArray());
                    List<char> charList = inputReverse.ToCharArray().ToList();
                    if (comboBox.SelectedIndex == 0)
                    {
                        charList.ForEach(c => { Output_textBox.Text += Encrypt(c); });
                    }
                    else
                    {
                        charList.ForEach(c => { Output_textBox.Text += Decrypt(c); });
                    }
                }
                else
                {
                    MessageBox.Show("Please write something!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("At first please create/read a dictionary!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public string Encrypt(char c)
        {
            int number = 35; //35 is hashtag, only happens if the char is not in the dict
            foreach (var item in dict)
            {
                if (item.Key == (int)c)
                {
                    number = item.Value;
                }
            }
            return ((char)number).ToString();
        }

        public string Decrypt(char c)
        {
            foreach (var item in dict)
            {
                if ((int)c == item.Value)
                {
                    return ((char)item.Key).ToString();
                }
            }
            return "-UNKNOWN-"; //Only happens if it's not in the dictionary
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            dict.Clear();
            Random rnd = new Random();
            string file = "dictionary.txt";
            if (!File.Exists(file))
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(file, false))
                    {
                        for (int i = 1; i <= dictLenght; i++)
                        {
                            int rndNum = rnd.Next(dictMinValue, dictMaxValue);
                            if (!dict.ContainsValue(rndNum))
                            {
                                writer.WriteLine($"{i};{rndNum}");
                                dict.Add(i, rndNum);
                            }
                            else
                            {
                                i--;
                            }
                        }
                    }
                    MessageBox.Show($"{file} created and loaded!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{file} not created!\nError: {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"{file} already exist!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            dict.Clear();
            OpenFileDialog opf = new OpenFileDialog
            {
                Filter = "TEXT (*.txt)|*.txt",
                FileName = "dictionary.txt"
            };
            if (opf.ShowDialog() == DialogResult.OK)
            {
                DictRead(opf.FileName);
            }
            else
            {
                MessageBox.Show("File load canceled.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DictRead(string fileName)
        {
            try
            {
                string[] allLines = File.ReadAllLines(fileName);
                for (int i = 0; i < allLines.Length; i++)
                {
                    string[] line = allLines[i].Split(';');
                    dict.Add(Convert.ToInt32(line[0]), Convert.ToInt32(line[1]));
                }
                MessageBox.Show($"{fileName} loaded!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
