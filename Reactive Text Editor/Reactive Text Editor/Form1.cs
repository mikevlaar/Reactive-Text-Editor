using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text.RegularExpressions;

namespace Reactive_Text_Editor
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        Subject<int> a = new Subject<int>();
        Subject<int> b = new Subject<int>();
        IObservable<int> c = new Subject<int>();
        
        public void test()
        {
            c = a.CombineLatest(b, (x, y) => x + y);
            c.Subscribe(z => { 
                textBox4.Text = z.ToString();
            }); 
        }

        public Form1()
        {
            InitializeComponent();
            test();
            addWords();
        }

        private void addWords()
        {
            list.Add("hallo");
            list.Add("reactive");
            list.Add("jan");
            list.Add("michel");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text.Length == 0)
            {
                hideResults();
                return;
            }

            foreach (String s in list)
            {
                if (s.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(s);
                    listBox1.Visible = true;
                }
            }
        }

        void hideResults()
        {
            listBox1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            hideResults();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            if (textBox2.Text == "")
            {
                a.OnNext(number);
            }
            else if (checkIfStringIsNumber(textBox2.Text))
            {
                number = int.Parse(textBox2.Text);
                a.OnNext(number);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            if (textBox3.Text == "")
            {
                b.OnNext(number);
            }
            else if(checkIfStringIsNumber(textBox3.Text))
            {
                number = int.Parse(textBox3.Text);
                b.OnNext(number);
            }
        }

        private bool checkIfStringIsNumber(string readLine) {
            if(Regex.IsMatch(readLine, @"^\d+$")) {
                return true;
            }
            return false;
        }
    }
}
