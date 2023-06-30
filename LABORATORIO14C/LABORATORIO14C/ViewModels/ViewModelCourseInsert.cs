using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LABORATORIO14C.ViewModels
{
    internal class ViewModelCourseInsert : BaseViewModel
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }


        private Course course;

        public ViewModelCourseInsert()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }

    internal class Course
    {
    }
}