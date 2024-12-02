using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.Extensions.Options;

namespace Infrastructure.ExternalApi.ImageServer
{
    public interface IImageUploadService
    {
        List<string> Upload(List<IFormFile> files);
    }
    public class ImageUploadService : IImageUploadService
    {

        public List<string> Upload(List<IFormFile> files)
        {
        

            //var request = new RestRequest(Method.Post.ToString());
            var options = new RestClientOptions("https://localhost:7046/api/Images?apikey=mysecretkey")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://localhost:7046/api/Images?apikey=mysecretkey", Method.Post);
            request.Timeout = TimeSpan.FromSeconds
                (5);    
            foreach (var item in files)
            {
                byte[] bytes;
                using (var ms = new MemoryStream())
                {
                    item.CopyToAsync(ms);
                    bytes = ms.ToArray();
                }
                request.AddFile(item.FileName, bytes, item.FileName, item.ContentType);
            }

            //RestResponse response = await client.ExecuteAsync(request);
            RestResponse response = client.Execute(request);
            UploadDto upload = JsonConvert.DeserializeObject<UploadDto>(response.Content);
            return upload.FileNameAddress;

        }

        

    }
   
    //RestResponse response = await client.ExecuteAsync(request);
    //Console.WriteLine(response.Content);


    public class UploadDto
    {
        public bool Status { get; set; }
        public  List<string>? FileNameAddress { get; set; }
    }
}
