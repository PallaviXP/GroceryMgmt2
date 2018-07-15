namespace GroceryServices.Constants
{
    public static class Keys
    {
        //public static readonly string CosmosEndpointUrl = "** URL **";
        public static readonly string CosmosEndpointUrl = "https://grocerymanagemntcosmosdb.documents.azure.com:443/";
     
        //public static readonly string CosmosAuthKey = "** AUTHKEY **";
        public static readonly string CosmosAuthKey = "85NGCa6nmKoSWaTI9U9doioD1vjHoPSbFQC97gODmQEIczIfrfX9F304FwGylCPUytN6Sstdcw541n66Y0Xi2w==";
        internal static readonly string DatabaseId = "grocerymanagemnt-database";
        internal static readonly string CollectionId = "grocerymanagemnt-collection";
        internal static readonly int OfferThroughput = 400;
    }
}
