using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IMainView
    {
        /// <summary>
        /// Show form
        /// </summary>
        void Show();

        event Action SendData;
        void Recolor();
        void OutputData(int value);
    }
}