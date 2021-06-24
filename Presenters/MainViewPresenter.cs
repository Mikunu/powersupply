using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Presenters
{
    /// <summary>
    /// Presenter class
    /// </summary>
    public class MainViewPresenter
    {
        #region Private Properties

        /// <summary>
        /// Main View Exemplyar
        /// </summary>
        private IMainView MainView { get; set; }

        /// <summary>
        /// Main Model Exemplyar
        /// </summary>
        private IMainModel MainModel { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Init constuctor
        /// </summary>
        /// <param name="mainView">Exemplyar of class which implement <see cref="IMainView"/></param>
        /// <param name="mainModel">Exemplyar of class which implement <see cref="IMainModel"/></param>
        public MainViewPresenter(IMainView mainView, IMainModel mainModel)
        {
            MainView = mainView;
            MainModel = mainModel;
            mainView.SendData += MainViewOnSendData;
        }

        private void MainViewOnSendData()
        {
            MainView.Recolor();
            MainView.OutputData(MainModel.GetData());
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Run form Main View
        /// </summary>
        public void Run()
        {
            MainView.Show();
        }

        #endregion
    }
}