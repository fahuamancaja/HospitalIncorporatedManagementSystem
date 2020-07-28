using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;

            if(username == "user" && password == "pass")
            {
                //MessageBox.Show("Logging user in");

                this.Hide();
                var dashBoard = new Dashboard();
                dashBoard.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User Name");
            }

        }
    }
}
