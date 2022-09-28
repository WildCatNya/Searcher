using StudentSearch.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentSearch.Models;

public class Student
{
    public string FIO{ get; }
    public string Shifr{ get; }
    public string Spec{ get; }
    public string Password{ get; }
    public string Kurs{ get; }
    public string FObuch{ get; }
    public Student(string fio, string shifr, string spec, string password, string kurs, string fObuch)
    {
        FIO = fio;
        Shifr = shifr;
        Spec = spec;
        Password = password;
        Kurs = kurs;
        FObuch = fObuch;
    }
    public string ShifrTranslit
    {
        get => new StudentShifrTranslitter(Shifr).Translit();
    }
    public static IEnumerable<Student> GetStudents()
    {
        string filePath = File.ReadAllLines("Path.txt")[0];
        FileStream fileStream = File.OpenRead(filePath);
        using (StreamReader reader = new(fileStream, Encoding.Default))
        {
            while (!reader.EndOfStream)
            {
                string[] splits = reader.ReadLine().Split(';');
                yield return new(splits[0], splits[1], splits[2], splits[8], splits[5], splits[3]);
            }
        }
        fileStream.Close();
    }
}