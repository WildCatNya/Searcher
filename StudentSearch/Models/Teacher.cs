using System.IO;

namespace Searcher.Models;

public class Teacher
{
    public string Fio { get; }
    public string Login { get; }
    public string Password { get; }
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
    public static void GetTeachers()
    {
        throw new System.NotImplementedException();
    }
}