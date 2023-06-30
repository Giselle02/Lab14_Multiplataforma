using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO14C.Views
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Credit { get; set; }
        public DateTime StartDate { get; set; }
    }

    // Lógica de inserción
    public async Task InsertCourse(string name, string description, decimal credit, DateTime startDate)
    {
        var course = new Course
        {
            Name = name,
            Description = description,
            Credit = credit,
            StartDate = startDate
        };

        // Conexión a la base de datos SQLite
        using (SqliteConnection connection = new SqliteConnection(App.DatabasePath))
        {
            connection.CreateTable<Course>();
            connection.Insert(course);
        }
    }

}
