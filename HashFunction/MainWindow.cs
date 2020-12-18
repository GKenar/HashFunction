using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HashFunction.MathStructures;
using HashFunction.MathStructures.Exceptions;
using HashFunction.PresenterComponents.Exceptions;
using HashFunction.View;

namespace HashFunction
{
    public partial class MainWindow : Form, IMainWindow
    {
        public event Action<int> SelectedIndexChanged = delegate { };
        public event Action<int> StartValueChanged = delegate { };
        public event Action<int> QuasigroupOrderChanged = delegate { };
        public event Action<string> ButtonHashPressed = delegate { };
        public event Action<List<string>> SetOperationsOrder = delegate { };
        public event Action ButtonAddQuasigroupPressed = delegate { };
        public event Action ButtonRemoveQuasigroupPressed = delegate { };
        public event Action ButtonRemoveAllQuasigroupPressed = delegate { };
        public event Action ButtonRandomFillCayleyTablePressed = delegate { };
        public event Action ButtonRandomFillOperationsOrderPressed = delegate { };
        public event Action CayleyTableEditing = delegate { };
        public event Action<string[,]> ButtonApplyCayleyTablePressed = delegate { };
        

        private List<string> _operationsOrderList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HashSizeChanged(_operationsOrderList.Count, 1);
        }

        public void ClearTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        public void ClearListBoxQuasigroupsIndexes()
        {
            listBoxQuasigroupsIndexes.Items.Clear();
        }


        // Переделать может через DataSource?
        public void FillTable(string[,] table)
        {
            var size = table.GetLength(0);

            ClearTable();

            for (var i = 0; i < size; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), string.Empty);
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            for (var i = 0; i < size; i++)
            {
                var row = new DataGridViewRow { ReadOnly = false };

                for (var j = 0; j < size; j++)
                {
                    var cell = new DataGridViewTextBoxCell { Value = table[i, j] };
                    row.Cells.Add(cell);
                }

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
        }

        private void listBoxQuasigroupsIndexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((ListBox)sender).SelectedIndex;

