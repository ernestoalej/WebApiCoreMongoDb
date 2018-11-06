using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApiCoreMongoDb.Models;

namespace WebApiCoreMongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private Context db;


        public PostController()
        {
            db = new Context();
        }

        // GET: api/Post
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var posts = db.Posts.Find(_ => true).ToList();
            return posts;
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Post> Get(string id)
        {
            var posts = db.Posts.Find(p => p.Id==id).ToList();
            return posts;
        }

        // POST: api/Post
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            db.Posts.InsertOne(post);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
