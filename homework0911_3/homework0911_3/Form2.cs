﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0911_3 {
    public partial class Form2 : Form {
        public int a = 0;
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                a = Convert.ToInt32(textBox1.Text);
                this.Close();
            } catch { MessageBox.Show("請輸入整數"); }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
        public int SetA() {
            return a;
        }
    }
}
