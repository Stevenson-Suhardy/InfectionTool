
namespace InfectionTool
{
    partial class formAverageWeeklyUnitsByRegion
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
            this.labelCases = new System.Windows.Forms.Label();
            this.textBoxCases = new System.Windows.Forms.TextBox();
            this.textBoxRegion1Units = new System.Windows.Forms.TextBox();
            this.textBoxRegion2Units = new System.Windows.Forms.TextBox();
            this.textBoxRegion3Units = new System.Windows.Forms.TextBox();
            this.labelAverageRegion1 = new System.Windows.Forms.Label();
            this.labelAverageRegion3 = new System.Windows.Forms.Label();
            this.labelAverageRegion2 = new System.Windows.Forms.Label();
            this.labelAverageThisWeek = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelCases
            // 
            this.labelCases.AutoSize = true;
            this.labelCases.Location = new System.Drawing.Point(12, 9);
            this.labelCases.Name = "labelCases";
            this.labelCases.Size = new System.Drawing.Size(49, 20);
            this.labelCases.TabIndex = 0;
            this.labelCases.Text = "&Cases:";
            // 
            // textBoxCases
            // 
            this.textBoxCases.Location = new System.Drawing.Point(67, 9);
            this.textBoxCases.Name = "textBoxCases";
            this.textBoxCases.Size = new System.Drawing.Size(78, 27);
            this.textBoxCases.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxCases, "Enter the number of units in the BOLD Region for the past 7 days.");
            // 
            // textBoxRegion1Units
            // 
            this.textBoxRegion1Units.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion1Units.Location = new System.Drawing.Point(32, 85);
            this.textBoxRegion1Units.Multiline = true;
            this.textBoxRegion1Units.Name = "textBoxRegion1Units";
            this.textBoxRegion1Units.ReadOnly = true;
            this.textBoxRegion1Units.Size = new System.Drawing.Size(91, 174);
            this.textBoxRegion1Units.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxRegion1Units, "Display the past entries for Region 1.");
            // 
            // textBoxRegion2Units
            // 
            this.textBoxRegion2Units.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion2Units.Location = new System.Drawing.Point(173, 85);
            this.textBoxRegion2Units.Multiline = true;
            this.textBoxRegion2Units.Name = "textBoxRegion2Units";
            this.textBoxRegion2Units.ReadOnly = true;
            this.textBoxRegion2Units.Size = new System.Drawing.Size(91, 174);
            this.textBoxRegion2Units.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxRegion2Units, "Display the past entries for Region 2.");
            // 
            // textBoxRegion3Units
            // 
            this.textBoxRegion3Units.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion3Units.Location = new System.Drawing.Point(313, 85);
            this.textBoxRegion3Units.Multiline = true;
            this.textBoxRegion3Units.Name = "textBoxRegion3Units";
            this.textBoxRegion3Units.ReadOnly = true;
            this.textBoxRegion3Units.Size = new System.Drawing.Size(92, 174);
            this.textBoxRegion3Units.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxRegion3Units, "Display the past entries in Region 3.");
            // 
            // labelAverageRegion1
            // 
            this.labelAverageRegion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageRegion1.Location = new System.Drawing.Point(12, 262);
            this.labelAverageRegion1.Name = "labelAverageRegion1";
            this.labelAverageRegion1.Size = new System.Drawing.Size(134, 36);
            this.labelAverageRegion1.TabIndex = 4;
            this.labelAverageRegion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageRegion1, "Displays the average for Region 1.");
            // 
            // labelAverageRegion3
            // 
            this.labelAverageRegion3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageRegion3.Location = new System.Drawing.Point(291, 262);
            this.labelAverageRegion3.Name = "labelAverageRegion3";
            this.labelAverageRegion3.Size = new System.Drawing.Size(137, 36);
            this.labelAverageRegion3.TabIndex = 10;
            this.labelAverageRegion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageRegion3, "Displays the average for Region 3.");
            // 
            // labelAverageRegion2
            // 
            this.labelAverageRegion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageRegion2.Location = new System.Drawing.Point(151, 262);
            this.labelAverageRegion2.Name = "labelAverageRegion2";
            this.labelAverageRegion2.Size = new System.Drawing.Size(134, 36);
            this.labelAverageRegion2.TabIndex = 7;
            this.labelAverageRegion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageRegion2, "Displays the average for Region 2.");
            // 
            // labelAverageThisWeek
            // 
            this.labelAverageThisWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageThisWeek.Location = new System.Drawing.Point(12, 307);
            this.labelAverageThisWeek.Name = "labelAverageThisWeek";
            this.labelAverageThisWeek.Size = new System.Drawing.Size(416, 40);
            this.labelAverageThisWeek.TabIndex = 11;
            this.labelAverageThisWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageThisWeek, "Displays the total average of every region.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 350);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(132, 29);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Storing your input into the system and displaying them on the box based on the BO" +
        "LD Region.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(151, 350);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(134, 29);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Changing back the form to it\'s default state.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(291, 350);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(137, 29);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "&Close";
            this.toolTip1.SetToolTip(this.buttonClose, "Exits the application.");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(324, 62);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(68, 20);
            this.labelRegion3.TabIndex = 8;
            this.labelRegion3.Text = "Region &3";
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(182, 62);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(68, 20);
            this.labelRegion2.TabIndex = 5;
            this.labelRegion2.Text = "Region &2";
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Location = new System.Drawing.Point(43, 62);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(68, 20);
            this.labelRegion1.TabIndex = 2;
            this.labelRegion1.Text = "Region &1";
            // 
            // formAverageWeeklyUnitsByRegion
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(440, 389);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageThisWeek);
            this.Controls.Add(this.labelAverageRegion2);
            this.Controls.Add(this.labelAverageRegion3);
            this.Controls.Add(this.labelAverageRegion1);
            this.Controls.Add(this.textBoxRegion3Units);
            this.Controls.Add(this.textBoxRegion2Units);
            this.Controls.Add(this.textBoxRegion1Units);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.textBoxCases);
            this.Controls.Add(this.labelCases);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageWeeklyUnitsByRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAverageWeeklyUnitsByRegion_FormClosed);
            this.Load += new System.EventHandler(this.FormAverageWeeklyUnitsByRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCases;
        private System.Windows.Forms.TextBox textBoxCases;
        private System.Windows.Forms.TextBox textBoxRegion1Units;
        private System.Windows.Forms.TextBox textBoxRegion2Units;
        private System.Windows.Forms.TextBox textBoxRegion3Units;
        private System.Windows.Forms.Label labelAverageRegion1;
        private System.Windows.Forms.Label labelAverageRegion3;
        private System.Windows.Forms.Label labelAverageRegion2;
        private System.Windows.Forms.Label labelAverageThisWeek;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

