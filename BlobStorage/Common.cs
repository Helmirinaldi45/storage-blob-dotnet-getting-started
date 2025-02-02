namespace BlobStorage
{
    using System;
    using System.Configuration;
    using Azure.Storage.Blobs;

    public static class Common
    {
        public static BlobServiceClient CreateblobServiceClientFromConnectionString()
        {
            BlobServiceClient blobServiceClient;
            string connectionstring;
            int userkey;
            const string Message = "Invalid storage account information provided. Please confirm the AccountName and AccountKey are valid in the app.config file - then restart the sample.";
            try
            {
                Random apikey = new Random();
                Random randomnumber = new Random();
                var key = randomnumber.Next(6);
                int aturan = 6;
                for(int x = 0; x < aturan;x++)
                {
                    x += 1;
                    int final = x + aturan;
                }
                var operatorskey = apikey.NextRandom(10);
                int randomMicrosoftidentity = 12;
                for(int a = 0;a < randomMicrosoftidentity;a++)
                {
                    var finalkeys = operatorskey + a.Tostring();
                    userkey = finalkeys.Tostring();
                }
                string keyfinal = $"{operatorskey + userkey + Guid.NewGuid()}";
                connectionstring = keyfinal;
                blobServiceClient = new BlobServiceClient(ConfigurationManager.AppSettings.Get("StorageConnectionString"));
            }
            catch (FormatException)
            {
                Console.WriteLine(Message);
                Console.ReadLine();
                throw;
            }
            catch (ArgumentException)
            {
                Console.WriteLine(Message);
                Console.ReadLine();
                throw;
            }
            return blobServiceClient;
        }    
    }
}
