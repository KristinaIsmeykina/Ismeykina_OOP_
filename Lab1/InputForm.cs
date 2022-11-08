﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    //TODO: XML ++
    /// <summary>
    /// Форма для создания фигур
    /// </summary>
    public partial class InputForm : Form
    {
        
        /// <summary>
        /// Свойство- фигура
        /// </summary>
        public FigureBase FigureBase { get; set; }
       
        /// <summary>
        /// Свойство- выбранный radiobutton
        /// </summary>
        private RadioButton CheckedRadioButton { get; set; }

        /// <summary>
        /// Словарь radiobutton- usercontrol
        /// </summary>
        private readonly Dictionary<RadioButton, UserControl> _radioButtonToUserControl;


        /// <summary>
        /// Конструктор InputForm
        /// </summary>
        public InputForm()
        {
            InitializeComponent();
            SphereRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            PyramidRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            ParallelepipedRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            _radioButtonToUserControl = new Dictionary<RadioButton, UserControl>()
            {
                {SphereRadioButton, sphereUserControl},
                {PyramidRadioButton, pyramidUserControl},
                {ParallelepipedRadioButton, parallelepipedUserControl}
            };
        }

        /// <summary>
        /// Событие при нажатии кнопки OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {

            try
            {
                var radioButtonList = SelectFigureGroupBox.Controls.OfType<RadioButton>().ToList();

                foreach (RadioButton value in radioButtonList)
                {
                    if (CheckedRadioButton.Equals(value))
                    {
                        var newForm = (FigureBaseUserControl) _radioButtonToUserControl[value];
                        FigureBase = newForm.GetFigur();
                    }
                }
           
                DialogResult = DialogResult.OK;
            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        //TODO: XML++

        /// <summary>
        /// Событие при изменении radioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: RSDN  ++
            var radioButtonList = SelectFigureGroupBox.Controls.OfType<RadioButton>().ToList();

            foreach (RadioButton value in radioButtonList)
            {
                _radioButtonToUserControl[value].Visible = value.Checked;
                if (value.Checked)
                {
                    _radioButtonToUserControl[value].Visible = value.Checked;
                    CheckedRadioButton = value;
                }
            }
        }

        //TODO: XML ++
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO: XML
        //TODO: директивы условной компиляции
        /// <summary>
        /// Добавление рандомной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomFigureButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var option = random.Next(3);
            switch (option)
            {
                case 0:
                    FigureBase=Sphere.GetRandomSphere();
                    break;
                case 1:
                    FigureBase=Pyramid.GetRandomPyramid();
                    break;
                case 2:
                    FigureBase=Parallelepiped.GetRandomParallelepiped();
                    break;
                default:
                    FigureBase= Parallelepiped.GetRandomParallelepiped();
                    break;
            }
            DialogResult = DialogResult.OK;
        }


    }
}