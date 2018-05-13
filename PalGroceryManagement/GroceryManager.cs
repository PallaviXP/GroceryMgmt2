using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;


namespace PalGroceryManagement
{
    public partial class GroceryManager
    {
        static GroceryManager _defaultInstance = new GroceryManager();
        MobileServiceClient _client;
        IMobileServiceTable<Grocery> _groceryTable;
        const string offlineDbPath = @"localstore.db";

        private GroceryManager()
        {
            this._client = new MobileServiceClient(Constants.ApplicationURL);
            this._groceryTable = _client.GetTable<Grocery>();
        }

        public static GroceryManager DefaultManager
        {
            get
            {
                return _defaultInstance;
            }
            private set
            {
                _defaultInstance = value;
            }
        }

        public MobileServiceClient CurrentClient
        {
            get { return _client; }
        }

        public bool IsOfflineEnabled
        {
            get { return _groceryTable is Microsoft.WindowsAzure.MobileServices.Sync.IMobileServiceSyncTable<Grocery>; }
        }

        public async Task<ObservableCollection<Grocery>> GetGrocerysAsync(bool syncItems = false)
        {
            try
            {

                IEnumerable<Grocery> items = await _groceryTable
                    .Where(todoItem => !todoItem.IsComplete)
                    .ToEnumerableAsync();

                return new ObservableCollection<Grocery>(items);
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"Sync error: {0}", e.Message);
            }
            return null;
        }

        public async Task SaveTaskAsync(Grocery item)
        {
            if (item.Id == null)
            {
                await _groceryTable.InsertAsync(item);
            }
            else
            {
                await _groceryTable.UpdateAsync(item);
            }
        }
        
    }
}
