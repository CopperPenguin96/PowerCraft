using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigGUI
{
    public partial class ColorPicker : Form
    {
        public Color FallBackColor;
        public Color SelectedColor;
        public ColorPicker(String title, Color defaultColor)
        {
            InitializeComponent();
            FallBackColor = defaultColor;
            this.Text = title;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
            this.Hide();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Gray;
            this.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Navy;
            this.Hide();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
            this.Hide();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
            this.Hide();
        }

        private void ba_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Lime;
            this.Hide();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Teal;
            this.Hide();
        }

        private void bb_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Aqua;
            this.Hide();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Maroon;
            this.Hide();
        }

        private void bc_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Red;
            this.Hide();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Purple;
            this.Hide();
        }

        private void bd_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Magenta;
            this.Hide();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Olive;
            this.Hide();
        }

        private void be_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Yellow;
            this.Hide();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Silver;
            this.Hide();
        }

        private void bf_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.White;
            this.Hide();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            SelectedColor = FallBackColor;
            this.Hide();
        }

    }
}
