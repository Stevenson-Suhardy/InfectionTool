/* Author: Stevenson Suhardy & Ethan Chen
 * Date Created: April 8, 2022
 * Application Name: Infection Tool
 * Application Description: This application is a combined project between Stevenson Suhardy & Ethan Chen for the final project of NETD 2022 in Durham College. This project combines everything that we did for the semester and put it into a single MDI application.
 * 
 * 
 */

namespace InfectionTool
{
    public partial class formParent : Form
    {
        // Declaring constant for the default file name of a text editor
        const string DefaultFileName = "Untitled.txt";
        public formParent()
        {
            InitializeComponent();
        }
        #region "Event Handlers"
        /// <summary>
        /// This event handler occurs when the user clicks the new button in the menu strip or press the access key or hotkey set. This event handler will create a new text editor file inside the formParent and does not allow the menu strip to merge. Then show the form inside the MdiParent.
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a new form
            var editor = new formTextEditorPad();
            // Setting the MdiParent to the formParent
            editor.MdiParent = this;
            // Disabling menu strip merge
            menuStripInfection.AllowMerge = false;
            // Showing the form inside MdiParent
            editor.Show();
        }
        /// <summary>
        /// This event handler will occur when the user clicks the cascade button or use the access key or hotkey. This will layout every form opened into cascade style.
        /// </summary>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Automatically assigning forms to be in cascade layout
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// This event handler will occur when the user clicks the Tile Horizontal button in the menu strip or clicks the access key or hotkey for the button. This will layout all open forms in a Tile Horizontal style.
        /// </summary>
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Automatically layouts all open forms to be in Tile Horizontal
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Tile Vertical button in the menu strip or clicks the access key or hotkey for the button. This will layout all open forms in a Tile Vertical style.
        /// </summary>
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Automatically layouts all open forms to be in Tile Vertical
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Open Contact Tracer button or clicks the access key or hotkey for the button. This event handler will open a new Contact Tracer form, sets the MdiParent to be the formParent and shows the form.
        /// </summary>
        private void contactTracerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formContactTracer contactTracerForm = formContactTracer.Instance;
            // Make the new form a child form.
            contactTracerForm.MdiParent = this;
            contactTracerForm.Show(); // Show the new form.
            contactTracerForm.Focus();
        }
        /// <summary>
        /// This event handler occurs when the user clicks the Open Average Cases button or clicks the access key or hotkey for the button. It will generate an Average Weekly Units By Region form and put it inside the application.
        /// </summary>
        private void averageCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAverageWeeklyUnitsByRegion averageWeeklyUnitsForm = formAverageWeeklyUnitsByRegion.Instance;
            // Make the new form a child form.
            averageWeeklyUnitsForm.MdiParent = this;
            averageWeeklyUnitsForm.Show(); // Show the new form.
            averageWeeklyUnitsForm.Focus(); // Focuses on the form.
        }
        /// <summary>
        /// This event handler occurs when the user clicks the Exit button or clicks the access key or hotkey for the button. It will close the main application as well as all the application within the MdiParent.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes all the application including the parent application
            Close();
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Close button or clicks the access key or hotkey for it. This will close the selected form inside the MdiParent only without interfering with other MdiChild.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildValidation())
            {
                var closeForm = (formTextEditorPad)this.ActiveMdiChild;
                closeForm.ExitToolStripMenuItem_Click(sender, e);
            }
            else
            {
                this.ActiveMdiChild.Close();
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Open button or clicks the access key or hotkey for the button. This will either create a new form when there are no active forms, or overwrite the current form or generate an error message if the file is not a text editor.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checking to see if there is any acitve mdi child
            if (this.ActiveMdiChild == null)
            {
                // Create a new text editor form
                var openForm = new formTextEditorPad();

                // Disabling menu strip merge
                menuStripInfection.AllowMerge = false;
                // Set the MdiParent to formParent
                openForm.MdiParent = this;
                // Calling the open event handler from the formTextEditorPad
                openForm.OpenToolStripMenuItem_Click(sender, e);
                // If the openForm does not have a default file name
                if (openForm.fileName != DefaultFileName)
                {
                    // Show the form
                    openForm.Show();
                }
            }
            // Checks to see if the active mdi child is a text editor or not
            else if (this.ActiveMdiChild.GetType() == typeof(formTextEditorPad))
            {
                // Treats the current active mdi child like a text editor form
                var openForm = (formTextEditorPad)this.ActiveMdiChild;
                // Calls the open event handler from the text editor form
                openForm.OpenToolStripMenuItem_Click(sender, e);
            }
            else
            {
                // Display the following messagebox
                MessageBox.Show("You are not able to open this type of file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the save button or clicks the access key or hotkey for the button. This event handler will check whether there is an active mdi child and if it is text editor. If it is, then allow to save the file.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validates the Active Mdi Child
            if (MdiChildValidation())
            {
                // Treats the form like a text editor
                var saveForm = (formTextEditorPad)this.ActiveMdiChild;
                // Call the save event handler from text editor form
                saveForm.SaveToolStripMenuItem_Click(sender, e);
            }
            else
            {
                // Display the following message box
                MessageBox.Show("You are not able to save any file other than the text file", "Invalid Save Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Save As button or clicks the access key or hotkey for the button. This event is the same thing as the Save event but, it will always open a save file dialog instead of saving it instantly when it already has a path.
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validates the active mdi child
            if (MdiChildValidation())
            {
                // Treats the form like a text editor
                var saveAsForm = (formTextEditorPad)this.ActiveMdiChild;
                // Call the Save As event from the form
                saveAsForm.SaveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                // Display the following messagebox
                MessageBox.Show("You are not able to save any file other than the text file", "Invalid Save Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the select all button or click the access key or hotkey for the button. It will select all the text inside the textbox in the text editor after going through some validation.
        /// </summary>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validates the active mdi child
            if (MdiChildValidation())
            {
                // Treats the form like a text editor
                var selectAllForm = (formTextEditorPad)this.ActiveMdiChild;
                // Calls the select all event handler
                selectAllForm.SelectAllToolStripMenuItem_Click(sender, e);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the cut button or click the access key or hotkey for the button. It will store the selected text in the clipboard  and delete in from the textbox.
        /// </summary>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validates the active mdi child
            if (MdiChildValidation())
            {
                // Treats the form like a text editor
                var cutForm = (formTextEditorPad)this.ActiveMdiChild;
                // Calls the cut event handler
                cutForm.CutToolStripMenuItem_Click(sender, e);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the copy button or click the access key or hotkey for the button. It will store the selected text in the clipboard.
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validates the active mdi child
            if (MdiChildValidation())
            {
                // Treats the form like a text editor
                var copyForm = (formTextEditorPad)this.ActiveMdiChild;
                // Calls the copy event handler
                copyForm.CopyToolStripMenuItem_Click(sender, e);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the paste button or click the access key or hotkey for the button. It will write the text stored in the clipboard to the textbox in the text editor
        /// </summary>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validates the active mdi child
            if (MdiChildValidation())
            {
                // Treats the form like a text editor
                var pasteForm = (formTextEditorPad)this.ActiveMdiChild;
                // Calls the paste event handler
                pasteForm.PasteToolStripMenuItem_Click(sender, e);
            }
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Open Weekly Temperature or click the access key or hotkey for the button. It will open a new weekly temperature form and set the mdi parent to formParent and show the form inside.
        /// </summary>
        private void weeklyTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formWeeklyTemperature weekTempForm = formWeeklyTemperature.Instance;
            // Make the new form a child form.
            weekTempForm.MdiParent = this;
            weekTempForm.Show(); // Show the new form.
            weekTempForm.Focus(); // Focuses on the form
        }
        /// <summary>
        /// This event handler will occur when the user clicks the Open Customer Entry or click the access key or hotkey for the button. It will open a new customer entry form and set the mdi parent to formParent and show the form inside.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCustomerEntry customerEntryForm = formCustomerEntry.Instance;
            // Make the new form a child form.
            customerEntryForm.MdiParent = this;
            customerEntryForm.Show(); // Show the new form.
            customerEntryForm.Focus(); // Focuses on the form
        }

        /// <summary>
        /// This event handler will occur when the user clicks about button or click the access key or hotkey for the button. This will display a messagebox about what this application is all about and who created this application.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the following message box
            MessageBox.Show("NETD-2202\n\nFinal Project: Infection Tool\nThis is our final project of NETD-2202 Course Semester 2. This is a combined project and everything that we did in this semester is combined into a single working application. Hope you enjoy it!\n\n Created by Stevenson Suhardy & Ethan Chen on April 8, 2022 \n\n Modified on April 20, 2022 \n\n Submitted on April 20, 2022 at 3:50PM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region "Functions"
        /// <summary>
        /// This function will check whether the current active mdi child is a text editor or not
        /// </summary>
        /// <returns></returns>
        private bool MdiChildValidation()
        {
            // Checks to see if there are any active mdi child opened
            if (this.ActiveMdiChild != null)
            {
                // Checks if it is a text editor
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditorPad))
                {
                    // return true if so
                    return true;
                }
                else
                {
                    // return false if anything is not valid
                    return false;
                }
            }
            else
            {
                // return false if anything is not valid
                return false;
            }
        }
        #endregion
    }
}