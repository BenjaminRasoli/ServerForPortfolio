//using ServerForPortfolio.Modals;
//using System.Diagnostics.Eventing.Reader;

//namespace ServerForPortfolio.Data
//{
//    public class SeedingData
//    {
//        public static void Seed (IApplicationBuilder appBuilder)
//        {
//            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
//            {
//                var dBContext = serviceScope.ServiceProvider.GetService<AppDBContext>();

//                if (!dBContext.ProjectDatas.Any())
//                {
//                    dBContext.AddRange(new ProjectData
//                    {
//                        ProjectName = "Test",
                      

//                    },

//                    new ProjectData
//                    {
//                        ProjectName = "Test2",

//                    }








//                    );


//                    dBContext.SaveChanges();
//                }
//            }
//        }
//    }
//}
