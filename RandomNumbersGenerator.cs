//https://stackoverflow.com/questions/25700992/do-not-allow-enter-key-to-make-a-new-line-in-multiline-textbox-c-sharp --> Disable ENTER in multiline textboxes.
//https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers --> Make textboxes accept only numbers.
//https://social.msdn.microsoft.com/Forums/en-US/da1b8805-2a9f-4bbc-a7c2-aa5e3c829d39/getfocus-event-for-textbox-in-cnet?forum=csharplanguage --> Get focus of textbox.
//https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=netframework-4.7.2#System_Random_Next_System_Int32_System_Int32_ --> Get random numbers in range.
//https://social.msdn.microsoft.com/Forums/en-US/d4175788-7bfc-4f6d-8eb6-e48b80000fe1/how-to-detect-if-checkbox-was-checked?forum=csharpgeneral --> Get checkbox state.
//https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.selectedindexchanged?view=netframework-4.7.2 --> Event for combobox selection changed.
//https://social.msdn.microsoft.com/Forums/vstudio/en-US/f4cf2450-4485-41af-9403-e2fc30e126d5/split-string-to-int?forum=csharpgeneral --> Split String to Int array.
//http://www.csharp-examples.net/sort-array/ --> Sort array in ascending order.
//https://stackoverflow.com/questions/5430016/better-way-to-sort-array-in-descending-order --> Sort array in descending order.
//https://stackoverflow.com/questions/14297853/how-to-get-random-values-from-array-in-c-sharp/14297876#14297876 --> Shuffle array elements.
//https://stackoverflow.com/questions/19011948/how-to-add-scrollbars-in-c-sharp-form --> Add scrollbars to textbox.
//https://social.msdn.microsoft.com/Forums/windows/en-US/1bbfc2b0-f099-4572-be70-e70a27ec2eed/how-to-set-a-default-value-for-a-combo-box?forum=winforms --> Set default selection of combobox.
//https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms --> Set Form name at top left.
//https://stackoverflow.com/questions/10223477/change-default-icon --> Set Form icon at top left and taskbar.
//https://stackoverflow.com/questions/4284497/changing-the-default-icon-in-a-windows-forms-application --> Set app .exe file icon.

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RandomNumbersGenerator
{
    public partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numbersAmountLabel = new System.Windows.Forms.Label();
            this.numbersAmountInputBox = new System.Windows.Forms.TextBox();
            this.rangeFromLabel = new System.Windows.Forms.Label();
            this.rangeFromInputBox = new System.Windows.Forms.TextBox();
            this.rangeToLabel = new System.Windows.Forms.Label();
            this.rangeToInputBox = new System.Windows.Forms.TextBox();
            this.includeFromCheckBox = new System.Windows.Forms.CheckBox();
            this.includeToCheckBox = new System.Windows.Forms.CheckBox();
            this.resultTypeLabel = new System.Windows.Forms.Label();
            this.resultTypeComboBox = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbersAmountLabel
            // 
            this.numbersAmountLabel.AutoSize = true;
            this.numbersAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbersAmountLabel.Location = new System.Drawing.Point(31, 31);
            this.numbersAmountLabel.Name = "numbersAmountLabel";
            this.numbersAmountLabel.Size = new System.Drawing.Size(122, 40);
            this.numbersAmountLabel.TabIndex = 0;
            this.numbersAmountLabel.Text = "Choose amount\r\nof numbers:";
            // 
            // numbersAmountInputBox
            // 
            this.numbersAmountInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbersAmountInputBox.Location = new System.Drawing.Point(159, 31);
            this.numbersAmountInputBox.MaxLength = 2;
            this.numbersAmountInputBox.Multiline = true;
            this.numbersAmountInputBox.Name = "numbersAmountInputBox";
            this.numbersAmountInputBox.Size = new System.Drawing.Size(40, 40);
            this.numbersAmountInputBox.TabIndex = 1;
            this.numbersAmountInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disableEnterKeyNewLine);
            this.numbersAmountInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.makeSureOnlyNumbersAreAccepted);
            // 
            // rangeFromLabel
            // 
            this.rangeFromLabel.AutoSize = true;
            this.rangeFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeFromLabel.Location = new System.Drawing.Point(334, 40);
            this.rangeFromLabel.Name = "rangeFromLabel";
            this.rangeFromLabel.Size = new System.Drawing.Size(50, 20);
            this.rangeFromLabel.TabIndex = 2;
            this.rangeFromLabel.Text = "From:";
            // 
            // rangeFromInputBox
            // 
            this.rangeFromInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeFromInputBox.Location = new System.Drawing.Point(381, 31);
            this.rangeFromInputBox.MaxLength = 2;
            this.rangeFromInputBox.Multiline = true;
            this.rangeFromInputBox.Name = "rangeFromInputBox";
            this.rangeFromInputBox.Size = new System.Drawing.Size(40, 40);
            this.rangeFromInputBox.TabIndex = 3;
            this.rangeFromInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disableEnterKeyNewLine);
            this.rangeFromInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.makeSureOnlyNumbersAreAccepted);
            // 
            // rangeToLabel
            // 
            this.rangeToLabel.AutoSize = true;
            this.rangeToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeToLabel.Location = new System.Drawing.Point(428, 40);
            this.rangeToLabel.Name = "rangeToLabel";
            this.rangeToLabel.Size = new System.Drawing.Size(31, 20);
            this.rangeToLabel.TabIndex = 4;
            this.rangeToLabel.Text = "To:";
            // 
            // rangeToInputBox
            // 
            this.rangeToInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeToInputBox.Location = new System.Drawing.Point(457, 31);
            this.rangeToInputBox.MaxLength = 2;
            this.rangeToInputBox.Multiline = true;
            this.rangeToInputBox.Name = "rangeToInputBox";
            this.rangeToInputBox.Size = new System.Drawing.Size(40, 40);
            this.rangeToInputBox.TabIndex = 5;
            this.rangeToInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disableEnterKeyNewLine);
            this.rangeToInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.makeSureOnlyNumbersAreAccepted);
            // 
            // includeFromCheckBox
            // 
            this.includeFromCheckBox.AutoSize = true;
            this.includeFromCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.includeFromCheckBox.Location = new System.Drawing.Point(348, 77);
            this.includeFromCheckBox.Name = "includeFromCheckBox";
            this.includeFromCheckBox.Size = new System.Drawing.Size(70, 20);
            this.includeFromCheckBox.TabIndex = 6;
            this.includeFromCheckBox.Text = "Include";
            this.includeFromCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeToCheckBox
            // 
            this.includeToCheckBox.AutoSize = true;
            this.includeToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.includeToCheckBox.Location = new System.Drawing.Point(434, 77);
            this.includeToCheckBox.Name = "includeToCheckBox";
            this.includeToCheckBox.Size = new System.Drawing.Size(70, 20);
            this.includeToCheckBox.TabIndex = 7;
            this.includeToCheckBox.Text = "Include";
            this.includeToCheckBox.UseVisualStyleBackColor = true;
            // 
            // resultTypeLabel
            // 
            this.resultTypeLabel.AutoSize = true;
            this.resultTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTypeLabel.Location = new System.Drawing.Point(228, 35);
            this.resultTypeLabel.Name = "resultTypeLabel";
            this.resultTypeLabel.Size = new System.Drawing.Size(85, 18);
            this.resultTypeLabel.TabIndex = 8;
            this.resultTypeLabel.Text = "Result type:";
            // 
            // resultTypeComboBox
            // 
            this.resultTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTypeComboBox.FormattingEnabled = true;
            this.resultTypeComboBox.Items.AddRange(new object[] {
            "Randomize",
            "Sort ascending",
            "Sort descending"});
            this.resultTypeComboBox.Location = new System.Drawing.Point(209, 56);
            this.resultTypeComboBox.Name = "resultTypeComboBox";
            this.resultTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.resultTypeComboBox.TabIndex = 10;
            this.resultTypeComboBox.SelectedIndex = 0;
            this.resultTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.resultTypeSelection);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(117, 148);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(301, 50);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateRandomNumbers);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(12, 252);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox.Size = new System.Drawing.Size(509, 173);
            this.resultBox.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(216, 206);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 37);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearEverything);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 437);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.resultTypeComboBox);
            this.Controls.Add(this.resultTypeLabel);
            this.Controls.Add(this.includeToCheckBox);
            this.Controls.Add(this.includeFromCheckBox);
            this.Controls.Add(this.rangeToInputBox);
            this.Controls.Add(this.rangeToLabel);
            this.Controls.Add(this.rangeFromInputBox);
            this.Controls.Add(this.rangeFromLabel);
            this.Controls.Add(this.numbersAmountInputBox);
            this.Controls.Add(this.numbersAmountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Random Numbers Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		
		public Form1()
        {
            InitializeComponent();
        }

        private void disableEnterKeyNewLine(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void makeSureOnlyNumbersAreAccepted(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (((this.numbersAmountInputBox.Focused) && (this.numbersAmountInputBox.Text.Length != 2)) || ((this.rangeFromInputBox.Focused) && (this.rangeFromInputBox.Text.Length != 2)) || ((this.rangeToInputBox.Focused) && (this.rangeToInputBox.Text.Length != 2)))
                {
                    this.resultBox.Clear();
                    this.resultBox.Text += "Please enter only whole positive integer numbers in all blank input spaces!";
                }
            }
            else
            {
                this.resultBox.Clear();
            }
            this.generateButtonPressed = false;
        }

        int amountNumsGlobal = 0;
        int[] defaultArray;
        bool generateButtonPressed = false;

        private void resultTypeSelection(object sender, EventArgs e)
        {
            bool amountNumsIsOK = Int32.TryParse(this.numbersAmountInputBox.Text, out int amountNums);
            bool fromNumIsOK = Int32.TryParse(this.rangeFromInputBox.Text, out int fromNum);
            bool toNumIsOK = Int32.TryParse(this.rangeToInputBox.Text, out int toNum);

            if ((amountNumsIsOK) && (fromNumIsOK) && (toNumIsOK))
            {
                if (generateButtonPressed == true)
                {
                    if (this.resultTypeComboBox.SelectedIndex == 0)
                    {
                        if (this.resultBox.Text != null)
                        {
                            defaultArray = new int[amountNumsGlobal];
                            string values = this.resultBox.Text;
                            string[] tokens = values.Split(' ');

                            for (int i = 0; i < tokens.Length - 1; i++)
                            {
                                defaultArray[i] = Int32.Parse(tokens[i]);
                            }

                            int[] shuffledDefaultArray = defaultArray.OrderBy(n => Guid.NewGuid()).ToArray();

                            this.resultBox.Clear();
                            for (int i = 0; i < shuffledDefaultArray.Length; i++)
                            {
                                this.resultBox.Text += shuffledDefaultArray[i] + " ";
                            }
                        }
                        else
                        {
                            this.resultBox.Clear();
                            for (int i = 0; i < defaultArray.Length; i++)
                            {
                                this.resultBox.Text += defaultArray[i] + " ";
                            }
                        }
                    }
                    else if (this.resultTypeComboBox.SelectedIndex == 1)
                    {
                        int[] ascendingArray = new int[amountNums];
                        string values = this.resultBox.Text;
                        string[] tokens = values.Split(' ');

                        for (int i = 0; i < tokens.Length - 1; i++)
                        {
                            ascendingArray[i] = Int32.Parse(tokens[i]);
                        }
                        Array.Sort(ascendingArray);

                        this.resultBox.Clear();
                        for (int i = 0; i < ascendingArray.Length; i++)
                        {
                            this.resultBox.Text += ascendingArray[i] + " ";
                        }
                    }
                    else if (this.resultTypeComboBox.SelectedIndex == 2)
                    {
                        int[] descendingArray = new int[amountNums];
                        string values = this.resultBox.Text;
                        string[] tokens = values.Split(' ');

                        for (int i = 0; i < tokens.Length - 1; i++)
                        {
                            descendingArray[i] = Int32.Parse(tokens[i]);
                        }
                        Array.Sort(descendingArray);
                        Array.Reverse(descendingArray);

                        this.resultBox.Clear();
                        for (int i = 0; i < descendingArray.Length; i++)
                        {
                            this.resultBox.Text += descendingArray[i] + " ";
                        }
                    }
                }
                else
                {
                    this.resultBox.Clear();
                    this.resultBox.Text += "Please make sure that the 'Generate' button has been pressed!";
                }
            }
            else
            {
                this.resultBox.Clear();
                this.resultBox.Text += "Please make sure that all fields have valid input in them!";
            }
        }

        private void generateRandomNumbers(object sender, EventArgs e)
        {
            if ((this.numbersAmountInputBox.Text != null) && (this.rangeFromInputBox.Text != null) && (this.rangeToInputBox.Text != null))
            {
                bool amountNumsIsOK = Int32.TryParse(this.numbersAmountInputBox.Text, out int amountNums);
                bool fromNumIsOK = Int32.TryParse(this.rangeFromInputBox.Text, out int fromNum);
                bool toNumIsOK = Int32.TryParse(this.rangeToInputBox.Text, out int toNum);

                this.resultBox.Clear();

                if ((amountNumsIsOK) && (fromNumIsOK) && (toNumIsOK))
                {
                    amountNumsGlobal = amountNums;
                    int[] array = new int[amountNums];
                    for (int i = 0; i < amountNums; i++)
                    {
                        array[i] = 100;
                    }
                    Random random = new Random();
                    int temp = 0;
                    int min = 0;
                    int max = 0;

                    if ((this.includeFromCheckBox.Checked) && (this.includeToCheckBox.Checked))
                    {
                        min = fromNum;
                        max = toNum + 1;
                    }
                    else if ((this.includeFromCheckBox.Checked) && (!this.includeToCheckBox.Checked))
                    {
                        min = fromNum;
                        max = toNum;
                    }
                    else if ((!this.includeFromCheckBox.Checked) && (this.includeToCheckBox.Checked))
                    {
                        min = fromNum + 1;
                        max = toNum + 1;
                    }
                    else if ((!this.includeFromCheckBox.Checked) && (!this.includeToCheckBox.Checked))
                    {
                        min = fromNum + 1;
                        max = toNum;
                    }
                    
                    if (min >= max)
                    {
                        this.resultBox.Clear();
                        this.resultBox.Text += "Please make sure that the borders are set correctly: From < To!";
                    }
                    else if ((min < max) && (max - min < amountNums))
                    {
                        this.resultBox.Clear();
                        this.resultBox.Text += "Please make sure that there are enough numbers inside the borders: To - From >= Amount!";
                    }
                    else if ((min < max) && (max - min >= amountNums))
                    {
                        if (this.resultTypeComboBox.SelectedIndex == 0)
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                temp = random.Next(min, max);
                                while (isDuplicate(temp, array))
                                {
                                    temp = random.Next(min, max);
                                }
                                array[i] = temp;
                            }
                        }
                        else if (this.resultTypeComboBox.SelectedIndex == 1)
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                temp = random.Next(min, max);
                                while (isDuplicate(temp, array))
                                {
                                    temp = random.Next(min, max);
                                }
                                array[i] = temp;
                            }
                            Array.Sort(array);
                        }
                        else if (this.resultTypeComboBox.SelectedIndex == 2)
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                temp = random.Next(min, max);
                                while (isDuplicate(temp, array))
                                {
                                    temp = random.Next(min, max);
                                }
                                array[i] = temp;
                            }
                            Array.Sort(array);
                            Array.Reverse(array);
                        }

                        for (int i = 0; i < array.Length; i++)
                        {
                            this.resultBox.Text += array[i] + " ";
                        }

                        defaultArray = new int[amountNumsGlobal];
                        string values = this.resultBox.Text;
                        string[] tokens = values.Split(' ');

                        for (int i = 0; i < tokens.Length - 1; i++)
                        {
                            defaultArray[i] = Int32.Parse(tokens[i]);
                        }
                    }
                }
                else
                {
                    this.resultBox.Clear();
                    this.resultBox.Text += "Please enter only whole positive integer numbers in all blank input spaces!";
                }

                generateButtonPressed = true;
            }
        }

        private static bool isDuplicate(int tmp, int[] arr)
        {
            foreach (var item in arr)
            {
                if (item == tmp)
                {
                    return true;
                }
            }
            return false;
        }

        private void clearEverything(object sender, EventArgs e)
        {
            this.numbersAmountInputBox.Clear();
            this.resultTypeComboBox.SelectedIndex = 0;
            this.rangeFromInputBox.Clear();
            this.includeFromCheckBox.Checked = false;
            this.rangeToInputBox.Clear();
            this.includeToCheckBox.Checked = false;
            this.resultBox.Clear();
            this.generateButtonPressed = false;
        }

        private System.Windows.Forms.Label numbersAmountLabel;
        private System.Windows.Forms.TextBox numbersAmountInputBox;
        private System.Windows.Forms.Label rangeFromLabel;
        private System.Windows.Forms.TextBox rangeFromInputBox;
        private System.Windows.Forms.Label rangeToLabel;
        private System.Windows.Forms.TextBox rangeToInputBox;
        private System.Windows.Forms.CheckBox includeFromCheckBox;
        private System.Windows.Forms.CheckBox includeToCheckBox;
        private System.Windows.Forms.Label resultTypeLabel;
        private System.Windows.Forms.ComboBox resultTypeComboBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox resultBox;
        private Button clearButton;
    }
}