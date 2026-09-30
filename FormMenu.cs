using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnTask1_1_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_1().ShowDialog();
            Show();
        }

        private void btnTask1_2_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_2().ShowDialog();
            Show();
        }

        private void btnTask1_3_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_3().ShowDialog();
            Show();
        }

        private void btnTask1_4_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_4().ShowDialog();
            Show();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask2().ShowDialog();
            Show();
        }
    }
}
