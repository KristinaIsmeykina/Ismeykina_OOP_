using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Figures list field's property
        /// </summary>
        
        public MainForm()
        {
            InitializeComponent();
            //dataGridView1.DataSource = newlist;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();

            newInputForm.Owner = this;
            newInputForm.Show();
           
            if (newInputForm.DialogResult == DialogResult.OK)
                
            {

                dataGridView1.DataSource = newInputForm.newlist;
                MessageBox.Show(" hjgj");

            }
        }
    }
}
