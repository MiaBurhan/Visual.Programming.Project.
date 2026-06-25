using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0'; 
            }
            else
            {
                textBox3.PasswordChar = '*'; 
            }
        
    }
    }
}
