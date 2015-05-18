namespace N_Statistic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextInput = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MedianLabel = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MeanLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CVLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CMlabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CQLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CRLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Q3Label = new System.Windows.Forms.Label();
            this.Q2Label = new System.Windows.Forms.Label();
            this.Q1Label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.VariantLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SbchalierLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SortOutput = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ZOutput = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(8, 10);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(103, 72);
            this.TextInput.TabIndex = 0;
            this.TextInput.Text = "        Input data: (separate by space)";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(147, 11);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(421, 35);
            this.Input.TabIndex = 1;
            this.Input.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Location = new System.Drawing.Point(417, 58);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 24);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Median:";
            // 
            // MedianLabel
            // 
            this.MedianLabel.AutoSize = true;
            this.MedianLabel.Location = new System.Drawing.Point(105, 39);
            this.MedianLabel.Name = "MedianLabel";
            this.MedianLabel.Size = new System.Drawing.Size(41, 13);
            this.MedianLabel.TabIndex = 5;
            this.MedianLabel.Text = "txtinput";
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputPanel.Controls.Add(this.ClearButton);
            this.InputPanel.Controls.Add(this.SubmitButton);
            this.InputPanel.Controls.Add(this.Input);
            this.InputPanel.Controls.Add(this.TextInput);
            this.InputPanel.Location = new System.Drawing.Point(28, 54);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(594, 90);
            this.InputPanel.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Location = new System.Drawing.Point(147, 58);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(144, 24);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mean: ";
            // 
            // MeanLabel
            // 
            this.MeanLabel.AutoSize = true;
            this.MeanLabel.Location = new System.Drawing.Point(105, 13);
            this.MeanLabel.Name = "MeanLabel";
            this.MeanLabel.Size = new System.Drawing.Size(41, 13);
            this.MeanLabel.TabIndex = 8;
            this.MeanLabel.Text = "txtinput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mode: ";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(105, 64);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(41, 13);
            this.ModeLabel.TabIndex = 10;
            this.ModeLabel.Text = "txtinput";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min: ";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(292, 13);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(44, 13);
            this.MaxLabel.TabIndex = 13;
            this.MaxLabel.Text = " txtinput";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(292, 39);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(44, 13);
            this.MinLabel.TabIndex = 14;
            this.MinLabel.Text = " txtinput";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Range: ";
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(292, 64);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(44, 13);
            this.RangeLabel.TabIndex = 16;
            this.RangeLabel.Text = " txtinput";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "S.D.: ";
            // 
            // SDLabel
            // 
            this.SDLabel.AutoSize = true;
            this.SDLabel.Location = new System.Drawing.Point(105, 89);
            this.SDLabel.Name = "SDLabel";
            this.SDLabel.Size = new System.Drawing.Size(41, 13);
            this.SDLabel.TabIndex = 18;
            this.SDLabel.Text = "txtinput";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.CVLabel);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.CMlabel);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.CQLabel);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.MedianLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CRLabel);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.Q3Label);
            this.panel1.Controls.Add(this.Q2Label);
            this.panel1.Controls.Add(this.Q1Label);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.VariantLabel);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.SbchalierLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.SDLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RangeLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MinLabel);
            this.panel1.Controls.Add(this.MaxLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ModeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MeanLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 158);
            this.panel1.TabIndex = 19;
            // 
            // CVLabel
            // 
            this.CVLabel.AutoSize = true;
            this.CVLabel.Location = new System.Drawing.Point(105, 133);
            this.CVLabel.Name = "CVLabel";
            this.CVLabel.Size = new System.Drawing.Size(41, 13);
            this.CVLabel.TabIndex = 36;
            this.CVLabel.Text = "txtinput";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(58, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "C.V:";
            // 
            // CMlabel
            // 
            this.CMlabel.AutoSize = true;
            this.CMlabel.Location = new System.Drawing.Point(295, 112);
            this.CMlabel.Name = "CMlabel";
            this.CMlabel.Size = new System.Drawing.Size(41, 13);
            this.CMlabel.TabIndex = 34;
            this.CMlabel.Text = "txtinput";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(254, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "C.M:";
            // 
            // CQLabel
            // 
            this.CQLabel.AutoSize = true;
            this.CQLabel.Location = new System.Drawing.Point(453, 112);
            this.CQLabel.Name = "CQLabel";
            this.CQLabel.Size = new System.Drawing.Size(41, 13);
            this.CQLabel.TabIndex = 32;
            this.CQLabel.Text = "txtinput";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(423, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "C.Q:";
            // 
            // CRLabel
            // 
            this.CRLabel.AutoSize = true;
            this.CRLabel.Location = new System.Drawing.Point(453, 89);
            this.CRLabel.Name = "CRLabel";
            this.CRLabel.Size = new System.Drawing.Size(41, 13);
            this.CRLabel.TabIndex = 30;
            this.CRLabel.Text = "txtinput";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(423, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "C.R:";
            // 
            // Q3Label
            // 
            this.Q3Label.AutoSize = true;
            this.Q3Label.Location = new System.Drawing.Point(453, 64);
            this.Q3Label.Name = "Q3Label";
            this.Q3Label.Size = new System.Drawing.Size(41, 13);
            this.Q3Label.TabIndex = 28;
            this.Q3Label.Text = "txtinput";
            // 
            // Q2Label
            // 
            this.Q2Label.AutoSize = true;
            this.Q2Label.Location = new System.Drawing.Point(453, 39);
            this.Q2Label.Name = "Q2Label";
            this.Q2Label.Size = new System.Drawing.Size(41, 13);
            this.Q2Label.TabIndex = 27;
            this.Q2Label.Text = "txtinput";
            // 
            // Q1Label
            // 
            this.Q1Label.AutoSize = true;
            this.Q1Label.Location = new System.Drawing.Point(453, 13);
            this.Q1Label.Name = "Q1Label";
            this.Q1Label.Size = new System.Drawing.Size(41, 13);
            this.Q1Label.TabIndex = 26;
            this.Q1Label.Text = "txtinput";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(423, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Q3:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(423, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Q2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(423, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Q1:";
            // 
            // VariantLabel
            // 
            this.VariantLabel.AutoSize = true;
            this.VariantLabel.Location = new System.Drawing.Point(105, 112);
            this.VariantLabel.Name = "VariantLabel";
            this.VariantLabel.Size = new System.Drawing.Size(41, 13);
            this.VariantLabel.TabIndex = 22;
            this.VariantLabel.Text = "txtinput";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Variant:";
            // 
            // SbchalierLabel
            // 
            this.SbchalierLabel.AutoSize = true;
            this.SbchalierLabel.Location = new System.Drawing.Point(295, 89);
            this.SbchalierLabel.Name = "SbchalierLabel";
            this.SbchalierLabel.Size = new System.Drawing.Size(41, 13);
            this.SbchalierLabel.TabIndex = 20;
            this.SbchalierLabel.Text = "txtinput";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "M.D:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sort data:";
            // 
            // SortOutput
            // 
            this.SortOutput.Location = new System.Drawing.Point(139, 11);
            this.SortOutput.Name = "SortOutput";
            this.SortOutput.ReadOnly = true;
            this.SortOutput.Size = new System.Drawing.Size(316, 35);
            this.SortOutput.TabIndex = 4;
            this.SortOutput.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.SortOutput);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(31, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 56);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TH Sarabun New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(215, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 49);
            this.label9.TabIndex = 22;
            this.label9.Text = "N-Statistic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(486, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Developed by North1432\r\nhttp://north1432.blogspot.com";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.ZOutput);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(31, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 57);
            this.panel3.TabIndex = 24;
            // 
            // ZOutput
            // 
            this.ZOutput.Location = new System.Drawing.Point(139, 12);
            this.ZOutput.Name = "ZOutput";
            this.ZOutput.ReadOnly = true;
            this.ZOutput.Size = new System.Drawing.Size(316, 35);
            this.ZOutput.TabIndex = 21;
            this.ZOutput.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Z (sort): ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(650, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Name = "Form1";
            this.Text = "N-Statistic BETA v.0.0.1";
            this.InputPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextInput;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MedianLabel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MeanLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SDLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox SortOutput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox ZOutput;
        private System.Windows.Forms.Label SbchalierLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label VariantLabel;
        private System.Windows.Forms.Label Q3Label;
        private System.Windows.Forms.Label Q2Label;
        private System.Windows.Forms.Label Q1Label;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CRLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CQLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label CVLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label CMlabel;
        private System.Windows.Forms.Label label20;
    }
}

