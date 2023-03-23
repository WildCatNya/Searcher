using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Searcher.Models;

public class Teacher
{
    public string Fio { get; }
    public string Login { get; }
    public string Password { get; }

    static Teacher() => Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

    public Teacher(string fio, string login, string password)
    {
        Fio = fio;
        Login = login;
        Password = password;
    }

    public bool Contains(string searcher)
    {
        searcher = searcher.ToLower();
        return Fio.ToLower().Contains(searcher) ||
            Login.ToLower().Contains(searcher);
    }

    public static IEnumerable<Teacher> GetTeachers()
    {
        string filePath = File.ReadAllLines("Path.txt")[1];
        FileStream fileStream = File.OpenRead(filePath);
        using (StreamReader reader = new(fileStream, Encoding.GetEncoding(1251)))
        {
            while (!reader.EndOfStream)
            {
                string[] splits = reader.ReadLine().Split(';');
                yield return new(splits[0], splits[1], splits[2]);
            }
        }
        fileStream.Close();
    }
}