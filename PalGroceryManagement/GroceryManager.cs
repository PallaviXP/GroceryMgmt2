using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using PalGroceryManagement.HttpCommunication;
using System.Net;
using Newtonsoft.Json;

namespace PalGroceryManagement
{
    public partial class GroceryManager
    {
        static GroceryManager _defaultInstance = new GroceryManager();
        const string offlineDbPath = @"localstore.db";
        HttpCommunicator _communicator;

        public GroceryManager()
        {
            _communicator = new HttpCommunicator();
        }
                            
        public async Task<List<Grocery>> GetGrocerysAsync()
        {
            try
            {
                var response = await _communicator.GetAsync(Constants.GroceryListURL);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var deserilizedObj = JsonConvert.DeserializeObject<List<Grocery>>(jsonString);
                    return deserilizedObj;
                }
                else
                    return null;

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
           
        }
        
    }
}
