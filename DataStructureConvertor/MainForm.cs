using DataStructureConvertor.Core;
using DataStructureConvertor.Factory;
using DataStructureConvertor.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DataStructureConvertor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetInput_Click(object sender, EventArgs e)
        {
            if (this.cbInput.SelectedItem is ChooseItem choose)
            {
                var getter = ConverterFactory.CreateGetterInput(choose.ConverterType);
                if (getter == null)
                {
                    MessageBox.Show("No Ui definition for: " + choose.ConverterType);
                }

                if (getter != null && getter.ConstructorParameter(this))
                {
                    this.inputGetter = getter;
                }
            }
            else
            {
                MessageBox.Show("No choose input type");
            }
        }

        private void btnSetOutput_Click(object sender, EventArgs e)
        {
            if (this.cbOutput.SelectedItem is ChooseItem choose)
            {
                var getter = ConverterFactory.CreateGetterOutput(choose.ConverterType);
                if (getter == null)
                {
                    MessageBox.Show("No Ui definition for: " + choose.ConverterType);
                }

                if (getter != null && getter.ConstructorParameter(this))
                {
                    this.outputGetter = getter;
                }
            }
            else
            {
                MessageBox.Show("No choose input type");
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!(this.cbOutput.SelectedItem is ChooseItem chooseOuput) || !(this.cbInput.SelectedItem is ChooseItem chooseInput))
            {
                MessageBox.Show("No choose input or output type");
                return;
            }
            
            if (this.inputGetter == null ||
               string.IsNullOrEmpty(this.inputGetter.Text) ||
               this.outputGetter == null ||
               string.IsNullOrEmpty(this.outputGetter.Text))
            {
                MessageBox.Show("No valid input or output");
                return;
            }

            var input = ConverterFactory.CreateInput(chooseInput.ConverterType, this.inputGetter);
            var output = ConverterFactory.CreateOutput(chooseOuput.ConverterType, this.outputGetter);
            if (input == null || output == null)
            {
                MessageBox.Show("Cant create input or output");
                input?.Dispose();
                output?.Dispose();
                return;
            }           
            Converter.Convert(input, output);
           
           
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inputGetter = null;
        }

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.outputGetter = null;
        }

        private IUiGetterInput _inputGetter;
        private IUiGetterInput inputGetter
        {
            get => this._inputGetter;
            set
            {
                this._inputGetter = value;
                this.lblInput.Text = this._inputGetter == null ? string.Empty : this._inputGetter.Text;
            }
        }

        private IUiGetterOutput _outputGetter;
        private IUiGetterOutput outputGetter
        {
            get => this._outputGetter;
            set
            {
                this._outputGetter = value;
                this.lblOuput.Text = this._outputGetter == null ? string.Empty : this._outputGetter.Text;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.inputGetter = null;
            this.cbInput.Items.AddRange(ConverterFactory.GetInputConverterTypes().ToArray());
            if (this.cbInput.Items.Count > 0)
            {
                this.cbInput.SelectedItem = this.cbInput.Items[0];
            }
            //
            this.outputGetter = null;
            this.cbOutput.Items.AddRange(ConverterFactory.GetOutputConverterTypes().ToArray());
            if (this.cbOutput.Items.Count > 0)
            {
                this.cbOutput.SelectedItem = this.cbOutput.Items[0];
            }
        }
    }
}
