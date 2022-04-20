namespace InfectionTool
{
    partial class formContactTracer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelContacted = new System.Windows.Forms.Label();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.listViewContact = new System.Windows.Forms.ListView();
            this.columnContacted = new System.Windows.Forms.ColumnHeader();
            this.columnFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnLastName = new System.Windows.Forms.ColumnHeader();
            this.columnDate = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(138, 9);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(83, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "&First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(138, 42);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "&Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(114, 72);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(106, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email &Address:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(109, 105);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(111, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "&Phone Number:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelContacted
            // 
            this.labelContacted.Location = new System.Drawing.Point(133, 135);
            this.labelContacted.Name = "labelContacted";
            this.labelContacted.Size = new System.Drawing.Size(87, 20);
            this.labelContacted.TabIndex = 8;
            this.labelContacted.Text = "&Contacted?:";
            this.labelContacted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.AutoSize = true;
            this.checkBoxContacted.Location = new System.Drawing.Point(226, 138);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxContacted.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Enter their contact status whether user has contacted them or not");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(226, 6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(186, 27);
            this.textBoxFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxFirstName, "Enter a person\'s first name");
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(226, 39);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(186, 27);
            this.textBoxLastName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxLastName, "Enter a person\'s last name");
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(226, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(186, 27);
            this.textBoxEmail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxEmail, "Enter a person\'s email address");
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(226, 105);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(186, 27);
            this.textBoxPhoneNumber.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxPhoneNumber, "Enter a person\'s phone number");
            // 
            // listViewContact
            // 
            this.listViewContact.CheckBoxes = true;
            this.listViewContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnContacted,
            this.columnFirstName,
            this.columnLastName,
            this.columnDate,
            this.columnEmail,
            this.columnPhoneNumber});
            this.listViewContact.FullRowSelect = true;
            this.listViewContact.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewContact.Location = new System.Drawing.Point(12, 167);
            this.listViewContact.MultiSelect = false;
            this.listViewContact.Name = "listViewContact";
            this.listViewContact.Size = new System.Drawing.Size(537, 150);
            this.listViewContact.TabIndex = 10;
            this.toolTip1.SetToolTip(this.listViewContact, "Displays all the list of contacts that the user has added to the list");
            this.listViewContact.UseCompatibleStateImageBehavior = false;
            this.listViewContact.View = System.Windows.Forms.View.Details;
            this.listViewContact.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListViewContact_ItemCheck);
            this.listViewContact.SelectedIndexChanged += new System.EventHandler(this.ListViewContact_SelectedIndexChanged);
            // 
            // columnContacted
            // 
            this.columnContacted.Text = "Contacted?";
            this.columnContacted.Width = 90;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 100;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.Width = 100;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 80;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email Address";
            this.columnEmail.Width = 150;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "Phone Number";
            this.columnPhoneNumber.Width = 100;
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(12, 320);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(537, 106);
            this.labelOutput.TabIndex = 11;
            this.toolTip1.SetToolTip(this.labelOutput, "Display an error depending on which invalid input made by the user, also displays" +
        " the status of a contact when clicked");
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(455, 429);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "&Close";
            this.toolTip1.SetToolTip(this.buttonExit, "Exits the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(355, 429);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Removes all errors and all inputs in textbox");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(255, 429);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Adds the contact to the list");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // formContactTracer
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(561, 470);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.listViewContact);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.labelContacted);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formContactTracer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelContacted;
        private CheckBox checkBoxContacted;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private ListView listViewContact;
        private Label labelOutput;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonEnter;
        private ColumnHeader columnContacted;
        private ColumnHeader columnFirstName;
        private ColumnHeader columnLastName;
        private ColumnHeader columnDate;
        private ColumnHeader columnPhoneNumber;
        private ColumnHeader columnEmail;
        private ToolTip toolTip1;
    }
}