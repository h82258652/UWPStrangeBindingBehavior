using GalaSoft.MvvmLight;
using System.Collections.Generic;
using UWPStrangeBindingBehavior.Models;

namespace UWPStrangeBindingBehavior.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Classes = new Dictionary<string, IEnumerable<Student>>()
            {
                ["Class A"] = new[]
                {
                    new Student()
                    {
                        Name = "Tom"
                    },
                    new Student()
                    {
                        Name = "Lucy"
                    }
                },
                ["Class B"] = new[]
                {
                    new Student()
                    {
                        Name = "Mary"
                    },
                    new Student()
                    {
                        Name = "Jack"
                    },
                },
                ["South Park"] = new[]
                {
                    new Student()
                    {
                        Name = "Stan Marsh"
                    },
                    new Student()
                    {
                        Name = "Kyle Broflovski"
                    },
                    new Student()
                    {
                        Name = "Eric Theodore Cartman"
                    },
                    new Student()
                    {
                        Name = "Kenny McCormick"
                    },
                }
            };
        }

        public IReadOnlyDictionary<string, IEnumerable<Student>> Classes
        {
            get;
        }
    }
}