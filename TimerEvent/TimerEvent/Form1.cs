﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer t;

        private void Form1_Load(object sender, EventArgs e)
        {
                t = new Timer();
                t.Interval = 100;
                t.Tick += new EventHandler(t_Tick);
                t.Start();
           
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value >= 100) t.Stop();
        }
    }
}
