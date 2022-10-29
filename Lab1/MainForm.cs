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
        public BindingList<FigureBase> newlist = new BindingList<FigureBase>();
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = newlist;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();
            newInputForm.ShowDialog();
           
            if (newInputForm.DialogResult == DialogResult.OK)
                
            {
                newlist.Add(newInputForm.FigureBase);

            }
        }
    }
}
