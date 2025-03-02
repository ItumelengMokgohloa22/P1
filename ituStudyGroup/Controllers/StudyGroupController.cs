using ituStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ituStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {

            List<StudyGroup> studentdetails = new List<StudyGroup>
            {
                new StudyGroup
                {
                   StudentNumber = "u21532398",
                   Name = "Itumeleng",
                   Surname = "Mokgohloa",
                   EmailAddress = "u21532398@tuks.co.za"

                },
                 new StudyGroup
                {
                   StudentNumber = "u22730797",
                   Name = "Lereko",
                   Surname = "Thokoa",
                   EmailAddress = "u22730797@tuks.co.za"

                },
                  new StudyGroup
                {
                   StudentNumber = "u23580142",
                   Name = "Lance",
                   Surname = "Nel",
                   EmailAddress = "u23580142@tuks.co.za"

                },
                   new StudyGroup
                {
                   StudentNumber = "u24632059",
                   Name = "Alex",
                   Surname = "Graham",
                   EmailAddress = "u24632059@tuks.co.za"

                },
                    new StudyGroup
                {
                   StudentNumber = "u23587386",
                   Name = "Herold",
                   Surname = "Mokwena",
                   EmailAddress = "u22587386.co.za"

                },

            };
            return View(studentdetails);
        }
    }
}