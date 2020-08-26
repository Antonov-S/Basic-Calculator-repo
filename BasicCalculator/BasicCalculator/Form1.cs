using System;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Defoult constructor
        /// </summary>

        public Form1()
        {
            InitializeComponent();

            
        }
        #endregion

        #region Clearing Methods
        
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            // Delete the value after the selected position
            DeleteTextValue();

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Operator Methods

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            // Focus the user input text
            FocusInputText();
        }

        
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            // Focus the user input text
            FocusInputText();
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            // Focus the user input text
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            // Focus the user input text
            FocusInputText();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

        }

        
        #endregion

        #region Number Methods
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            // Focus the user input text
            FocusInputText();
        }

        

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            // Focus the user input text
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            // Focus the user input text
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            // Focus the user input text
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            // Focus the user input text
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            // Focus the user input text
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            // Focus the user input text
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            // Focus the user input text
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            // Focus the user input text
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            // Focus the user input text
            FocusInputText();
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            // Focus the user input text
            FocusInputText();
        }
        #endregion

        #region Private Helpers
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into user text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;
            
            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection lenght to zero
            this.UserInputText.SelectionLength = 0;
        }


        /// <summary>
        /// Deletes the charecter to the right on the selection start of the user input text box 
        /// </summary>
        private void DeleteTextValue()
        {
            // If we dont have a value to delete, return
            if (this.UserInputText.SelectionStart == 0 || (this.UserInputText.SelectionStart > this.UserInputText.TextLength))
                return;


            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Deletes the charecter to the right on the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart - 1, 1);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection lenght to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            // TODO: finish!
            // Focus the user input text
            FocusInputText();
        }
        #endregion
    }
}
