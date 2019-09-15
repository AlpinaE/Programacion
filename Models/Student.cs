using System;
using System.ComponentModel.DataAnnotations;

namespace programacion.models
{
    public class Student{

        public int ID{get;set;}

        public String Name{get;set;}

        [DataType(DataType.Date)]
        public DateTime Birth {get; set;}

        public int Age{ get;set;}

        public String Hobbie{get;set;}

        public String Curso{get;set;}

        public int Credito{get;set;}

        public double Total { get { return Credito * 100; }}
    }
}
