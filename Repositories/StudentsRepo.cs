using System.Collections.Generic;
using Models;

namespace Repositories
{
    public static class StudentsRepo
    {
        public static List<Student> StudentsList = new List<Student>(){
            new Student(){ ID = "LO611321", Name = "Jimmy", Faculty = "AC", Year = 4},
            new Student(){ ID = "LO612421", Name = "Mihai", Faculty = "AC", Year = 2},
            new Student(){ ID = "LO612456", Name = "Vasile", Faculty = "AC", Year = 4},
            new Student(){ ID = "LO612567", Name = "Alex", Faculty = "AC", Year = 3},
            new Student(){ ID = "LO613412", Name = "George", Faculty = "AC", Year = 1},
            new Student(){ ID = "LO613534", Name = "Gigel", Faculty = "AC", Year = 1}
        };
    }
}