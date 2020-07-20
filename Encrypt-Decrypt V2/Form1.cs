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
        readonly Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {' ', 44911},
            {'q', 14852},
            {'w', 30763},
            {'e', 59349},
            {'r', 40809},
            {'t', 37724},
            {'z', 16161},
            {'u', 25306},
            {'i', 59720},
            {'o', 38258},
            {'p', 28161},
            {'ő', 48796},
            {'ú', 11733},
            {'ű', 3701},
            {'a', 61800},
            {'s', 41459},
            {'d', 28647},
            {'f', 53815},
            {'g', 48989},
            {'h', 35698},
            {'j', 64850},
            {'k', 2280},
            {'l', 57014},
            {'é', 33687},
            {'á', 62093},
            {'í', 39156},
            {'y', 35572},
            {'x', 33102},
            {'c', 42990},
            {'v', 26608},
            {'b', 57599},
            {'n', 33086},
            {'m', 40486},
            {'Q', 14895},
            {'W', 38420},
            {'E', 47969},
            {'R', 35172},
            {'T', 11616},
            {'Z', 44556},
            {'U', 41087},
            {'I', 37392},
            {'O', 60322},
            {'P', 19547},
            {'Ő', 56907},
            {'Ú', 49856},
            {'Ű', 21364},
            {'A', 61796},
            {'S', 46411},
            {'D', 6920},
            {'F', 47810},
            {'G', 17877},
            {'H', 11233},
            {'J', 2980},
            {'K', 45797},
            {'L', 55589},
            {'É', 42632},
            {'Á', 23370},
            {'Í', 62609},
            {'Y', 62789},
            {'X', 1653},
            {'C', 2152},
            {'V', 48591},
            {'B', 47849},
            {'N', 33113},
            {'M', 46191},
            {'0', 60607},
            {'1', 8311},
            {'2', 62370},
            {'3', 30813},
            {'4', 13831},
            {'5', 6288},
            {'6', 17031},
            {'7', 9259},
            {'8', 7903},
            {'9', 63839},
            {',', 4528},
            {'.', 48266},
            {'/', 49363},
            {'*', 40729},
            {'-', 42893},
            {'!', 54694},
            {'?', 32410},
            {'=', 60712},
            {'(', 8731},
            {')', 46367},
            {'%', 32788},
            {'\n', 60221},
            {'\r', 24838},
        };

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
            Output_textBox.Text = string.Empty;
            if (Input_textBox.Text != string.Empty)
            {
                List<char> charList = Input_textBox.Text.ToCharArray().ToList();
                int addition = (int)numericUpDown.Value;
                if (comboBox.SelectedIndex == 0)
                {
                    charList.ForEach(c => { Output_textBox.Text += Encrypt(c, addition); });
                }
                else
                {
                    charList.ForEach(c => { Output_textBox.Text += Decrypt(c, addition); });
                }
                
            }
            else
            {
                MessageBox.Show("Please write something!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public string Encrypt(char c, int addition)
        {
            int number = 35; //35 is hashtag, only happens if the char is not in the dict
            foreach (var item in dict)
            {
                if (item.Key == c)
                {
                    number = item.Value + addition;
                }
            }

            return ((char)number).ToString();
        }

        public string Decrypt(char c, int addition)
        {
            foreach (var item in dict)
            {
                if (((int)c-addition) == item.Value)
                {
                    return item.Key.ToString();
                }
            }

            return "-UNKNOWN-";
        }
    }
}
