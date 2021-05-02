using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary.Entities.Enums;
using AcademyAppClassLibrary.Entities.Models;

namespace AcademyAppClassLibrary
{
    public static class MembersDB 
    {

        public static List<Student> Students { get; set; }
        public static List<Trainer> Trainers { get; set; }
        public static List<Admin> Admins { get; set; }
        public static List<Person> Members { get; set; }

        static MembersDB()
        {
            Students = new List<Student>()
            {
                new Student("Jana", "Simjanovska", "studentJana", "jana1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Nikola", "Sheskokalov", "studentIvan", "nikola1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Sanja", "Karakashova", "studentSanja", "sanja1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Ivan", "Jamandilovski", "studentIvan", "ivan1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Marta", "Spasovska", "studentMarta", "marta1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                })
            };

            Trainers = new List<Trainer>()
            {
                new Trainer("Kristina", "Spasevska", "trainerKiki", "kiki1234"),
                new Trainer("Panche", "Manaskov", "trainerPane", "pane1234")
            };

            Admins = new List<Admin>()
            {
                new Admin("Jana", "Simjanovska", "Admin", "password")
            };


            Members = new List<Person>()
            {
                new Student("Jana", "Simjanovska", "studentJana", "jana1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Nikola", "Sheskokalov", "studentIvan", "nikola1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Sanja", "Karakashova", "studentSanja", "sanja1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Ivan", "Jamandilovski", "studentIvan", "ivan1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Student("Marta", "Spasovska", "studentMarta", "marta1234", Subject.CSharp_Advanced, new Dictionary<Subject, Grade>()
                {
                    { Subject.Web_Development_Intro, Grade.A },
                    { Subject.HTML5_CSS3, Grade.A },
                    { Subject.JS_Basic, Grade.A },
                    { Subject.JS_Advanced, Grade.C },
                    { Subject.CSharp_Basic, Grade.A }
                }),

                new Trainer("Kristina", "Spasevska", "trainerKiki", "kiki1234"),
                new Trainer("Panche", "Manaskov", "trainerPane", "pane1234"),

                new Admin("Jana", "Simjanovska", "Admin", "password")
            };
        }
    }


}
