using System.Diagnostics;
using HistoryPediaV2.Core.Repositories;
using HistoryPediaV2.Data.Models;
using HistoryPediaV2.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPediaV2.MVC.Controllers;

public class PicturesController: Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPicturesRepository _picturesRepository;

    public PicturesController(ILogger<HomeController> logger, IPicturesRepository picturesRepository)
    {
        _logger = logger;
        _picturesRepository = picturesRepository;
    }
    
    //[Authorize]
    public async Task<ActionResult> Edit(long pictureId)
        {
            // if (pictureName != null)
            // {
            //     Picture picture = await db.Pictures.FirstOrDefaultAsync(p => p.PictureName == pictureName);
            //     if (picture == null)
            //     {
            //         picture = DataClass.ImagesTempList.FirstOrDefault(p => p.PictureName == pictureName);
            //     }
            //     if (picture != null)
            //     {
            //         PictureViewModel pictureLoad = new PictureViewModel();
            //         pictureLoad.PictureText = picture.PictureText;
            //         pictureLoad.PictureName = picture.PictureName;
            //         pictureLoad.PicturePrevName = pictureLoad.PictureName;
            //         pictureLoad.Type = type;
            //         return View(pictureLoad);
            //     }
            // }
            // else
            // {
            //     PictureViewModel picture = new PictureViewModel();
            //     picture.PictureName = "New picture";
            //     picture.Type = type;
            //     if (type == 1)
            //     {
            //         DataClass.TempArticle.ImageName = picture.PictureName;
            //     }
            //     else
            //     {
            //         DataClass.TempBlock.BlockImageName = picture.PictureName;
            //     }
            //     return View(picture);
            // }
            // return NotFound();
            var picture = await _picturesRepository.GetAsync<Picture>(pictureId);
            return View(picture);
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult> Edit()
        {
            // Picture picture = new Picture();
            // if (pictureLoad.PicturePrevName != null)
            // {
            //     picture = db.Pictures.FirstOrDefault(x => x.PictureName == pictureLoad.PicturePrevName);
            //     if (picture == null)
            //     {
            //         picture = DataClass.ImagesTempList.FirstOrDefault(p => p.PictureName == pictureLoad.PicturePrevName);
            //     }
            // }
            //
            // if (pictureLoad.PictureName != null)
            //     picture.PictureName = pictureLoad.PictureName;
            // if (pictureLoad.PictureText != null)
            //     picture.PictureText = pictureLoad.PictureText;
            // if (pictureLoad.Image != null)
            // {
            //     byte[] imageData = null;
            //     // считываем переданный файл в массив байтов
            //     using (var binaryReader = new BinaryReader(pictureLoad.Image.OpenReadStream()))
            //     {
            //         imageData = binaryReader.ReadBytes((int) pictureLoad.Image.Length);
            //     }
            //
            //     // установка массива байтов
            //     picture.Image = imageData;
            // }
            //
            // DataClass.ImagesTempList.Add(picture);
            //
            // if (pictureLoad.Type == 1)
            // {
            //     DataClass.TempArticle.ImageName = pictureLoad.PictureName;
            //     return View("Edit", DataClass.TempArticle);
            // }
            // DataClass.TempBlock.BlockImageName = pictureLoad.PictureName;
            // return View("EditBlock", DataClass.TempBlock);
            return RedirectToAction("Edit", "Blocks");
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        _logger.Log(LogLevel.Error, "Error thrown: {errorId}", requestId);
        return View(new ErrorViewModel { RequestId = requestId});
    }
}