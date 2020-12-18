using System;
using System.Collections.Generic;
using HashFunction.Common;
using HashFunction.ModelComponents;
using HashFunction.PresenterComponents.Exceptions;
using HashFunction.View;

namespace HashFunction.PresenterComponents
{
    class Presenter
    {
        private readonly IMainWindow _mainWindow;
        private readonly IModel _model;
        private int _selectedQuasigroupIndex;
        private int _selectedQuasigroupOrder;

        public Presenter(IMainWindow mainWindow, IModel model)
        {
            _mainWindow = mainWindow;
            _model = model;

            _selectedQuasigroupOrder = -1;
            _selectedQuasigroupIndex = -1;

            _mainWindow.SelectedIndexChanged += MainWindowOnSelectedIndexChanged;
            _mainWindow.QuasigroupOrderChanged += MainWindowOnQuasigroupOrderChanged;
            _mainWindow.ButtonHashPressed += MainWindowOnButtonHashPressed;
            _mainWindow.ButtonAddQuasigroupPressed += MainWindowOnButtonAddQuasigroupPressed;
            _mainWindow.ButtonRemoveQuasigroupPressed += MainWindowOnButtonRemoveQuasigroupPressed;
            _mainWindow.ButtonRemoveAllQuasigroupPressed += MainWindowOnButtonRemoveAllQuasigroupPressed;
            _mainWindow.ButtonRandomFillCayleyTablePressed += MainWindowOnButtonRandomFillCayleyTablePressed;
            _mainWindow.CayleyTableEditing += MainWindowOnCayleyTableEditing;
            _mainWindow.ButtonApplyCayleyTablePressed += MainWindowOnButtonApplyCayleyTablePressed;
            _mainWindow.StartValueChanged += MainWindowOnStartValueChanged;
            _mainWindow.SetOperationsOrder += MainWindowOnSetOperationsOrder;
            _mainWindow.ButtonRandomFillOperationsOrderPressed += MainWindowOnButtonRandomFillOperationsOrderPressed;

            _mainWindow.EnableAppyCaleyTableButton(false);
            _mainWindow.EnableRandomFillCayleyTableButton(false);
        }

        private void MainWindowOnButtonRandomFillOperationsOrderPressed()
        {
            var order = _model.GenerateQuasigroupsOperationsOrder();

            _mainWindow.SetOperationsOrderText(string.Join(", ", order));
        }

        private void MainWindowOnSetOperationsOrder(List<string> list)
        {
            var ordersList = OperationsOrderDataAdapter.Adapt(list);

            _model.SetQuasigroupsOperationsOrder(ordersList);
        }

        private void MainWindowOnStartValueChanged(int value)
        {
            _model.SetStartValue(value);
        }

        private void MainWindowOnButtonApplyCayleyTablePressed(string[,] data)
        {
            if (_selectedQuasigroupIndex < 0)
            {
                return;
            }

            var quasigroupData = QuasigroupDataAdapter.AdaptViewToQuasigroupData(data);
            _model.FillQuasigroupCayleyTableWithData(_selectedQuasigroupIndex, quasigroupData);
            _mainWindow.EnableAppyCaleyTableButton(false);

            UpdateCayleyTable();
        }

        private void MainWindowOnCayleyTableEditing()
        {
            _mainWindow.EnableAppyCaleyTableButton(true);
        }

        private void MainWindowOnButtonRandomFillCayleyTablePressed()
        {
            if (_selectedQuasigroupIndex < 0)
            {
                return;
            }

            _model.FillQuasigroupCayleyTableWithRandom(_selectedQuasigroupIndex);

            UpdateCayleyTable();
        }

        private void MainWindowOnButtonRemoveAllQuasigroupPressed()
        {
            _model.RemoveAllQuasigroups();
            _mainWindow.SetOutputText(string.Empty);

            UpdateListOfIds();
        }

        private void MainWindowOnButtonRemoveQuasigroupPressed()
        {
            if (_selectedQuasigroupIndex < 0)
            {
                return;
            }

            _model.RemoveQuasigroupByIndex(_selectedQuasigroupIndex);
            _mainWindow.SetOutputText(string.Empty);

            UpdateListOfIds();
        }

        private void MainWindowOnButtonAddQuasigroupPressed()
        {
            if (_selectedQuasigroupOrder < 0)
            {
                throw new OrderIsNotValidException();
            }

            _model.AddQuasigroup(_selectedQuasigroupOrder);
            _mainWindow.SetOutputText(string.Empty);

            UpdateListOfIds();
        }

        private void MainWindowOnButtonHashPressed(string text)
        {
            var hash = _model.Hash(text);
            _mainWindow.SetOutputText(hash);
        }

        private void MainWindowOnQuasigroupOrderChanged(int order)
        {
            _selectedQuasigroupOrder = order;
            _selectedQuasigroupIndex = -1;

            _model.RemoveAllQuasigroups();
            _mainWindow.ClearListBoxQuasigroupsIndexes();
            _mainWindow.ClearTable();
            _mainWindow.SetOutputText(string.Empty);
            _mainWindow.EnableAppyCaleyTableButton(false);
            _mainWindow.EnableRandomFillCayleyTableButton(false);
        }

        private void MainWindowOnSelectedIndexChanged(int index)
        {
            // Спорный момент..
            if (index == _selectedQuasigroupIndex)
                return;

            _selectedQuasigroupIndex = index;
            _mainWindow.EnableAppyCaleyTableButton(false);
            _mainWindow.EnableRandomFillCayleyTableButton(index != -1);

            UpdateCayleyTable();
        }

        private void UpdateListOfIds()
        {
            _mainWindow.FillListBoxQuasigroupsIndexes(_model.GetListOfQuasigroupsIds());
        }

        private void UpdateCayleyTable()
        {
            if (_selectedQuasigroupIndex < 0)
            {
                _mainWindow.ClearTable();
                return;
            }

            var q = _model.GetQuasigroupByIndex(_selectedQuasigroupIndex);
            var table = QuasigroupDataAdapter.AdaptQuasigroupDataToView(q);

            _mainWindow.FillTable(table);
        }
    }
}
