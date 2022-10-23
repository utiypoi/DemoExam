using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam
{
    
    public partial class AuthorizationForm : Form
    {
        
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            BasicForm basicForm = new BasicForm();
            basicForm.Show();
            this.Hide();
        }
    }
}
