using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace PalGroceryManagement
{
	public class TodoItem
	{
		[JsonProperty(PropertyName = "id")]
		public string Id
		{
            get; set;
		}

		[JsonProperty(PropertyName = "text")]
		public string Name
		{
            get; set;
        }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity
        {
            get; set;
        }

        [JsonProperty(PropertyName = "weight")]
        public decimal Weight
        {
            get; set;
        }


        [JsonProperty(PropertyName = "complete")]
		public bool Done
		{
            get; set;
        }

        //[Version]
        //public string Version { get; set; }
	}
}

