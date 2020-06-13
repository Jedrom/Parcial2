using AppParcial2.Models;
using AppParcial2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.ViewModels
{
   public class MockupsViewModel:BaseViewModel
    {
        //apiservice
        #region Service
        private ApiService apiService;

        #endregion

        #region Attributes
        private string albumId;
        private string id;
        private string title;
        #endregion

        #region Properties
        public string AlbumId
        {
            get { return this.albumId; }
            set { SetValue(ref this.albumId, value); }
        }
        public string Id
        {
            get { return this.id; }
            set { SetValue(ref this.id, value); }
        }
        public string Tittle
        {
            get { return this.title; }
            set { SetValue(ref this.title, value); }
        }
        #endregion

        #region Constructor
        public MockupsViewModel()
        {
            apiService = new ApiService();
            this.LoadMockupsAsync();
        }
        #endregion

        #region Methods
        private async void LoadMockupsAsync()
        {
            var country = await this.apiService.Get<Mockups>(
                "https://jsonplaceholder.typicode.com/",
                "rest/photos",
                "name/ID"
                );
            this.AlbumId = mockups[0].AlbumId;
            this.Id = mockups[0].Id;
            this.Tittle = mockups[0].Tittle;
        }
        #endregion
    }
}
