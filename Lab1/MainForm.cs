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
    /// <summary>
    /// Главная форма программы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Словарь с именем фигиры и ее типом
        /// </summary>
        private readonly Dictionary<string, Type> _figureTypes;

        
        /// <summary>
        /// Список с фигурами
        /// </summary>
        private BindingList<FigureBase> _newList = new BindingList<FigureBase>();

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = _newList;
            checkedListBox.Items.Add(nameof(Sphere));
            checkedListBox.Items.Add(nameof(Pyramid));
            checkedListBox.Items.Add(nameof(Parallelepiped));

            _figureTypes = new Dictionary<string, Type>()
        {
            { nameof(Sphere), typeof(Sphere) },
            { nameof(Pyramid), typeof(Pyramid) },
            { nameof(Parallelepiped), typeof(Parallelepiped) }
        };
        }
        

        /// <summary>
        /// Добавление новой фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();
            newInputForm.ShowDialog();

            if (newInputForm.DialogResult == DialogResult.OK)

            {
                _newList.Add(newInputForm.FigureBase);

            }
        }

        /// <summary>
        /// Удаление выбранной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        //TODO: RSDN ++
        /// <summary>
        /// Загрузить фигуры из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "FiguresVolume (*.xml)|*.xml"
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

        /// <summary>
        /// Сохранить фигуры в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "FiguresVolume (*.json)|*.json"
            };

            saveFileDialog.ShowDialog();

            var path = saveFileDialog.FileName;

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<FigureBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            //TODO: RSDN ++
            using (var fileWriter = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fileWriter, dataGridView1.DataSource);
            }

                

        }

        /// <summary>
        /// Поиск по фигурам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
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
                    if (figure.GetType().Equals(_figureTypes[checkedFigure.ToString()]))
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

        /// <summary>
        /// Обновление 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _newList;
        }

     
    }
}