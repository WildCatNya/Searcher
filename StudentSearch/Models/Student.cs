using Searcher.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Searcher.Models;

public class Student
{
    public string Fio { get; }
    public string Shifr { get; }
    public string ShifrTranslit { get; }
    public string Spec { get; }
    public string Password { get; }
    public string Kurs { get; }
    public string FObuch { get; }
    public Student(string fio, string shifr, string spec, string password, string kurs, string fObuch)
    {
        Fio = fio;
        Shifr = shifr;
        ShifrTranslit = new StudentShifrTranslitter(shifr).Translit();
        Spec = spec;
        Password = password;
        Kurs = kurs;
        FObuch = fObuch;
    }
    public bool Contains(string searcher)
    {
        searcher = searcher.ToLower();
        return Fio.ToLower().Contains(searcher) ||
            Shifr.ToLower().Contains(searcher) ||
            ShifrTranslit.ToLower().Contains(searcher);
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