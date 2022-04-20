// Author: Stevenson Suhardy
// Last Modified: February 5, 2022
//
// Original Author: Kyle Chapman
// Created:  January 2022
// Modified: 
//
// Description:
//  A form that allows entry of 7 days of temperature values.
//  Each week an average is calculated. After week 1, the average temperature
//  value is compared to the average temperature value from the previous week
//  and a message is generated based on this. Functionality to reset and exit
//  the form is also available.
    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfectionTool
{
    public partial class formWeeklyTemperature : Form
    {
        public formWeeklyTemperature()
        {
            InitializeComponent();
        }
        private static formWeeklyTemperature weeklyTempInstance;
        public static formWeeklyTemperature Instance
        {
            get
            {
                if (weeklyTempInstance == null)
                {
                    weeklyTempInstance = new formWeeklyTemperature();
                }
                return weeklyTempInstance;
            }
        }


        #region "Variable Declarations"
        // Variable declarations
        // Declare an array referring to the list of textboxes on the form.
        // This allows these to be quickly validated and/or cleared iteratively.
        TextBox[] inputTextBoxArray;

        int week = 1;
        double totalTemperature = 0;
        double lastWeekAverage = 0;

        #endregion

        #region "Event Handlers"
        /// <summary>
        /// When the form loads, assign values to the arrays based on the textboxes on the form.
        /// Note that assigning this would not work before the form was loaded, so it is done on load.
        /// </summary>
        private void FormLoad(object sender, EventArgs e)
        {
            inputTextBoxArray = new TextBox[] {textBoxDay1, textBoxDay2, textBoxDay3, textBoxDay4, textBoxDay5, textBoxDay6, textBoxDay7 };
            SetDefaults();
        }

        /// <summary>
        /// The ButtonCalculateClick event or when the user presses the calculate button or enter button, it will declare 2 variables
        /// (averageTemperature, and validTextboxes) and then looping through the array of textboxes (inputTextBoxArray) and using the
        /// ValidateTextbox function, it will validate whether the input of the textbox is numerical or not, if the input is correct,
        /// the validTextboxes will be incremented by 1 in order to see how many textboxes are valid up until 7. If one is not correct,
        /// an error message will be displayed from the ValidateTextBox function and if all 7 textboxes are correct, the program will
        /// continue. After that, the error messages are cleared, and the totaltemperature that is calculated in the ValidateTextbox
        /// function, will be divided with the length of the inputTextBox array (which is 7) and rounded to 2 decimals, then stored in the
        /// averageTemperature variable.
        /// 
        /// Next, the program checks whether the week is greater than 1. If so, the program will decide whether the temperature from this
        /// week or last week is greater or lower or even the same temperature and display the appropriate message depending on the result.
        /// The week variable will be incremented by 1 in order to go to the next following week, and display the new week. All the results
        /// like, averageTemperature are displayed and the current averageTemperature will be stored in the lastWeekTemperature to compare
        /// with the next week temperature. The last thing is all textbox inside the array is disabled using SetControlsEnabled function and 
        /// the calculate button is disabled, the focus changed to reset button and the user have to click the reset button to continue or 
        /// the user can exit the application.
        /// </summary>
        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            // Note that this code is DONE, but it is very dependent on the completion of the
            // ValidateTextbox function included below.
            // This event handler should not need to be modified at all. PROBABLY.

            // Variable declarations.
            double averageTemperature = 0;
            int validTextboxes = 0;

            // Loop through the inputTextBoxArray and check that each textbox is valid.
            // Note that this uses the ValidateTextbox() function.
            foreach(TextBox textBoxToCheck in inputTextBoxArray)
            {
                // If the textbox is valid, count it. If not, just don't.
                if (ValidateTextbox(textBoxToCheck))
                {
                    validTextboxes++;
                }
            }

            // Check if the Textboxes all have valid content.
            if (validTextboxes == inputTextBoxArray.Length)
            {
                // Clear the error messages.
                textBoxResult.Clear();

                // Make sure totalTemperature has been incremented to include all entered values.
                // I chose to do it as part of ValidateTextbox but you could also do it here.

                // Textboxes are valid; calculate the average temperature!
                averageTemperature = Math.Round(totalTemperature / inputTextBoxArray.Length, 2);

                // Check if it's after week 1.
                if (week > 1)
                {
                    // Determine whether this week is warmer or colder and output a message.
                    if (averageTemperature > lastWeekAverage)
                    {
                        textBoxResult.Text = "The week " + week + " average of " + averageTemperature + " is higher than the previous average of " + lastWeekAverage + ".";
                    }
                    else if (averageTemperature < lastWeekAverage)
                    {
                        textBoxResult.Text = "The week " + week + " average of " + averageTemperature + " is lower than the previous average of " + lastWeekAverage + ".";
                    }
                    else
                    {
                        textBoxResult.Text = "The week " + week + " average of " + averageTemperature + " is the same as last week's average.";
                    }
                }

                // Increment the week.
                week += 1;
                labelWeek.Text = "Week " + week;

                // Display the week's average, and store it for next week.
                textBoxAverageOutput.Text = averageTemperature.ToString();
                lastWeekAverage = averageTemperature;

                // Disable input controls until the form is reset.
                buttonCalculate.Enabled = false;
                SetControlsEnabled(inputTextBoxArray, false);
                buttonReset.Focus();
            }
            
            // You could write an "else" statement here indicating what would happen
            // if the validation failed, but you don't need to if you've done error
            // messaging and/or other things like that in the ValidateTextbox()
            // function.
        }

        /// <summary>
        /// The ButtonResetClick event or when the user clicks the reset button or escape button, this will call the SetDefaults function, 
        /// which will reset every input or changes made by the user to default.
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// The ButtonExitClick event will allow the user to exit from the application when pressing the ext button.
        /// </summary>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region "Functions"

        /// <summary>
        /// The ClearControls function will ask an array parameter. This function allows the user to clear the text inside all the textbox
        /// inside the array.
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// The SetControlsEnables function will ask for an array parameter and a boolean value parameter and this will allow the user
        /// to enable or disable the text boxes inside an array like, enabling all the textboxes inside the inputTextBoxArray by typing
        /// SetControlsEnabled(inputTextBoxArray, true);.
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;
            }
        }

        /// <summary>
        /// Clears input and output, re-enables controls, sets the form to its default state.
        /// </summary>
        private void SetDefaults()
        {
            // Clear input and output fields.
            ClearControls(inputTextBoxArray); // Calls a function to empty all input textboxes.

            // TODO: What other controls need to be cleared?
            textBoxAverageOutput.Text = string.Empty;
            textBoxResult.Text = string.Empty;
            // Don't reset the week to 1; that really messes up the "last week's temperature" feature.

            // TODO: Re-enable any controls that may be disabled.
            buttonCalculate.Enabled = true;
            // Consider using the SetControlsEnabled for part of this.
            SetControlsEnabled(inputTextBoxArray, true);
            // Set focus in some kind of useful way.
            textBoxDay1.Focus();
            totalTemperature = 0;
        }

        /// <summary>
        /// This validates a single textbox on the form.
        /// </summary>
        /// <param name="textBoxInput">Textbox to validate</param>
        /// <returns>true if the textbox is valid, false if not</returns>
        private bool ValidateTextbox(TextBox textBoxInput)
        {
            // Variable declarations.
            double inputTemperature;
            
            // The variable isValid represents the return value of this function.
            // You could start it as "true" or "false".
            // I wrote "false" here but I might change my mind during class.
            bool isValid = false;

            // TODO: Complete this function.
            // Check whether textBoxInput.Text is a valid number and attempt to store it in inputTemperature.
            // If it is, return true.
            // If not, write an error message and then return false.

            if (double.TryParse(textBoxInput.Text, out inputTemperature))
            {
                isValid = true;
                totalTemperature += inputTemperature;
            }
            else
            {
                isValid = false;
                textBoxResult.Text += "The entered value of '" + textBoxInput.Text + "' is not valid. Please enter a numeric temperature.\r\n";
            }

            return isValid;
        }

        #endregion

        private void formWeeklyTemperature_FormClosed(object sender, FormClosedEventArgs e)
        {
            weeklyTempInstance = null;
        }
    }
}
