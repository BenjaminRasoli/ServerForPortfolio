using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServerForPortfolio.Modals
{
    public class ProjectData
    {

        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTechnologies { get; set; }
        public string ProjectImageURL { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
