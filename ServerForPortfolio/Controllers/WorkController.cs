using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerForPortfolio.Data;
using ServerForPortfolio.Modals;

namespace ServerForPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {

        private readonly AppDBContext _appDBContext;

        public WorkController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet]

        public IActionResult GetPortfolioData()
        {
            var _data = _appDBContext.WorkDatas.ToList();

            return Ok(_data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var _data = _appDBContext.WorkDatas.FirstOrDefault(x => x.Id == id);
            return Ok(_data);
        }




        [HttpPost]

        public IActionResult AddProject(WorkData data)
        {
            var _data = new WorkData()
            {
              
                WorkImageURL = data.WorkImageURL,
                WorkDate = data.WorkDate,
                WorkTitle = data.WorkTitle,
                WorkName = data.WorkName,
                WorkDescription = data.WorkDescription,
                DateAdded = data.DateAdded
            };

            _appDBContext.WorkDatas.Add(_data);
            _appDBContext.SaveChanges();

            return Ok(_data);
        }


        

        [HttpPut("{id}")]
        public IActionResult UpdatedById(int id, WorkData data)
        {
            var _data = _appDBContext.WorkDatas.FirstOrDefault(x => x.Id == id);

            if (_data != null)
            {
               
                _data.WorkImageURL = data.WorkImageURL;
                _data.WorkDate = data.WorkDate;
                _data.WorkTitle = data.WorkTitle;
                _data.WorkName = data.WorkName;
                _data.WorkDescription = data.WorkDescription;
               
                _data.DateAdded = data.DateAdded;

                _appDBContext.WorkDatas.Update(_data);
                _appDBContext.SaveChanges();
            }

            return Ok(_data);
        }






        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var _data = _appDBContext.WorkDatas.FirstOrDefault(x => x.Id == id);
            if (_data != null)
            {
                _appDBContext.WorkDatas.Remove(_data);
                _appDBContext.SaveChanges();
            }

            return Ok();
        }



    }



}

