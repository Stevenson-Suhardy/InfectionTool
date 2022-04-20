/* Author: Stevenson Suhardy
 * Date Created: March 20, 2022
 * Last Modified: March 21, 2022
 * App name: Contact Tracer
 * App description: An app that provides an entry for contacts and then list them to see if they are contacted or not in a listview box.
 * 
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
using System.Text.RegularExpressions;


namespace InfectionTool
{
    

    public partial class formContactTracer : Form
    {
        // Declare and initialize a list of Contact class
        List<Contact> contactList = new List<Contact>();
        // Declaring currentSelectedIndex variable to determine the current index in the selected item in the listview
        int currentSelectedIndex = -1;
        // Declaring boolean variable and initializing it to true. This variable will be used to disable and enable checkbox modify in listview
        bool disableChecking = true;
        // Declaring and initializing an array of textboxes
        TextBox[] inputTextBoxArray;
        
        public formContactTracer()
        {
            InitializeComponent();
            // Putting all input textbox inside the textbox array
            inputTextBoxArray = new TextBox[]
            {
                textBoxFirstName, textBoxLastName, textBoxEmail, textBoxPhoneNumber
            };
        }

        private static formContactTracer contactTracerInstance;
        public static formContactTracer Instance
        {
            get
            {
                if (contactTracerInstance == null)
                {
                    contactTracerInstance = new formContactTracer();
                }
                return contactTracerInstance;
            }
        }
        #region "Functions"
        /// <summary>
        /// This function is used to validate the input from the user so, the input will all be correct. It will display an error when the input is empty or in the wrong format or if the input contact already exists inside the list. This function will return true when everything is valid and false when something is invalid.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private bool ValidateContact(bool contacted, string firstName, string lastName, string email, string phoneNumber)
        {
            // Declaring variable isValid and set it to true
            bool isValid = true;

            // Checking all textboxes for errors
            // Checking the first name textbox if it is empty
            if (firstName == String.Empty)
            {
                labelOutput.Text += "You must enter a first name." + Environment.NewLine;
                textBoxFirstName.SelectAll();
                textBoxFirstName.Focus();
                isValid = false;
            }
            // Checking if it only has white spaces
            else if (firstName.Trim() == String.Empty)
            {
                // Print the following message when the condition is true
                labelOutput.Text += "First name can not be filled with white spaces only." + Environment.NewLine;
                // Selecting all text inside the first name textbox
                textBoxFirstName.SelectAll();
                // Changing focus back to first name textbox
                textBoxFirstName.Focus();
                // Setting isValid to false since it did not pass the condition
                isValid = false;
            }
            // Checking the last name textbox to see if it is empty
            if (lastName == String.Empty)
            {
                // Displaying the following message if the textbox is empty
                labelOutput.Text += "You must enter a last name." + Environment.NewLine;
                // Selecting all the contents inside the textbox
                textBoxLastName.SelectAll();
                // Changing focus to the last name textbox
                textBoxLastName.Focus();
                // isValid is now false
                isValid = false;
            }
            // Checking if the last name textbox only has white spaces
            else if (lastName.Trim() == String.Empty)
            {
                // Display the following message
                labelOutput.Text += "Last name can not be filled with white spaces only." + Environment.NewLine;
                // Selecting the contents of the last name textbox
                textBoxLastName.SelectAll();
                // Changing focus to the last name textbox
                textBoxLastName.Focus();
                // isValid is false so, the validation fails
                isValid = false;
            }
            // Checking if the email textbox is empty
            if (email == String.Empty)
            {
                // Display the following message
                labelOutput.Text += "You must enter an email address." + Environment.NewLine;
                // Selecting the text inside the email textbox
                textBoxEmail.SelectAll();
                // Changing focus to the email textbox
                textBoxEmail.Focus();
                // isValid is now false
                isValid = false;
            }
            // Checking to see if the email is in a valid format using Regex or Regular Expressions to ensure that it is a valid email address.
            else if (!Regex.IsMatch(email, "[A-Z0-9a-z._%+-]+@[A-Z0-9a-z0-9.-]+\\.[A-Za-z]{2,64}"))
            {
                // Display the following message
                labelOutput.Text += "The email address must be entered in a valid format." + Environment.NewLine;
                // Selecting the text inside the email textbox
                textBoxEmail.SelectAll();
                // Changing focus to the email textbox
                textBoxEmail.Focus();
                // isValid is false
                isValid = false;
            }
            // Checking the phone number textbox to see if it is empty
            if (phoneNumber == String.Empty)
            {
                // Display the following message
                labelOutput.Text += "You must enter a phone number." + Environment.NewLine;
                // Selecting text inside the phone number textbox
                textBoxPhoneNumber.SelectAll();
                // Changing focus to the phone number textbox
                textBoxPhoneNumber.Focus();
                // isValid is now false
                isValid = false;
            }
            // Checking if the phone number is in the correct format and has a total of 10 numbers using Regex or Regular Expressions.
            else if (!Regex.IsMatch(phoneNumber, "[0-9()-]{10,11}"))
            {
                // Display the following message
                labelOutput.Text += "The phone number must be in a valid format." + Environment.NewLine;
                // Selecting text inside the phone number textbox
                textBoxPhoneNumber.SelectAll();
                // Changing focus to the phone number textbox
                textBoxPhoneNumber.Focus();
                // isValid is now false
                isValid = false;
            }
            // Checking if it passes the input validation
            if (isValid)
            {
                // Creating a new object called newContact using all the passed value.
                Contact newContact = new Contact(contacted, firstName, lastName, email, phoneNumber);
                // Looping through the contactList
                foreach (Contact contact in contactList)
                {
                    // Checking if the contact already exist and the contact is not selected in the listview
                    if (contact.FirstName == newContact.FirstName && contact.LastName == newContact.LastName && (contact.EmailAddress == newContact.EmailAddress || contact.PhoneNumber == newContact.PhoneNumber) && listViewContact.FocusedItem == null)
                    {
                        // Display the following message
                        labelOutput.Text = "This contact already exists. You have added this contact on " + contact.DateToday.ToString();
                        // isValid is false
                        isValid = false;
                        // Break out of the loop
                        break;
                    }
                }
            }
            // Return the isValid value when validation is done
            return isValid;
        }
        /// <summary>
        /// This function will repopulate the list and updating it with the new values added by user.
        /// </summary>
        /// <param name="listOfContacts"></param>
        private void RepopulateList(List<Contact> listOfContacts)
        {
            // Clearing the listview
            listViewContact.Items.Clear();
            // Enable checking to modify the checkbox inside the listview
            disableChecking = false;
            // Loop through the passed in list
            foreach(Contact contact in listOfContacts)
            {
                // Creating a new listviewitem
                ListViewItem contactData = new ListViewItem();

                // Adding all the old and new values inside the list into the listviewitem subitems
                contactData.Checked = contact.StatusOfContact;
                contactData.SubItems.Add(contact.FirstName);
                contactData.SubItems.Add(contact.LastName);
                contactData.SubItems.Add(contact.DateToday.ToString());
                contactData.SubItems.Add(contact.EmailAddress);
                contactData.SubItems.Add(contact.PhoneNumber);

                // Adding the contactData to the listview to display the contents of the contactData
                listViewContact.Items.Add(contactData);
            }
            // Disable checking after the loop is done to prevent user from modifying checkbox in listview
            disableChecking = true;
        }
        /// <summary>
        /// Clears the text inside a control
        /// </summary>
        /// <param name="controlArray"></param>
        private void ResetControls(Control[] controlArray)
        {
            // Looping through the controls inside a controlArray
            foreach(Control control in controlArray)
            {
                // Setting the value of each text in the control to an empty string
                control.Text = String.Empty;
            }
        }
        /// <summary>
        /// Returns the state of the form into it's default value without clearing the listview or the list.
        /// </summary>
        private void SetDefault()
        {
            // Unselecting a selected line in the listview
            listViewContact.SelectedItems.Clear();
            // Emptying all strings inside all input textboxes
            ResetControls(inputTextBoxArray);
            // Unchecking the contacted checkbox
            checkBoxContacted.Checked = false;
            // Resetting the currentSelectedIndex back to -1
            currentSelectedIndex = -1;
            // Disable checking the checkbox in the listview
            disableChecking = true;
            // Emptying the output inside the output label
            labelOutput.Text = String.Empty;

            // Returning focus to the first name textbox
            textBoxFirstName.Focus();
        }

        #endregion

        #region "Event handlers"
        /// <summary>
        /// This event will occur when the user presses the exit button or the hotkey for the exit button and it will exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            // Closes the application
            Close();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            // Removing error messages inside the label
            labelOutput.Text = String.Empty;

            // Checking to see if the input is valid
            if (ValidateContact(checkBoxContacted.Checked, textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text))
            {
                // Creating a new object called addContact and passing in the input value by the user into the object
                Contact addContact = new Contact(checkBoxContacted.Checked, textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);
                // Checking to see if an index is selected in the listview (related to the selectedindexchanged event)
                if (currentSelectedIndex >= 0)
                {
                    // Modifying an existing contact and adding the updated one inside the current index
                    contactList[currentSelectedIndex] = addContact;
                    // Display the following message
                    labelOutput.Text = "Contact has been modified on " + addContact.DateToday.ToString() + ".";
                }
                else
                {
                    // If there are no index selected then, add the new contact into the list
                    contactList.Add(addContact);
                    // Display the following message
                    labelOutput.Text = "Added a new contact into the list on " + addContact.DateToday.ToString() + ".";
                    ResetControls(inputTextBoxArray);
                }
                // Updating the list and listview
                RepopulateList(contactList);
            }
        }
        /// <summary>
        /// This event handler will occur when a row is selected in the listview. It will pass in the values of the row into the textboxes and allow the user to modify them in the textbox and update any information.
        /// </summary>
        private void ListViewContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking to see if the contacts in the listview is more than 0 and the selected row is not null in the listview
            if(listViewContact.Items.Count > 0 && listViewContact.FocusedItem != null )
            {
                // Passing the values inside the listview into the textboxes and checkbox
                checkBoxContacted.Checked = listViewContact.FocusedItem.Checked;
                textBoxFirstName.Text = listViewContact.FocusedItem.SubItems[1].Text;
                textBoxLastName.Text = listViewContact.FocusedItem.SubItems[2].Text;
                textBoxEmail.Text = listViewContact.FocusedItem.SubItems[4].Text;
                textBoxPhoneNumber.Text = listViewContact.FocusedItem.SubItems[5].Text;
                // currentSelectedIndex is now the selected index on the listview
                currentSelectedIndex = listViewContact.FocusedItem.Index;
                // If the currentSelected index is more than equal to 0
                if(currentSelectedIndex >= 0)
                {
                    // Display the information of the contact
                    labelOutput.Text = contactList[currentSelectedIndex].GetStatus();
                }
                else
                {
                    // Remove text inside the labelOutput
                    labelOutput.Text = String.Empty;
                }
            }
            else
            {
                // Set the currentSelectedIndex to -1 when nothing is selected
                currentSelectedIndex = -1;
            }
        }
        /// <summary>
        /// This event handler occurs when the user tries to check or uncheck the checkboxes inside the listview.
        /// </summary>
        private void ListViewContact_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Checking to see if currently the check is disabled
            if(disableChecking)
            {
                // If it is, then whether the user checks or uncheckes the checkbox, the value of the checkbox will remain the same.
                e.NewValue = e.CurrentValue;
            }
        }
        /// <summary>
        /// This event occurs when the user presses the escape key or click the reset button. This event will restore the form to it's original state without deleting the existing listview or list.
        /// </summary>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // Calling the SetDefault function
            SetDefault();
        }
        #endregion

        private void formContactTracer_FormClosed(object sender, FormClosedEventArgs e)
        {
            contactTracerInstance = null;
        }
    }
}