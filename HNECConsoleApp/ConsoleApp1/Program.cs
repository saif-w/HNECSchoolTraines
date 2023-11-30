//// See https://aka.ms/new-console-template for more information
//using ConsoleApp1;
//using ConsoleApp1.Entity;

//Console.WriteLine("Hello, World!");

//Studints studints = new Studints();

////studints.Id = 1;
//studints.FirstName = "Saif allh";
//studints.LastName = "Walid";
//studints.EnrollmentDate = DateTime.Now;

//operation.AddStudints(studints);

////Remove Studints
////
////operation.RemoveStudints(1);


////Studont update

//Studints saif = new Studints();

////studints.Id = 1;
//saif.FirstName = "Saif";
//saif.LastName = "Walid";
//saif.EnrollmentDate = DateTime.Now;

//operation.UpdateStudints(1, saif);

using ConsoleApp1.Entity;
using Microsoft.EntityFrameworkCore;

using (HNECDBContext db = new HNECDBContext())
{

    #region التدريب الثاني
    //var std = db.Studints
    //    .Select(st => new { st.FirstName, st.LastName })
    //    .Where(a => a.FirstName.Contains("ll"));

    //var enr = db.Enrollaments
    //    .Include(a => a.Studints)
    //    .Include(a=>a.Courses);


    //var EnrStd = db.Enrollaments
    //    .Include(a => a.Studints)
    //    .Where(a => a.Studints.EnrollmentDate.Day > 25
    //    && a.Studints.EnrollmentDate.Month == 11); 
    #endregion

    //Eager Fetching
    var ListStudints = db.Studints
        .Include(a => a.Enrollament)
        .ThenInclude(a => a.Courses)
        .SelectMany(a=>a.Enrollament
        .Select(b => new {b.Grade,b.Courses.Titel,a.FirstName }))
        .ToList();
      
    
    foreach (var s in ListStudints)
        {
            Console.WriteLine(s?.FirstName??"");
            Console.WriteLine("=>"+s.Grade);
            Console.WriteLine("=>=>"+s?.Titel??"");
        }


}




