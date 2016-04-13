﻿using System.Collections.Generic;
using System.Web;
using Orchard.ImageGallery.Models;
using Orchard;

namespace Orchard.ImageGallery.Services {
    public interface IImageGalleryService : IDependency {
        IEnumerable<Models.ImageGallery> GetImageGalleries();

        IEnumerable<string> AllowedFileFormats { get; }

        Models.ImageGallery GetImageGallery(string imageGalleryName);

        void CreateImageGallery(string imageGalleryName);
        void DeleteImageGallery(string imageGalleryName);
        void RenameImageGallery(string imageGalleryName, string newName);
        void UpdateImageGalleryProperties(string name, int thumbnailHeight, int thumbnailWidth, bool keepAspectRatio, bool expandToFill);

        ImageGalleryImage GetImage(string galleryName, string imageName);
        void AddImage(string imageGalleryName, HttpPostedFileBase imageFile);
        void UpdateImageProperties(string imageGalleryName, string imageName, string imageTitle, string imageCaption);
        void DeleteImage(string imageGalleryName, string imageName);

        string GetPublicUrl(string path);
        bool IsFileAllowed(HttpPostedFileBase file);

        void ReorderImages(string imageGalleryName, IEnumerable<string> images);
    }
}