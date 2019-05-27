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
        int TimeCount = 0;
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

            first_sel();
            
        }

        private void first_sel()
        {
           
        }
        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            timelbl.Text = CB.Text;

            sel = CB.SelectedIndex;

            timelbl.Text = txt + tea_time[sel] / 60 + "분";
            TimeCount = tea_time[sel];
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (TimeCount == 0)
            {
                
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.timer1.Enabled = false;
                this.timelbl.Enabled = true;
                this.btn.Enabled = true;
                this.CB.Enabled = true;
                timelbl.Text = txt;
                CB.Focus();
                

            }
            else
            {
                this.TimeCount--;
                this.timelbl.Text = txt + Convert.ToString(this.TimeCount/60)+"분 "+Convert.ToString(this.TimeCount%60)+"초";
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timelbl.Enabled = true;
            this.btn.Enabled = false;
            this.CB.Enabled = false;
        }
    }
}
