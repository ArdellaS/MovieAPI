using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class Film
    {
        /*	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[Director] [nvarchar](280) NULL,
	[Category] [nvarchar](20) NOT NULL,*/

        private int id;
        private string name;
        private int year;
        private string director;
        private string category;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Director { get => director; set => director = value; }
        public string Category { get => category; set => category = value; }
    }
}
