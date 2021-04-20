using System;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pull the token from the command line. Run with `profile.exe [token]`
            // or `dotnet run -- [token]`
            if (args.Length < 1)
            {
                Console.WriteLine("Must specify token on command line");
                return;
            }

            // Set the token in the configuration
            var config = new Configuration();
            config.ApiKey["X-API-Token"] = args[0];

            // Create the API client
            var collectionsApi = new CollectionsApi(config);

            try
            {
                // ..and retrieve the profile.
                var collectionList = collectionsApi.ListCollections();
                foreach (var collection in collectionList.Collections)
                {
                    Console.WriteLine(collection.CollectionId + " " + collection.Tags["name"]);
                }
            }
            catch (ApiException e)
            {
                // If something fails we'll get an ApiException
                Console.WriteLine("Got exception calling API: " + e.Message);
            }
        }
    }
}
