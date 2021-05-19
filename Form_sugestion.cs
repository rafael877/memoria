using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teste_com_gunaUI
{
    public partial class Form_sugestion : Form
    {
        public Form_sugestion()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_message form = new Form_message();
            form.Show();


            for (int i = 0; i < 40; i++)
            {
                new Form_message().Show();
                
            }

          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_message form = new Form_message();
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
