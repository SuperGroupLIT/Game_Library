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
    public partial class gameList : Form
    {
        public gameList()
        {
            InitializeComponent();
            searchBox.Text = "ID / Title";
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if(searchBox.Text == "ID / Title")
            {
                searchBox.Text = "";
            }
        }
    }
}
