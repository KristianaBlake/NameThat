using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NameThat.Models;

namespace NameThat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly ResultContext _context;

        public ResultController(ResultContext context)
        {
            _context = context;
        }

        // GET: api/Result
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Result>>> GetResult()
        {
            return await _context.Result.ToListAsync();
        }

        // GET: api/Result/title
        [HttpGet("{title}")]
        public async Task<ActionResult<Title>> GetResult(title)
        {
            var userInput = title.ToString();

            if (userInput == null || userInput.Length == 0)
            {
                return NotFound();
            } else {
                string searchUrl = $"http://www.omdbapi.com/?t=" + userInput + "&apikey=942af2e";

                try{
                    
                    using (WebClient wc = new WebClient())
                    {
                        try{
                            string json = wc.DownloadString(searchUrl);
                            JavaScriptSerializer oJS = new JavaScriptSerializer();
                            Result obj - new Result();
                            obj = oJS. Deserialize<OmdbAPI>(json);
                            if (obj.Response == "True")
                            {
                                OmdbAPI.Title == obj.Title;
                                OmdbAPI.Type == obj.Type;
                                OmdbAPI.Picture == obj.Picture;
                                OmdbAPI.YearOfRelease == obj.YearOfRelease
                            }
                        }
                    }
                }
            }


            return result;
        }

        // PUT: api/Result/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResult(int id, Result result)
        {
            if (id != result.ID)
            {
                return BadRequest();
            }

            _context.Entry(result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Result
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Result>> PostResult(Result result)
        {
            _context.Result.Add(result);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetResult), new { id = result.ID }, result);
        }

        // DELETE: api/Result/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResult(int id)
        {
            var result = await _context.Result.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            _context.Result.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResultExists(int id)
        {
            return _context.Result.Any(e => e.ID == id);
        }
    }
}
