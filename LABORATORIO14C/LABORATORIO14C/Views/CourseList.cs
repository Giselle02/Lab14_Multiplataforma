using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LABORATORIO14C.Views
{
    public class CourseListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Course> courses;
        private string searchQuery;

        public ObservableCollection<Course> Courses
        {
            get { return courses; }
            set
            {
                courses = value;
                OnPropertyChanged(nameof(Courses));
            }
        }

        public string SearchQuery
        {
            get { return searchQuery; }
            set
            {
                searchQuery = value;
                FilterCourses();
                OnPropertyChanged(nameof(SearchQuery));
            }
        }

        public Command FilterCommand { get; }

        public CourseListViewModel()
        {
            Courses = new ObservableCollection<Course>();
            FilterCommand = new Command(FilterCourses);
            LoadCourses();
        }

        private void LoadCourses()
        {
            // Conexión a la base de datos SQLite
            using (SqliteConnection connection = new SqliteConnection(App.DatabasePath))
            {
                Courses = new ObservableCollection<Course>(connection.Table<Course>().ToList());
            }
        }

        private void FilterCourses()
        {
            // Filtrar los cursos según la consulta de búsqueda
            var filteredCourses = Courses.Where(course =>
                course.Name.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase) ||
                course.Description.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Courses = new ObservableCollection<Course>(filteredCourses);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
