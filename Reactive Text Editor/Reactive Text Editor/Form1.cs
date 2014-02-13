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

namespace Reactive_Text_Editor
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        int a = 0;
        int b = 0;
        int c = a.CombineLatest(a, b) => return a+b);

        static IObservable<TResult> ObsExpr<T1, T2, TResult>
          (IObservable<T1> o1, IObservable<T2> o2, Func<T1, T2, TResult> func)
        {
          return o1.CombineLatest(o2, func);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add("hallo");
            list.Add("piet");
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

    }
}
