/* Author: Stevenson Suhardy
 * Contact Class
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectionTool
{
    // Declaring a new class called Contact
    class Contact
    {
        // Private variables for the class
        private static int count = 0;
        private int id = 0;
        private string firstName = String.Empty;
        private string lastName = String.Empty;
        private string email = String.Empty;
        private string phoneNumber = String.Empty;
        private DateTime date = DateTime.Now;
        private bool contactStatus = false;

        // Default constructor
        public Contact()
        {
            count += 1;
            id = count;
        }
        // Parameterized constructor
        public Contact(bool contactStatus, string firstName, string lastName, string email, string phoneNumber): this()
        {
            this.contactStatus = contactStatus;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        #region "Long-Hand Properties"
        /// <summary>
        /// A boolean value indicating whether the person has been contacted or not.
        /// </summary>
        public bool StatusOfContact
        {
            get
            {
                return contactStatus;
            }
            set
            {
                contactStatus = value;
            }
        }
        /// <summary>
        /// The contact's first name.
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        /// <summary>
        /// The contact's last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        /// <summary>
        /// The date that the contact was entered.
        /// </summary>
        public DateTime DateToday
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        /// <summary>
        /// The contact's email address. In this case, validation will be handled by the form.
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        /// <summary>
        /// The contact's phone number. The validation is not done here, but rather on the form.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        #endregion
        /// <summary>
        /// This method returns an output string based on the contactStatus of the contact when called.
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            if (contactStatus)
            {
                return firstName + " " + lastName + " (" + email + " / " + phoneNumber + ")" + " from " + date + " has been contacted.";
            }
            else
            {
                return firstName + " " + lastName + " (" + email + " / " + phoneNumber + ")" + " from " + date + " has not been contacted.";
            }
        }
    }
}
