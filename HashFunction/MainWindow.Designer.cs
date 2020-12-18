namespace HashFunction
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxQuasigroupsIndexes = new System.Windows.Forms.ListBox();
            this.buttonApplyCayleyTable = new System.Windows.Forms.Button();
            this.comboBoxQuasigroupOrder = new System.Windows.Forms.ComboBox();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.textBoxOutputText = new System.Windows.Forms.TextBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.buttonAddQuasigroup = new System.Windows.Forms.Button();
            this.buttonRemoveQuasigroup = new System.Windows.Forms.Button();
            this.buttonClearQuasigroups = new System.Windows.Forms.Button();
            this.buttonRandomFillCayleyTable = new System.Windows.Forms.Button();
            this.comboBoxStartValue = new System.Windows.Forms.ComboBox();
            this.labelQuasigroupOrder = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.labelInputText = new System.Windows.Forms.Label();
            this.labelOutputHash = new System.Windows.Forms.Label();
            this.numericUpDownHashSize = new System.Windows.Forms.NumericUpDown();
            this.labelHashSize = new System.Windows.Forms.Label();
            this.listBoxHashDigitSelector = new System.Windows.Forms.ListBox();
            this.textBoxOperationsOrderForCurrentDigit = new System.Windows.Forms.TextBox();
            this.buttonRandomFillOperationsOrder = new System.Windows.Forms.Button();
            this.labelSelectHashDigit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuasigroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHashSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(130, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(291, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // listBoxQuasigroupsIndexes
            // 
            this.listBoxQuasigroupsIndexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxQuasigroupsIndexes.FormattingEnabled = true;
            this.listBoxQuasigroupsIndexes.ItemHeight = 20;
            this.listBoxQuasigroupsIndexes.Location = new System.Drawing.Point(15, 104);
            this.listBoxQuasigroupsIndexes.Name = "listBoxQuasigroupsIndexes";
            this.listBoxQuasigroupsIndexes.Size = new System.Drawing.Size(88, 264);
            this.listBoxQuasigroupsIndexes.TabIndex = 1;
            this.listBoxQuasigroupsIndexes.SelectedIndexChanged += new System.EventHandler(this.listBoxQuasigroupsIndexes_SelectedIndexChanged);
            // 
            // buttonApplyCayleyTable
            // 
            this.buttonApplyCayleyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplyCayleyTable.Location = new System.Drawing.Point(438, 328);
            this.buttonApplyCayleyTable.Name = "buttonApplyCayleyTable";
            this.buttonApplyCayleyTable.Size = new System.Drawing.Size(114, 40);
            this.buttonApplyCayleyTable.TabIndex = 2;
            this.buttonApplyCayleyTable.Text = "Применить";
            this.buttonApplyCayleyTable.UseVisualStyleBackColor = true;
            this.buttonApplyCayleyTable.Click += new System.EventHandler(this.buttonApplyCayleyTable_Click);
            // 
            // comboBoxQuasigroupOrder
            // 
            this.comboBoxQuasigroupOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuasigroupOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxQuasigroupOrder.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuasigroupOrder.Location = new System.Drawing.Point(15, 40);
            this.comboBoxQuasigroupOrder.Name = "comboBoxQuasigroupOrder";
            this.comboBoxQuasigroupOrder.Size = new System.Drawing.Size(191, 28);
            this.comboBoxQuasigroupOrder.TabIndex = 3;
            this.comboBoxQuasigroupOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuasigroupOrder_SelectedIndexChanged);
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputText.Location = new System.Drawing.Point(15, 560);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.Size = new System.Drawing.Size(673, 82);
            this.textBoxInputText.TabIndex = 4;
            // 
            // textBoxOutputText
            // 
            this.textBoxOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutputText.Location = new System.Drawing.Point(15, 689);
            this.textBoxOutputText.Multiline = true;
            this.textBoxOutputText.Name = "textBoxOutputText";
            this.textBoxOutputText.ReadOnly = true;
            this.textBoxOutputText.Size = new System.Drawing.Size(673, 82);
            this.textBoxOutputText.TabIndex = 5;
            // 
            // buttonHash
            // 
            this.buttonHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHash.Location = new System.Drawing.Point(726, 689);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(135, 82);
            this.buttonHash.TabIndex = 6;
            this.buttonHash.Text = "Хэшировать";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // buttonAddQuasigroup
            // 
            this.buttonAddQuasigroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddQuasigroup.Location = new System.Drawing.Point(15, 384);
            this.buttonAddQuasigroup.Name = "buttonAddQuasigroup";
            this.buttonAddQuasigroup.Size = new System.Drawing.Size(37, 40);
            this.buttonAddQuasigroup.TabIndex = 7;
            this.buttonAddQuasigroup.Text = "+";
            this.buttonAddQuasigroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddQuasigroup.UseVisualStyleBackColor = true;
            this.buttonAddQuasigroup.Click += new System.EventHandler(this.buttonAddQuasigroup_Click);
            // 
            // buttonRemoveQuasigroup
            // 
            this.buttonRemoveQuasigroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveQuasigroup.Location = new System.Drawing.Point(66, 384);
            this.buttonRemoveQuasigroup.Name = "buttonRemoveQuasigroup";
            this.buttonRemoveQuasigroup.Size = new System.Drawing.Size(37, 40);
            this.buttonRemoveQuasigroup.TabIndex = 8;
            this.buttonRemoveQuasigroup.Text = "-";
            this.buttonRemoveQuasigroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRemoveQuasigroup.UseVisualStyleBackColor = true;
            this.buttonRemoveQuasigroup.Click += new System.EventHandler(this.buttonRemoveQuasigroup_Click);
            // 
            // buttonClearQuasigroups
            // 
            this.buttonClearQuasigroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearQuasigroups.Location = new System.Drawing.Point(130, 384);
            this.buttonClearQuasigroups.Name = "buttonClearQuasigroups";
            this.buttonClearQuasigroups.Size = new System.Drawing.Size(114, 40);
            this.buttonClearQuasigroups.TabIndex = 9;
            this.buttonClearQuasigroups.Text = "Очистить";
            this.buttonClearQuasigroups.UseVisualStyleBackColor = true;
            this.buttonClearQuasigroups.Click += new System.EventHandler(this.buttonClearQuasigroups_Click);
            // 
            // buttonRandomFillCayleyTable
            // 
            this.buttonRandomFillCayleyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandomFillCayleyTable.Location = new System.Drawing.Point(438, 282);
            this.buttonRandomFillCayleyTable.Name = "buttonRandomFillCayleyTable";
            this.buttonRandomFillCayleyTable.Size = new System.Drawing.Size(114, 40);
            this.buttonRandomFillCayleyTable.TabIndex = 10;
            this.buttonRandomFillCayleyTable.Text = "Случайно";
            this.buttonRandomFillCayleyTable.UseVisualStyleBackColor = true;
            this.buttonRandomFillCayleyTable.Click += new System.EventHandler(this.buttonRandomFillCayleyTable_Click);
            // 
            // comboBoxStartValue
            // 
            this.comboBoxStartValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStartValue.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxStartValue.Location = new System.Drawing.Point(15, 481);
            this.comboBoxStartValue.Name = "comboBoxStartValue";
            this.comboBoxStartValue.Size = new System.Drawing.Size(191, 28);
            this.comboBoxStartValue.TabIndex = 11;
            this.comboBoxStartValue.Tag = "";
            this.comboBoxStartValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartValue_SelectedIndexChanged);
            // 
            // labelQuasigroupOrder
            // 
            this.labelQuasigroupOrder.AutoSize = true;
            this.labelQuasigroupOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuasigroupOrder.Location = new System.Drawing.Point(12, 9);
            this.labelQuasigroupOrder.Name = "labelQuasigroupOrder";
            this.labelQuasigroupOrder.Size = new System.Drawing.Size(168, 20);
            this.labelQuasigroupOrder.TabIndex = 12;
            this.labelQuasigroupOrder.Text = "Порядок квазигрупп:";
            // 
            // labelStartValue
            // 
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartValue.Location = new System.Drawing.Point(12, 446);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(170, 20);
            this.labelStartValue.TabIndex = 13;
            this.labelStartValue.Text = "Начальный элемент:";
            // 
            // labelInputText
            // 
            this.labelInputText.AutoSize = true;
            this.labelInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputText.Location = new System.Drawing.Point(11, 524);
            this.labelInputText.Name = "labelInputText";
            this.labelInputText.Size = new System.Drawing.Size(125, 20);
            this.labelInputText.TabIndex = 14;
            this.labelInputText.Text = "Входной текст:";
            // 
            // labelOutputHash
            // 
            this.labelOutputHash.AutoSize = true;
            this.labelOutputHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutputHash.Location = new System.Drawing.Point(11, 655);
            this.labelOutputHash.Name = "labelOutputHash";
            this.labelOutputHash.Size = new System.Drawing.Size(46, 20);
            this.labelOutputHash.TabIndex = 15;
            this.labelOutputHash.Text = "Хэш:";
            // 
            // numericUpDownHashSize
            // 
            this.numericUpDownHashSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHashSize.Location = new System.Drawing.Point(610, 40);
            this.numericUpDownHashSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHashSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHashSize.Name = "numericUpDownHashSize";
            this.numericUpDownHashSize.Size = new System.Drawing.Size(201, 26);
            this.numericUpDownHashSize.TabIndex = 16;
            this.numericUpDownHashSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHashSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHashSize.ValueChanged += new System.EventHandler(this.numericUpDownHashSize_ValueChanged);
            // 
            // labelHashSize
            // 
            this.labelHashSize.AutoSize = true;
            this.labelHashSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHashSize.Location = new System.Drawing.Point(606, 9);
            this.labelHashSize.Name = "labelHashSize";
            this.labelHashSize.Size = new System.Drawing.Size(104, 20);
            this.labelHashSize.TabIndex = 17;
            this.labelHashSize.Text = "Длина хэша:";
            // 
            // listBoxHashDigitSelector
            // 
            this.listBoxHashDigitSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxHashDigitSelector.FormattingEnabled = true;
            this.listBoxHashDigitSelector.ItemHeight = 20;
            this.listBoxHashDigitSelector.Location = new System.Drawing.Point(610, 104);
            this.listBoxHashDigitSelector.Name = "listBoxHashDigitSelector";
            this.listBoxHashDigitSelector.Size = new System.Drawing.Size(201, 204);
            this.listBoxHashDigitSelector.TabIndex = 18;
            this.listBoxHashDigitSelector.SelectedIndexChanged += new System.EventHandler(this.listBoxHashDigitSelector_SelectedIndexChanged);
            // 
            // textBoxOperationsOrderForCurrentDigit
            // 
            this.textBoxOperationsOrderForCurrentDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOperationsOrderForCurrentDigit.Location = new System.Drawing.Point(610, 342);
            this.textBoxOperationsOrderForCurrentDigit.Name = "textBoxOperationsOrderForCurrentDigit";
            this.textBoxOperationsOrderForCurrentDigit.Size = new System.Drawing.Size(251, 26);
            this.textBoxOperationsOrderForCurrentDigit.TabIndex = 19;
            this.textBoxOperationsOrderForCurrentDigit.TextChanged += new System.EventHandler(this.textBoxOperationsOrderForCurrentDigit_TextChanged);
            // 
            // buttonRandomFillOperationsOrder
            // 
            this.buttonRandomFillOperationsOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandomFillOperationsOrder.Location = new System.Drawing.Point(610, 374);
            this.buttonRandomFillOperationsOrder.Name = "buttonRandomFillOperationsOrder";
            this.buttonRandomFillOperationsOrder.Size = new System.Drawing.Size(114, 40);
            this.buttonRandomFillOperationsOrder.TabIndex = 20;
            this.buttonRandomFillOperationsOrder.Text = "Случайно";
            this.buttonRandomFillOperationsOrder.UseVisualStyleBackColor = true;
            this.buttonRandomFillOperationsOrder.Click += new System.EventHandler(this.buttonRandomFillOperationsOrder_Click);
            // 
            // labelSelectHashDigit
            // 
            this.labelSelectHashDigit.AutoSize = true;
            this.labelSelectHashDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectHashDigit.Location = new System.Drawing.Point(606, 76);
            this.labelSelectHashDigit.Name = "labelSelectHashDigit";
            this.labelSelectHashDigit.Size = new System.Drawing.Size(133, 20);
            this.labelSelectHashDigit.TabIndex = 21;
            this.labelSelectHashDigit.Text = "Позиция в хэше:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(606, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Порядок операций для позиции:";
            // 
            // labelQuasigroups
            // 
            this.labelQuasigroups.AutoSize = true;
            this.labelQuasigroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuasigroups.Location = new System.Drawing.Point(12, 76);
            this.labelQuasigroups.Name = "labelQuasigroups";
            this.labelQuasigroups.Size = new System.Drawing.Size(110, 20);
            this.labelQuasigroups.TabIndex = 23;
            this.labelQuasigroups.Text = "Квазигруппы:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 783);
            this.Controls.Add(this.labelQuasigroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSelectHashDigit);
            this.Controls.Add(this.buttonRandomFillOperationsOrder);
            this.Controls.Add(this.textBoxOperationsOrderForCurrentDigit);
            this.Controls.Add(this.listBoxHashDigitSelector);
            this.Controls.Add(this.labelHashSize);
            this.Controls.Add(this.numericUpDownHashSize);
            this.Controls.Add(this.labelOutputHash);
            this.Controls.Add(this.labelInputText);
            this.Controls.Add(this.labelStartValue);
            this.Controls.Add(this.labelQuasigroupOrder);
            this.Controls.Add(this.comboBoxStartValue);
            this.Controls.Add(this.buttonRandomFillCayleyTable);
            this.Controls.Add(this.buttonClearQuasigroups);
            this.Controls.Add(this.buttonRemoveQuasigroup);
            this.Controls.Add(this.buttonAddQuasigroup);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.textBoxOutputText);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.comboBoxQuasigroupOrder);
            this.Controls.Add(this.buttonApplyCayleyTable);
            this.Controls.Add(this.listBoxQuasigroupsIndexes);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Hash Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHashSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxQuasigroupsIndexes;
        private System.Windows.Forms.Button buttonApplyCayleyTable;
        private System.Windows.Forms.ComboBox comboBoxQuasigroupOrder;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.TextBox textBoxOutputText;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.Button buttonAddQuasigroup;
        private System.Windows.Forms.Button buttonRemoveQuasigroup;
        private System.Windows.Forms.Button buttonClearQuasigroups;
        private System.Windows.Forms.Button buttonRandomFillCayleyTable;
        private System.Windows.Forms.ComboBox comboBoxStartValue;
        private System.Windows.Forms.Label labelQuasigroupOrder;
        private System.Windows.Forms.Label labelStartValue;
        private System.Windows.Forms.Label labelInputText;
        private System.Windows.Forms.Label labelOutputHash;
        private System.Windows.Forms.NumericUpDown numericUpDownHashSize;
        private System.Windows.Forms.Label labelHashSize;
        private System.Windows.Forms.ListBox listBoxHashDigitSelector;
        private System.Windows.Forms.TextBox textBoxOperationsOrderForCurrentDigit;
        private System.Windows.Forms.Button buttonRandomFillOperationsOrder;
        private System.Windows.Forms.Label labelSelectHashDigit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuasigroups;
    }
}

