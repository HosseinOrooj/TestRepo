using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> name = new List<string>();
            //File.AppendAllText(@"C:\Users\Administrator\Desktop\Test.json", textBox1.Text);
           
            string s = JsonConvert.SerializeObject(textBox1.Text+textBox2.Text);
            File.AppendAllText(@"C:\Users\Administrator\Desktop\Test.json", s);
            
            MessageBox.Show("Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    string i = File.ReadAllText(@"C:\Users\Administrator\Desktop\Test.json");
            //    List<string> list = new List<string>();
            //    try
            //    {
            //        list = JsonConvert.DeserializeObject<List<string>>(i);
            //        //textBox2.Text = list.ToString();

            //    }
            //    catch
            //    { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(@"C:\Users\Administrator\Desktop\Sample.txt", FileMode.Append,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(textBox1.Text + ";" + textBox2.Text+",");
            textBox1.Text = textBox2.Text = "";
            streamWriter.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Added");
            MessageBox.Show("Hello World");
            //FileStream fileStream = new FileStream(@"C:\Users\Administrator\Desktop\Sample.txt", FileMode.Open, FileAccess.Read);
            //StreamReader streamReader = new StreamReader(fileStream);
            //string all = streamReader.ReadToEnd();
            //string[] str = all.Split(',');
            //for (int i = 0; i < str.Count() -1; i++)
            //{
            //    string[] str2 = str[i].Split(';');
            //    dataGridView1.Rows.Add(str2[0], str2[1]);
            //}

        }
    }
}
