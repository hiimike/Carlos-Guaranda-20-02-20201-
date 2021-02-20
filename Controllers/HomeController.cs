using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test_BertoniSolutions.Models;
using Test_BertoniSolutions.Services;

namespace Test_BertoniSolutions.Controllers
{
    public class HomeController : Controller
    {
        public IDataStore<Album> AlbumsDataStore => new AlbumsDataStore();
        public IDataStore<Photo> PhotoDataStore => new PhotosDataStore();
        public IDataStore<Comment> CommentsDataStore => new CommentDataStore();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            IEnumerable<Album> albums = await AlbumsDataStore.GetItemsAsync();
            return View(model: albums);
        }

        public async Task<ActionResult> Photos(int id)

        {
            IEnumerable<Photo> photos = await PhotoDataStore.GetItemsAsync();
            photos = photos.Where(w => w.AlbumId == id).ToList();
            return PartialView(model: photos);
        }

        public async Task<ActionResult> Comments(int id)
        {
            IEnumerable<Comment> comments = await CommentsDataStore.GetItemsAsync();
            comments = comments.Where(w => w.PhotoId == id).ToList();
            return PartialView(model: comments);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
