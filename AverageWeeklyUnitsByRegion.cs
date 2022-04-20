/* Author: Stevenson Suhardy
 * Date Created: February 28, 2022
 * Last Modified: February 28, 2022
 * App name: Average Weekly Units By Region
 * Description: This app will store all the past 7 days entries of each region and calculates the average of each region and also the overall average.
 */

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
    public partial class formAverageWeeklyUnitsByRegion : Form
    {
        // Initializing the following arrays, 2d arrays, and labels
        TextBox[] textBoxArray;
        int[,] unitsArray = new int[3, 7];
        Label[] outputLabelArray;
        Label region1;
        Label region2;
        Label region3;

        public formAverageWeeklyUnitsByRegion()
        {
            InitializeComponent();
        }

        private static formAverageWeeklyUnitsByRegion averageWeeklyUnitsInstance;
        public static formAverageWeeklyUnitsByRegion Instance
        {
            get
            {
                if (averageWeeklyUnitsInstance == null)
                {
                    averageWeeklyUnitsInstance = new formAverageWeeklyUnitsByRegion();
                }
                return averageWeeklyUnitsInstance;
            }
        }

        /// <summary>
        /// This event handler will occur when the Exit button is clicked and it will close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Close();
        }

        private void FormAverageWeeklyUnitsByRegion_Load(object sender, EventArgs e)
        {
            // Removing the labels on the form (I added these to the form because people might think I forgot to add this when they see the design form)
            this.Controls.Remove(labelRegion1);
            this.Controls.Remove(labelRegion2);
            this.Controls.Remove(labelRegion3);
            // Adding the textboxes and output labels to their own arrays
            textBoxArray = new TextBox[]
            {
                textBoxCases, textBoxRegion1Units, textBoxRegion2Units, textBoxRegion3Units
            };
            outputLabelArray = new Label[]
            {
                labelAverageRegion1, labelAverageRegion2, labelAverageRegion3
            };
            // Resets form when the app loads
            ResetForm();
        }
        // Variable and constant declarations
        const int minNumberOfUnits = 0;
        const int maxNumberOfUnits = int.MaxValue;
        const int totalDays = 7;
        const int region1Index = 0;
        const int region2Index = 1;
        const int region3Index = 2;
        const int maxDayIndex = 6;
        int currentRegion = 0;
        int currentDay = 0;
        double region1Average;
        double region2Average;
        double region3Average;
        double totalAverage;
        /// <summary>
        /// This event handler will occur when the enter button is pressed or pressing the enter key on the keyboard. It will validate the input and displaying the past entries that the user made and calculating the average unit for the region when the user have entered 7 entries for the region. After all 3 regions have 7 entries, it will calculate the total average for all regions and coloring the output region labels differently depending on the region's average (less than or greater than the total average).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            // Calling the ValidateInput function to validate the input and proceeds if the function returns true
            if (ValidateInput(textBoxCases))
            {
                // Clearing the textbox
                textBoxCases.Text = string.Empty;
                // Storing the input inside the array
                unitsArray[currentRegion, currentDay] = inputUnit;
                // When the currentRegion is 0 then proceed
                if (currentRegion == region1Index)
                {
                    // Displaying the entry in the textbox of region 1
                    textBoxRegion1Units.AppendText(Convert.ToString(inputUnit));
                    // Creating a new line
                    textBoxRegion1Units.AppendText("\r\n");
                    // Checking to see if it already has 7 entries.
                    if (currentDay == maxDayIndex)
                    {
                        // Calculating the average of the region 1 using the values stored in the array
                           // Looping through the column, no need to loop through the row since it is always the same
                        for (int column = 0; column <= unitsArray.GetUpperBound(1); column++)
                        {
                            // Adding the values to the region1Average variable
                            region1Average += unitsArray[region1Index, column];
                        }
                        // Incrementing the currentRegion since there are already 7 entries
                        currentRegion++;
                        // Resetting the currentDay
                        currentDay = 0;
                        // Calculating the average for region 1
                        region1Average = Average(region1Average);
                        // Displaying the average
                        labelAverageRegion1.Text = String.Format("Average: {0}", region1Average);
                        // Adjusting the labels and removing bold on the region 1 label and adding bold to the next label which is region 2
                        NormalRegion1();
                        // Removing the old region2 label
                        BoldRegion2();
                    }
                    else
                    {
                        // Incrementing the current day if it is still not the 7th day
                        currentDay++;
                    }
                }
                // Checking to see if the currentRegion is the region 2
                else if (currentRegion == region2Index)
                {
                    // Displaying the entry in the region 2 textbox
                    textBoxRegion2Units.AppendText(Convert.ToString(inputUnit));
                    // Creating a new line
                    textBoxRegion2Units.AppendText("\r\n");
                    // Checking to see if the current day is already the 7th day
                    if (currentDay == maxDayIndex)
                    {
                        // Looping through the column
                        for (int column = 0; column <= unitsArray.GetUpperBound(1); column++)
                        {
                            // Adding all the values in region2 to the region2average variable
                            region2Average += unitsArray[region2Index, column];
                        }
                        // Incrementing the currentRegion
                        currentRegion++;
                        // Resetting the currentDay back to 0
                        currentDay = 0;
                        // Calculating the average of region2
                        region2Average = Average(region2Average);
                        // Displaying the average of region2
                        labelAverageRegion2.Text = String.Format("Average: {0}", region2Average);
                        // Adjusting labels by removing and adding the updated region 2 and region 3
                        NormalRegion2();
                        BoldRegion3();
                    }
                    else
                    {
                        // Incrementing the currentDay if it is not the 7th day yet
                        currentDay++;
                    }
                }
                // Checking to see if the current region is region 3
                else if (currentRegion == region3Index)
                {
                    // Displaying the entry
                    textBoxRegion3Units.AppendText(Convert.ToString(inputUnit));
                    // Creating a new line
                    textBoxRegion3Units.AppendText("\r\n");
                    // Checking to see if the currentDay is the 7th day
                    if (currentDay == maxDayIndex)
                    {
                        // Looping through the column of the region 3 row
                        for (int column = 0; column <= unitsArray.GetUpperBound(1); column++)
                        {
                            // Adding the values of region3 to the region3Average variable
                            region3Average += unitsArray[region3Index, column];
                        }
                        // Calculating the average of region 3
                        region3Average = Average(region3Average);
                        // Displaying the region 3 average
                        labelAverageRegion3.Text = String.Format("Average: {0}", region3Average);
                        // Looping through the whole 2d array
                        for (int row = 0; row <= unitsArray.GetUpperBound(0); row++)
                        {
                            for (int column = 0; column <= unitsArray.GetUpperBound(1); column++)
                            {
                                // Adding all the values inside the array to the totalAverage Variable
                                totalAverage += unitsArray[row, column];
                            }
                        }
                        // Calculating the totalAverage and dividing it by the array length
                        totalAverage /= unitsArray.Length;
                        // Rounding the result to 2 decimal places
                        totalAverage = Math.Round(totalAverage, 2);
                        // Displaying the result in the label
                        labelAverageThisWeek.Text = String.Format("Average this week: {0}", totalAverage);
                        // Adjusting the labels by removing and adding the new updated labels for region 3
                        NormalRegion3();
                        // Disabling the enter button
                        buttonEnter.Enabled = false;
                        // Preventing the user to type into the input textbox by making it read only
                        textBoxCases.ReadOnly = true;
                        buttonReset.Focus();
                        // Comparing the region 1, 2 and 3 average to the totalAverage. Depends on the units shipped in each region, it will either change to the color red (when region average is higher than the total average) or color green (when region average is lower than the total average)
                        if (totalAverage > region1Average)
                        {
                            labelAverageRegion1.BackColor = Color.Red;
                        }
                        else
                        {
                            labelAverageRegion1.BackColor = Color.Green;
                        }
                        if (totalAverage > region2Average)
                        {
                            labelAverageRegion2.BackColor = Color.Red;
                        }
                        else
                        {
                            labelAverageRegion2.BackColor = Color.Green;
                        }
                        if (totalAverage > region3Average)
                        {
                            labelAverageRegion3.BackColor = Color.Red;
                        }
                        else
                        {
                            labelAverageRegion3.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        // Incrementing the currentDay if it is not the 7th day yet
                        currentDay++;
                    }
                }
            }
        }
        /// <summary>
        /// Resetting the form when the reset button or escape key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Calls the ResetForm() function
            ResetForm();
        }
        /// <summary>
        /// Resetting the form to it's default state
        /// </summary>
        #region "Functions"
        private void ResetForm()
        {
            // Clearing the controls
            ClearControls(textBoxArray);
            ClearControls(outputLabelArray);
            labelAverageThisWeek.Text = string.Empty;
            // Resetting the variables back to 0
            currentDay = 0;
            currentRegion = 0;
            region1Average = 0;
            region2Average = 0;
            region3Average = 0;
            totalAverage = 0;

            BoldRegion1();
            NormalRegion2();
            NormalRegion3();

            // Changing the output label's color back to default
            foreach(Label labelToChange in outputLabelArray)
            {
                labelToChange.BackColor = this.BackColor;
            }
            // Enabling the disabled controls
            buttonEnter.Enabled = true;
            textBoxCases.ReadOnly = false;
            // Changing the focus back to the input textbox
            textBoxCases.Focus();
        }
        /// <summary>
        /// Clearing the control inside an array
        /// </summary>
        /// <param name="controlArray"></param>
        private void ClearControls(Control[] controlArray)
        {
            // Loop through the array
            foreach (Control controlToClear in controlArray)
            {
                // Clear all the text inside the control
                controlToClear.Text = String.Empty;
            }
        }
        /// <summary>
        /// Validates the user's input and show an error messagebox when the input is invalid
        /// </summary>
        // Declaring variable to store the input
        int inputUnit;
        private bool ValidateInput(TextBox textBoxInput)
        {
            // Declaring isValid to be false
            bool isValid = false;
            // Checking to see if the input is a whole number or not
            if (int.TryParse(textBoxInput.Text, out inputUnit))
            {
                // Checking to see if it is inside the valid range
                if (inputUnit >= minNumberOfUnits && inputUnit < maxNumberOfUnits)
                {
                    // Changing the value to true when it passes the validation
                    isValid = true;
                }
                // Display the following error messagebox when it is outside the valid range
                else
                {
                    // Display the following messagebox
                    MessageBox.Show(String.Format("Please enter a number at least {0} and less than {1}", minNumberOfUnits, maxNumberOfUnits
                        ), "INVALID INPUT RANGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    // Change the focus to the input textbox
                    textBoxCases.Focus();
                }
            }
            // Display the following error messagebox when the input is not a whole number
            else
            {
                // Display the following messagebox
                MessageBox.Show("Please enter a whole number", "INVALID INPUT DATA TYPE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                // Change the focus to the input textbox
                textBoxCases.Focus();
            }
            return isValid;
        }
        /// <summary>
        /// Calculates the average of a region
        /// </summary>
        /// <param name="average"></param>
        /// <returns></returns>
        private double Average(double average)
        {
            average /= totalDays;
            average = Math.Round(average, 2);
            return average;
        }
        /// <summary>
        /// Bolds the region1 label
        /// </summary>
        private void BoldRegion1() {
            this.Controls.Remove(region1);

            region1 = new Label
            {
                Location = new Point(43, 62),
                AutoSize = true,
                Name = "labelRegion1",
                Text = "Region &1",
                Font = new Font(Label.DefaultFont, FontStyle.Bold)
            };

            this.Controls.Add(region1);
        }

        /// <summary>
        /// Bolds the region2 label
        /// </summary>
        private void BoldRegion2() {
            this.Controls.Remove(region2);

            region2 = new Label
            {
                Location = new Point(182, 62),
                AutoSize = true,
                Name = "labelRegion2",
                Text = "Region &2",
                Font = new Font(Label.DefaultFont, FontStyle.Bold)
            };

            this.Controls.Add(region2);
        }
        /// <summary>
        /// Bolds the region3 label
        /// </summary>
        private void BoldRegion3() {

            this.Controls.Remove(region3);

            region3 = new Label
            {
                Location = new Point(324, 62),
                AutoSize = true,
                Name = "labelRegion3",
                Text = "Region &3",
                Font = new Font(Label.DefaultFont, FontStyle.Bold)
            };

            this.Controls.Add(region3);
        }

        /// <summary>
        /// Unbold the region1 label
        /// </summary>
        private void NormalRegion1()
        {
            this.Controls.Remove(region1);

            region1 = new Label
            {
                Location = new Point(43, 62),
                AutoSize = true,
                Name = "labelRegion1",
                Text = "Region &1",
                Font = new Font(Label.DefaultFont, FontStyle.Regular)
            };

            this.Controls.Add(region1);
        }

        /// <summary>
        /// Unbold the region2 label
        /// </summary>
        private void NormalRegion2()
        {
            this.Controls.Remove(region2);

            region2 = new Label
            {
                Location = new Point(182, 62),
                AutoSize = true,
                Name = "labelRegion2",
                Text = "Region &2",
                Font = new Font(Label.DefaultFont, FontStyle.Regular)
            };

            this.Controls.Add(region2);
        }

        /// <summary>
        /// Unbold the region3 label
        /// </summary>
        private void NormalRegion3()
        {
            this.Controls.Remove(region3);

            region3 = new Label
            {
                Location = new Point(324, 62),
                AutoSize = true,
                Name = "labelRegion3",
                Text = "Region &3",
                Font = new Font(Label.DefaultFont, FontStyle.Regular)
            };

            this.Controls.Add(region3);
        }

        #endregion

        private void formAverageWeeklyUnitsByRegion_FormClosed(object sender, FormClosedEventArgs e)
        {
            averageWeeklyUnitsInstance = null;
        }
    }
}
