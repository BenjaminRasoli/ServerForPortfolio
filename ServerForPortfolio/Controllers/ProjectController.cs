using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerForPortfolio.Data;
using ServerForPortfolio.Modals;

namespace ServerForPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;

        public ProjectController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet]

        public  IActionResult GetPortfolioData()
        {
            var _data = _appDBContext.ProjectDatas.ToList();

            return Ok(_data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var _data = _appDBContext.ProjectDatas.FirstOrDefault(x => x.Id == id);
            return Ok(_data);
        }




        [HttpPost]

        public IActionResult AddProject(ProjectData data)
        {
            var _data = new ProjectData()
            {
                ProjectName = data.ProjectName,
                ProjectTechnologies = data.ProjectTechnologies,
                ProjectImageURL = data.ProjectImageURL,             
                DateAdded = data.DateAdded
            };

            _appDBContext.ProjectDatas.Add(_data);
            _appDBContext.SaveChanges();

            return Ok(_data);
        }




        [HttpPut("{id}")] 
        public IActionResult UpdatedById(int id, ProjectData data)
        {
            var _data = _appDBContext.ProjectDatas.FirstOrDefault(x => x.Id == id);

            if (_data != null)
            {
                _data.ProjectName = data.ProjectName;
                _data.ProjectTechnologies = data.ProjectTechnologies;
                _data.ProjectImageURL = data.ProjectImageURL;            
                _data.DateAdded = data.DateAdded;

                _appDBContext.ProjectDatas.Update(_data);
                _appDBContext.SaveChanges();
            }

            return Ok(_data);
        }






        [HttpDelete("{id}")] 
        public IActionResult DeleteById(int id)
        {
            var _data = _appDBContext.ProjectDatas.FirstOrDefault(x => x.Id == id);
            if (_data != null)
            {
                _appDBContext.ProjectDatas.Remove(_data);
                _appDBContext.SaveChanges();
            }

            return Ok();
        }

       

    }
}
