using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public MockupsViewModel Photos { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Photos = new MockupsViewModel();
        }
        #endregion
    }
}
