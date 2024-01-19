using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerForPortfolio.Data;
using ServerForPortfolio.Modals;

namespace ServerForPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologiesController : ControllerBase
    {
        
            private readonly AppDBContext _appDBContext;

            public TechnologiesController(AppDBContext appDBContext)
            {
                _appDBContext = appDBContext;
            }

            [HttpGet]

            public IActionResult GetPortfolioData()
            {
                var _data = _appDBContext.TechnologiesDatas.ToList();

                return Ok(_data);
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var _data = _appDBContext.TechnologiesDatas.FirstOrDefault(x => x.Id == id);
                return Ok(_data);
            }




            [HttpPost]

            public IActionResult AddProject(TechnologiesData data)
            {
                var _data = new TechnologiesData()
                {
                    KnownTechnologies = data.KnownTechnologies,
                    DateAdded = data.DateAdded
                };

                _appDBContext.TechnologiesDatas.Add(_data);
                _appDBContext.SaveChanges();

                return Ok(_data);
            }




            [HttpPut("{id}")]
            public IActionResult UpdatedById(int id, TechnologiesData data)
            {
                var _data = _appDBContext.TechnologiesDatas.FirstOrDefault(x => x.Id == id);

                if (_data != null)
                {
                  
                    _data.KnownTechnologies = data.KnownTechnologies;
                    _data.DateAdded = data.DateAdded;


                    _appDBContext.TechnologiesDatas.Update(_data);
                    _appDBContext.SaveChanges();
                }

                return Ok(_data);
            }






            [HttpDelete("{id}")]
            public IActionResult DeleteById(int id)
            {
                var _data = _appDBContext.TechnologiesDatas.FirstOrDefault(x => x.Id == id);
                if (_data != null)
                {
                    _appDBContext.TechnologiesDatas.Remove(_data);
                    _appDBContext.SaveChanges();
                }

                return Ok();
            }



        }


    }

