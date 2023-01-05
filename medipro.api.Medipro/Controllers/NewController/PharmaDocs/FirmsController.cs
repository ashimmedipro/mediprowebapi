using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class FirmsController : ApiController
    {
        [HttpPost]
        [Route("api/Firms")]
        public IHttpActionResult Post(Firms_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Firms_Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Firms/Update")]
        public IHttpActionResult Update(Firms_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_FirmsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Firms")]
        public IHttpActionResult Get(int firm)
        {
            var list = DapperHelper.QueryStoredProcedure<Firms_dt>
                ("sp_FirmsSelect", new { firm = firm }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Firms/Delete")]
        public IHttpActionResult Delete(FirmsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_FirmsDelete", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/photoupload")]
        public IHttpActionResult Postimage(photo_dt model)
        {

           

            DapperHelper.ExecuteStoredProcedure("sp_photoUpload", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Firms")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<Firms_dt>("sp_FirmActiveSelect").ToList();


            return Ok(list);
        }
    }
}










/* if (model.photo != null)
            {
                Image ConvertByteArrayToImage(byte[] photo)
{
    using (MemoryStream ms = new MemoryStream(photo))
    {
        return Image.FromStream(ms);
    }
}
byte[] ConvertImageToByteArray(Image image, string extension)
{
    using (var memoryStream = new MemoryStream())
    {
        switch (extension)
        {
            case ".jpeg":
            case ".jpg":
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                break;
            case ".png":
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                break;
            case ".gif":
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
                break;
        }
        return memoryStream.ToArray();
    }
}
            }*/



/*
 * 
 *   var a = model.photo.IndexOf(',');
        var b = model.photo.Substring(a + 1);

        a = model.photo.IndexOf(';');
        var c = model.photo.Substring(0,a);

        a = b.IndexOf("/");
        var e = b.Substring(a + 1);
        byte[] bytes = Convert.FromBase64String(b);

*/
