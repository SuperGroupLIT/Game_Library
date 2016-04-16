using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Library
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            staffList a = new staffList();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerList a = new customerList();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            gameList a = new gameList();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            newStaff a = new newStaff();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            newGame a = new newGame();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            newCustomer a = new newCustomer();
            a.Show();
        }
    }
}
