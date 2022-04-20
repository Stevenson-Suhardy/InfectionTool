
namespace InfectionTool
{
    partial class formWeeklyTemperature
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
            this.labelWeek = new System.Windows.Forms.Label();
            this.labelDay1 = new System.Windows.Forms.Label();
            this.labelDay2 = new System.Windows.Forms.Label();
            this.labelDay3 = new System.Windows.Forms.Label();
            this.labelDay4 = new System.Windows.Forms.Label();
            this.labelDay5 = new System.Windows.Forms.Label();
            this.labelDay6 = new System.Windows.Forms.Label();
            this.labelDay7 = new System.Windows.Forms.Label();
            this.labelAveragePrompt = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxDay1 = new System.Windows.Forms.TextBox();
            this.textBoxDay2 = new System.Windows.Forms.TextBox();
            this.textBoxDay3 = new System.Windows.Forms.TextBox();
            this.textBoxDay4 = new System.Windows.Forms.TextBox();
            this.textBoxDay5 = new System.Windows.Forms.TextBox();
            this.textBoxDay6 = new System.Windows.Forms.TextBox();
            this.textBoxDay7 = new System.Windows.Forms.TextBox();
            this.textBoxAverageOutput = new System.Windows.Forms.TextBox();
            this.toolTipTemperature = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelWeek
            // 
            this.labelWeek.Location = new System.Drawing.Point(15, 7);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(122, 25);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "Week 1";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDay1
            // 
            this.labelDay1.Location = new System.Drawing.Point(37, 42);
            this.labelDay1.Name = "labelDay1";
            this.labelDay1.Size = new System.Drawing.Size(100, 25);
            this.labelDay1.TabIndex = 1;
            this.labelDay1.Text = "Day &1:";
            this.labelDay1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay2
            // 
            this.labelDay2.Location = new System.Drawing.Point(37, 77);
            this.labelDay2.Name = "labelDay2";
            this.labelDay2.Size = new System.Drawing.Size(100, 25);
            this.labelDay2.TabIndex = 3;
            this.labelDay2.Text = "Day &2:";
            this.labelDay2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay3
            // 
            this.labelDay3.Location = new System.Drawing.Point(37, 112);
            this.labelDay3.Name = "labelDay3";
            this.labelDay3.Size = new System.Drawing.Size(100, 25);
            this.labelDay3.TabIndex = 5;
            this.labelDay3.Text = "Day &3:";
            this.labelDay3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay4
            // 
            this.labelDay4.Location = new System.Drawing.Point(37, 147);
            this.labelDay4.Name = "labelDay4";
            this.labelDay4.Size = new System.Drawing.Size(100, 25);
            this.labelDay4.TabIndex = 7;
            this.labelDay4.Text = "Day &4:";
            this.labelDay4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay5
            // 
            this.labelDay5.Location = new System.Drawing.Point(37, 182);
            this.labelDay5.Name = "labelDay5";
            this.labelDay5.Size = new System.Drawing.Size(100, 25);
            this.labelDay5.TabIndex = 9;
            this.labelDay5.Text = "Day &5:";
            this.labelDay5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay6
            // 
            this.labelDay6.Location = new System.Drawing.Point(37, 217);
            this.labelDay6.Name = "labelDay6";
            this.labelDay6.Size = new System.Drawing.Size(100, 25);
            this.labelDay6.TabIndex = 11;
            this.labelDay6.Text = "Day &6:";
            this.labelDay6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDay7
            // 
            this.labelDay7.Location = new System.Drawing.Point(37, 252);
            this.labelDay7.Name = "labelDay7";
            this.labelDay7.Size = new System.Drawing.Size(100, 25);
            this.labelDay7.TabIndex = 13;
            this.labelDay7.Text = "Day &7:";
            this.labelDay7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAveragePrompt
            // 
            this.labelAveragePrompt.Location = new System.Drawing.Point(15, 287);
            this.labelAveragePrompt.Name = "labelAveragePrompt";
            this.labelAveragePrompt.Size = new System.Drawing.Size(122, 25);
            this.labelAveragePrompt.TabIndex = 15;
            this.labelAveragePrompt.Text = "Weekly &Average:";
            this.labelAveragePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 334);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(296, 112);
            this.textBoxResult.TabIndex = 17;
            this.toolTipTemperature.SetToolTip(this.textBoxResult, "Displays any result or error message");
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(15, 465);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(94, 29);
            this.buttonCalculate.TabIndex = 18;
            this.buttonCalculate.Text = "&Calculate";
            this.toolTipTemperature.SetToolTip(this.buttonCalculate, "Click to attempt to calculate the average temperature");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(116, 465);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "&Reset";
            this.toolTipTemperature.SetToolTip(this.buttonReset, "Click to reset all input and output fields");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(217, 465);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 29);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "C&lose";
            this.toolTipTemperature.SetToolTip(this.buttonClose, "Click to exit the application");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxDay1
            // 
            this.textBoxDay1.Location = new System.Drawing.Point(164, 41);
            this.textBoxDay1.Name = "textBoxDay1";
            this.textBoxDay1.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay1.TabIndex = 2;
            this.toolTipTemperature.SetToolTip(this.textBoxDay1, "Enter the temperature for day 1");
            // 
            // textBoxDay2
            // 
            this.textBoxDay2.Location = new System.Drawing.Point(164, 76);
            this.textBoxDay2.Name = "textBoxDay2";
            this.textBoxDay2.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay2.TabIndex = 4;
            this.toolTipTemperature.SetToolTip(this.textBoxDay2, "Enter the temperature for day 2");
            // 
            // textBoxDay3
            // 
            this.textBoxDay3.Location = new System.Drawing.Point(164, 111);
            this.textBoxDay3.Name = "textBoxDay3";
            this.textBoxDay3.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay3.TabIndex = 6;
            this.toolTipTemperature.SetToolTip(this.textBoxDay3, "Enter the temperature for day 3");
            // 
            // textBoxDay4
            // 
            this.textBoxDay4.Location = new System.Drawing.Point(164, 146);
            this.textBoxDay4.Name = "textBoxDay4";
            this.textBoxDay4.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay4.TabIndex = 8;
            this.toolTipTemperature.SetToolTip(this.textBoxDay4, "Enter the temperature for day 4");
            // 
            // textBoxDay5
            // 
            this.textBoxDay5.Location = new System.Drawing.Point(164, 181);
            this.textBoxDay5.Name = "textBoxDay5";
            this.textBoxDay5.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay5.TabIndex = 10;
            this.toolTipTemperature.SetToolTip(this.textBoxDay5, "Enter the temperature for day 5");
            // 
            // textBoxDay6
            // 
            this.textBoxDay6.Location = new System.Drawing.Point(164, 216);
            this.textBoxDay6.Name = "textBoxDay6";
            this.textBoxDay6.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay6.TabIndex = 12;
            this.toolTipTemperature.SetToolTip(this.textBoxDay6, "Enter the temperature for day 6");
            // 
            // textBoxDay7
            // 
            this.textBoxDay7.Location = new System.Drawing.Point(164, 251);
            this.textBoxDay7.Name = "textBoxDay7";
            this.textBoxDay7.Size = new System.Drawing.Size(125, 27);
            this.textBoxDay7.TabIndex = 14;
            this.toolTipTemperature.SetToolTip(this.textBoxDay7, "Enter the temperature for day 7");
            // 
            // textBoxAverageOutput
            // 
            this.textBoxAverageOutput.Location = new System.Drawing.Point(164, 286);
            this.textBoxAverageOutput.Name = "textBoxAverageOutput";
            this.textBoxAverageOutput.ReadOnly = true;
            this.textBoxAverageOutput.Size = new System.Drawing.Size(125, 27);
            this.textBoxAverageOutput.TabIndex = 16;
            this.toolTipTemperature.SetToolTip(this.textBoxAverageOutput, "Displays the calculated average temperature");
            // 
            // formWeeklyTemperature
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(326, 508);
            this.Controls.Add(this.textBoxAverageOutput);
            this.Controls.Add(this.textBoxDay7);
            this.Controls.Add(this.textBoxDay6);
            this.Controls.Add(this.textBoxDay5);
            this.Controls.Add(this.textBoxDay4);
            this.Controls.Add(this.textBoxDay3);
            this.Controls.Add(this.textBoxDay2);
            this.Controls.Add(this.textBoxDay1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelAveragePrompt);
            this.Controls.Add(this.labelDay7);
            this.Controls.Add(this.labelDay6);
            this.Controls.Add(this.labelDay5);
            this.Controls.Add(this.labelDay4);
            this.Controls.Add(this.labelDay3);
            this.Controls.Add(this.labelDay2);
            this.Controls.Add(this.labelDay1);
            this.Controls.Add(this.labelWeek);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formWeeklyTemperature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Temperature";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formWeeklyTemperature_FormClosed);
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Label labelDay1;
        private System.Windows.Forms.Label labelDay2;
        private System.Windows.Forms.Label labelDay3;
        private System.Windows.Forms.Label labelDay4;
        private System.Windows.Forms.Label labelDay5;
        private System.Windows.Forms.Label labelDay6;
        private System.Windows.Forms.Label labelDay7;
        private System.Windows.Forms.Label labelAveragePrompt;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxDay1;
        private System.Windows.Forms.TextBox textBoxDay2;
        private System.Windows.Forms.TextBox textBoxDay3;
        private System.Windows.Forms.TextBox textBoxDay4;
        private System.Windows.Forms.TextBox textBoxDay5;
        private System.Windows.Forms.TextBox textBoxDay6;
        private System.Windows.Forms.TextBox textBoxDay7;
        private System.Windows.Forms.TextBox textBoxAverageOutput;
        private System.Windows.Forms.ToolTip toolTipTemperature;
    }
}

