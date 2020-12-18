using System;
using System.Collections.Generic;

namespace HashFunction.View
{
    interface IMainWindow
    {
        void Show();
        void FillTable(string[,] table);
        void FillListBoxQuasigroupsIndexes(List<int> indexes);
        void ClearTable();
        void SetOutputText(string text);
        void SetOperationsOrderText(string text);
        void ClearListBoxQuasigroupsIndexes();
        void ShowMessageBox(string text);
        void EnableAppyCaleyTableButton(bool enabled);
        void EnableRandomFillCayleyTableButton(bool enabled);
        event Action<int> SelectedIndexChanged;
        event Action<int> StartValueChanged;
        event Action<int> QuasigroupOrderChanged;
        event Action<string> ButtonHashPressed;
        event Action ButtonAddQuasigroupPressed;
        event Action ButtonRemoveQuasigroupPressed;
        event Action ButtonRemoveAllQuasigroupPressed;
        event Action ButtonRandomFillCayleyTablePressed;
        event Action ButtonRandomFillOperationsOrderPressed;
        event Action CayleyTableEditing;
        event Action<string[,]> ButtonApplyCayleyTablePressed;
        event Action<List<string>> SetOperationsOrder;
    }
}
