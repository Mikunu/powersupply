using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Model class
    /// </summary>
    public class MainModel : IMainModel
    {
        private int RandomValue { get; set; }
        #region Constuctor

        /// <summary>
        /// Init constuctor
        /// </summary>
        public MainModel()
        {
            RandomValue = new Random().Next(0, 10);
        }

        #endregion

        public int GetData()
        {
            RandomValue = new Random().Next(0, 10);
            return RandomValue;
        }
    }
}