using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bro_Hot_Food_And_Beverage
{
    public partial class add_new_meal : Form
    {
        public add_new_meal()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string nm=txt_add_mealName.Text;
            MainMenu main=new MainMenu();
            
            
            Guna2Button button = new Guna2Button();
            button.Text = nm;
            button.FillColor = Color.Black;
            button.ForeColor = Color.White;
            button.Size = new Size();
            button.Location = new Point();
            button.Visible = true;
            //button.Size(10, 10);
            MessageBox.Show("meal added success");

        }
    }
}
