using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MovieProDemo.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> EncodeImageAsync(IFormFile poster);

        Task<byte[]> EncodeImageURLAsync(string imageURL);

        string DecodeImage(byte[] poster, string contentType);

    }
}

