using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] tea = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] tea_time = new int[] { 120, 180, 300, 120 };
        string txt;
        int sel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<tea.Length;i++)
            {
                this.CB.Items.Add(tea[i]);
            }
            this.txt = timelbl.Text;
            
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            timelbl.Text = CB.Text;

            for(int i=0;i<tea.Length;i++)
            {
                if (CB.Text.Equals(tea[i]))
                {
                    sel = i;
                    break;
                }
            }

            timelbl.Text = txt + tea_time[sel] / 60 + "분";
        }
    }
}
