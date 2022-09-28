using System.Text;

namespace StudentSearch.Helpers;

public class StudentShifrTranslitter
{
    private readonly string _shifr;
    public StudentShifrTranslitter(string shifr)
    {
        _shifr = shifr;
    }
    public string Translit()
    {
        StringBuilder builder = new();
        char[] symbols = _shifr.ToCharArray();
        foreach (char symbol in symbols)
        {
            switch (symbol)
            {
                case 'а':
                case 'А':
                    builder.Append('A');
                    break;
                case 'б':
                case 'Б':
                    builder.Append('B');
                    break;
                case 'в':
                case 'В':
                    builder.Append('V');
                    break;
                case 'г':
                case 'Г':
                    builder.Append('G');
                    break;
                case 'д':
                case 'Д':
                    builder.Append('D');
                    break;
                case 'е':
                case 'Е':
                    builder.Append('E');
                    break;
                case 'ж':
                case 'Ж':
                    builder.Append('J');
                    break;
                case 'з':
                case 'З':
                    builder.Append('Z');
                    break;
                case 'и':
                case 'И':
                    builder.Append('I');
                    break;
                case 'й':
                case 'Й':
                    builder.Append('I');
                    break;
                case 'к':
                case 'К':
                    builder.Append('K');
                    break;
                case 'л':
                case 'Л':
                    builder.Append('L');
                    break;
                case 'м':
                case 'М':
                    builder.Append('M');
                    break;
                case 'н':
                case 'Н':
                    builder.Append('N');
                    break;
                case 'о':
                case 'О':
                    builder.Append('O');
                    break;
                case 'п':
                case 'П':
                    builder.Append('P');
                    break;
                case 'р':
                case 'Р':
                    builder.Append('R');
                    break;
                case 'с':
                case 'С':
                    builder.Append('S');
                    break;
                case 'т':
                case 'Т':
                    builder.Append('T');
                    break;
                case 'у':
                case 'У':
                    builder.Append('U');
                    break;
                case 'ф':
                case 'Ф':
                    builder.Append('F');
                    break;
                case 'х':
                case 'Х':
                    builder.Append('H');
                    break;
                case 'э':
                case 'Э':
                    builder.Append('E');
                    break;
                case 'ю':
                case 'Ю':
                    builder.Append('Y');
                    break;
                case '-':
                    builder.Append("");
                    break;
                default:
                    builder.Append(symbol);
                    break;
            }
        }
        return builder.ToString();
    }
}
