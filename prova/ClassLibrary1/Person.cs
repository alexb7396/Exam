﻿using System;

namespace ClassLibrary1
{
    public class Person
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int Age { get; set; }
        public Person(string name,string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
    }
}