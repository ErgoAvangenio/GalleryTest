using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GaleriaDeFotos.Models;

namespace GaleriaDeFotos.Controllers
{
    [Route("api/photos")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private List<Photo> _photos = new List<Photo>();

        // GET: 
        [HttpGet]
        public ActionResult<IEnumerable<Photo>> GetPhotos()
        {
            return _photos;
        }

        // GET: 
        [HttpGet("{id}", Name = "GetPhoto")]
        public ActionResult<Photo> GetPhoto(int id)
        {
            var photo = _photos.FirstOrDefault(p => p.Id == id);
            if (photo == null)
            {
                return NotFound();
            }
            return photo;
        }

        // POST: 
        [HttpPost]
        public IActionResult CreatePhoto([FromBody] Photo photo)
        {
            if (photo == null)
            {
                return BadRequest();
            }

            photo.Id = GeneratePhotoId();
            _photos.Add(photo);

            return CreatedAtRoute("GetPhoto", new { id = photo.Id }, photo);
        }

        // PUT: 
        [HttpPut("{id}")]
        public IActionResult UpdatePhoto(int id, [FromBody] Photo updatedPhoto)
        {
            var existingPhoto = _photos.FirstOrDefault(p => p.Id == id);
            if (existingPhoto == null)
            {
                return NotFound();
            }

            existingPhoto.Title = updatedPhoto.Title;
            existingPhoto.Description = updatedPhoto.Description;

            return NoContent();
        }

        // DELETE: 
        [HttpDelete("{id}")]
        public IActionResult DeletePhoto(int id)
        {
            var photo = _photos.FirstOrDefault(p => p.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            _photos.Remove(photo);

            return NoContent();
        }

        private int GeneratePhotoId()
        {
            return _photos.Count + 1;
        }
    }
}
