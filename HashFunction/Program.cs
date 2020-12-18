using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashFunction.ModelComponents;
using HashFunction.PresenterComponents;
using HashFunction.View;

namespace HashFunction
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainWindow mainWindow = new MainWindow();
            IModel model = new Model();
            Presenter presenter = new Presenter(mainWindow, model);

            Application.Run((Form) mainWindow);
        }
    }
}
