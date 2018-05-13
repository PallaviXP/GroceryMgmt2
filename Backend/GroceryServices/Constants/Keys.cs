namespace GroceryServices.Constants
{
    public static class Keys
    {
        //public static readonly string CosmosEndpointUrl = "** URL **";
        public static readonly string CosmosEndpointUrl = "https://grocerymanagemntcosmosdb.documents.azure.com:443/";

        //public static readonly string CosmosAuthKey = "** AUTHKEY **";
        public static readonly string CosmosAuthKey = "iWAUTydJtoMxS4B2oWStVIDaQ7IxuwfuskcVV27YjxMs4oVotiNZ9s6szYWwfsnvl1VAM8ukR7zMAT6FjIOhIg==";
        internal static readonly string DatabaseId = "grocerymanagemnt-database";
        internal static readonly string CollectionId = "grocerymanagemnt-collection";
        internal static readonly int OfferThroughput = 400;
    }
}
