using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private BindingList<FigureBase> _newList = new BindingList<FigureBase>();
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = _newList;
            checkedListBox.Items.Add(nameof(Sphere));
            checkedListBox.Items.Add(nameof(Pyramid));
            checkedListBox.Items.Add(nameof(Parallelepiped));

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();
            newInputForm.ShowDialog();

            if (newInputForm.DialogResult == DialogResult.OK)

            {
                _newList.Add(newInputForm.FigureBase);

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewCell cell in
                          dataGridView1.SelectedCells)
                {
                    _newList.Remove(cell.OwningRow.DataBoundItem
                        as FigureBase);
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "FiguresVolume (*.fvlm)|*.fvlm"
            };
            openFileDialog.ShowDialog();
            var path = openFileDialog.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<FigureBase>));

            try
            {
                using (var fileReader = new FileStream(path,
                                                       FileMode.Open))
                {
                    _newList = (BindingList<FigureBase>)
                        xmlSerializer.Deserialize(fileReader);
                };

                dataGridView1.DataSource = _newList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "FiguresVolume (*.fvlm)|*.fvlm"
            };

            saveFileDialog.ShowDialog();

            var path = saveFileDialog.FileName;

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<FigureBase>));




            using (var fileWriter = new FileStream(path, FileMode.Create))
            {

                xmlSerializer.Serialize(fileWriter, dataGridView1.DataSource);
            }

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            try
            {
               double  firstNumber = Convert.ToDouble(ToTextBox.Text);
               double secondNumber = Convert.ToDouble(FromTextBox.Text);
                MessageBox.Show("норм");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
            if (Convert.ToDouble(ToTextBox.Text) < Convert.ToDouble(FromTextBox.Text))
            {
                MessageBox.Show(@"Wrong range");
            }
            var typeFilteredList = new BindingList<FigureBase>();
            foreach (var figure in _newList)
            {
                foreach (var checkedFigure in
                         checkedListBox.CheckedItems)
                {
                    if (figure.GetType().Equals(checkedFigure.ToString()))
                    {
                        typeFilteredList.Add(figure);
                    }
                }
            }
            var filteredList = new BindingList<FigureBase>();
            foreach (var figure in typeFilteredList)
            {
                if (figure.Volume >= Convert.ToDouble(FromTextBox.Text) &&
                    figure.Volume <= Convert.ToDouble(ToTextBox.Text))
                {
                    filteredList.Add(figure);
                }
            }

            dataGridView1.DataSource = filteredList;

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _newList;

            //RefreshTextBoxes();
        }
    }
}