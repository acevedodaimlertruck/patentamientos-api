using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Microsoft.AspNetCore.Mvc;

namespace LCH.MercedesBenz.Api.Services.Azure
{
    public class AzureService
    {
        private readonly IConfiguration _configuration;

        public AzureService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> UploadCSVToAzureAsync(FileStream file, string fileName)
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(_configuration["Storage:ConnectionString"]);
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference($"{_configuration["Storage:Container"]}");
            if (await cloudBlobContainer.CreateIfNotExistsAsync())
            {
                await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Off });
            }
            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference($"{_configuration["Storage:NewsCsvDirectory"] + fileName}");
            cloudBlockBlob.Properties.ContentType = "text/csv";
            file.Position = 0;
            await cloudBlockBlob.UploadFromStreamAsync(file);
            return cloudBlockBlob.Uri.ToString();
        }

        public async Task DeleteFromAzureAsync(string fileName)
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(_configuration["Storage:ConnectionString"]);

            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference($"{_configuration["Storage:Container"]}");

            if (await cloudBlobContainer.CreateIfNotExistsAsync())
            {
                await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Off });
            }
            CloudBlockBlob cloudBlockBlob;
            cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);

            await cloudBlockBlob.DeleteAsync();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public void deleteFileTemporal(string filePath)
        {
            // Check if file exists with its full path    
            if (System.IO.File.Exists(Path.Combine(filePath)))
            {
                // If file found, delete it    
                System.IO.File.Delete(Path.Combine(filePath));
                Console.WriteLine("Archivo eliminado.");
            }
            else Console.WriteLine("Archivo no encontrado.");
        }
    }
}