            SelectedIndexChanged(selectedIndex);
        }

        public void SetOutputText(string text)
        {
            textBoxOutputText.Text = text;
        }

        public void FillListBoxQuasigroupsIndexes(List<int> indexes)
        {
            ClearListBoxQuasigroupsIndexes();
            foreach (var item in indexes)
            {
                listBoxQuasigroupsIndexes.Items.Add(item);
            }

            SelectedIndexChanged(-1);
        }

        private void comboBoxQuasigroupOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = Convert.ToInt32(((ComboBox)sender).SelectedItem);
            QuasigroupOrderChanged(selectedIndex);
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            
            try
            {
                SetOperationsOrder(_operationsOrderList);
            }
            catch (FormatException)
            {
                ShowMessageBox("Неверный формат одной из строк, определяющих порядок применения операций");
                return;
            }
            catch
            {
                ShowMessageBox("Ошибка при разборе порядка применения операций");
                return;
            }
            
            try
            {
                ButtonHashPressed(textBoxInputText.Text);
            }
            catch (EmptyQuasigroupsListException)
            {
                ShowMessageBox("Не указаны квазигруппы");
            }
            catch (EmptyQuasigroupsOrderListException)
            {
                ShowMessageBox("Не указан порядок применения квазигрупп");
            }
            catch (QuasigroupIndexOutOfListException)
            {
                ShowMessageBox("Указанный номер квазигруппы в порядке применения операций не существует");
            }
            catch (ArgumentOutOfQuasigroup)
            {
                ShowMessageBox("Элемент, принимающий участие в операциях, отсутствует в квазигруппах");
            }
            catch (FormatException)
            {
                ShowMessageBox("Входной текст не соответствует формату");
            }
            catch (QuasigroupIsNotInitializedException)
            {
                ShowMessageBox("Одна из таблиц квазигрупп не инициализированна");
            }
            catch (StartValueIsNotInitializedException)
            {
                ShowMessageBox("Не указано начальное значение");
            }
            catch
            {
                ShowMessageBox("Ошибка при хэшировании");
            }
        }

        private void buttonAddQuasigroup_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonAddQuasigroupPressed();
            }
            catch (OrderIsNotValidException)
            {
                ShowMessageBox("Не выбран порядок квазигрупп");
            }
        }

        private void buttonRemoveQuasigroup_Click(object sender, EventArgs e)
        {
            ButtonRemoveQuasigroupPressed();
        }

        public void ShowMessageBox(string text)
        {
            MessageBox.Show(text, "Hash Function", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void EnableAppyCaleyTableButton(bool enabled)
        {
            buttonApplyCayleyTable.Enabled = enabled;
        }

        public void EnableRandomFillCayleyTableButton(bool enabled)
        {
            buttonRandomFillCayleyTable.Enabled = enabled;
        }

        private void buttonClearQuasigroups_Click(object sender, EventArgs e)
        {
            ButtonRemoveAllQuasigroupPressed();
        }

        private void buttonRandomFillCayleyTable_Click(object sender, EventArgs e)
        {
            ButtonRandomFillCayleyTablePressed();
        }

        private void buttonApplyCayleyTable_Click(object sender, EventArgs e)
        {
            var data = new string[dataGridView1.Rows.Count, dataGridView1.Columns.Count];

            try
            {
                for (var i = 0; i < data.GetLength(0); i++)
                {
                    for (var j = 0; j < data.GetLength(1); j++)
                    {
                        data[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch
            {
                ShowMessageBox("Ошибка при разборе таблицы");
                return;
            }

            try
            {
                ButtonApplyCayleyTablePressed(data);
            }
            catch (CayleyTableWrongElementException)
            {
                ShowMessageBox("Неподходящий элемент в таблице Кэли");
            }
            catch
            {
                ShowMessageBox("Ошибка при присвоении значений таблицы Кэли");
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CayleyTableEditing();
        }

        private void comboBoxStartValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var startValue = Convert.ToInt32(((ComboBox)sender).SelectedItem);

            StartValueChanged(startValue);
        }

        private void HashSizeChanged(int count, int requiredCount)
        {
            // Переделать может?
            if (count < requiredCount)
            {
                _operationsOrderList.AddRange(Enumerable.Range(0, requiredCount - count).Select(x => string.Empty));
            }
            else if (count > requiredCount)
            {
                _operationsOrderList.RemoveRange(requiredCount, count - requiredCount);
            }

            listBoxHashDigitSelector.Items.Clear();
            for (var i = 1; i <= _operationsOrderList.Count; i++)
            {
                listBoxHashDigitSelector.Items.Add(i.ToString());
            }
        }

        private void numericUpDownHashSize_ValueChanged(object sender, EventArgs e)
        {
            HashSizeChanged(_operationsOrderList.Count, Convert.ToInt32(numericUpDownHashSize.Value));
        }

        private void listBoxHashDigitSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHashDigitSelector.SelectedIndex < 0)
                return;
            
            textBoxOperationsOrderForCurrentDigit.Text = _operationsOrderList[listBoxHashDigitSelector.SelectedIndex];
        }

        private void textBoxOperationsOrderForCurrentDigit_TextChanged(object sender, EventArgs e)
        {
            if(listBoxHashDigitSelector.SelectedIndex < 0)
                return;

            _operationsOrderList[listBoxHashDigitSelector.SelectedIndex] = textBoxOperationsOrderForCurrentDigit.Text;
        }

        private void buttonRandomFillOperationsOrder_Click(object sender, EventArgs e)
        {
            if (listBoxHashDigitSelector.SelectedIndex < 0)
            {
                ShowMessageBox("Не выбрана позиция в хэше");
                return;
            }

            ButtonRandomFillOperationsOrderPressed();
        }

        public void SetOperationsOrderText(string text)
        {
            textBoxOperationsOrderForCurrentDigit.Text = text;
        }
    }
}
