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
        Subject<int> b = new Subject<int>();
        Subject<int> c = new Subject<int>();
        IObservable<int> a = new Subject<int>();
        
        public void initializeSubscribers()
        {
            a = b.CombineLatest(c, (x, y) => x + y);
            a.Subscribe(z => { 
                textBoxA.Text = z.ToString();
            }); 
        }

        public Form1()
        {
            InitializeComponent();
            initializeSubscribers();
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
            assumptionsListBox.Items.Clear();
            if (reactiveTextBox.Text.Length == 0)
            {
                hideResults();
                return;
            }

            foreach (String s in list)
            {
                if (s.Contains(reactiveTextBox.Text))
                {
                    assumptionsListBox.Items.Add(s);
                    assumptionsListBox.Visible = true;
                }
            }
            //test
        }

        void hideResults()
        {
            assumptionsListBox.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reactiveTextBox.Text = assumptionsListBox.Items[assumptionsListBox.SelectedIndex].ToString();
            hideResults();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            if (textBoxB.Text == "")
            {
                b.OnNext(number);
            }
            else if (checkIfStringIsNumber(textBoxB.Text))
            {
                number = int.Parse(textBoxB.Text);
                b.OnNext(number);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            if (textBoxC.Text == "")
            {
                c.OnNext(number);
            }
            else if(checkIfStringIsNumber(textBoxC.Text))
            {
                number = int.Parse(textBoxC.Text);
                c.OnNext(number);
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
