class FileSystem
{
    public static string[] _fileextensions = { };
    public static string[] _languages = { "English", "Rusian", "Turkish" };
    public static int _languagemanager = 0;
    public static string[,] _languagetexts = { { "File types :" }, { "Типы файлов :" }, { "Dosya türleri :" } };

    public string _file = "";



    public void AddFileTypes(params string[] array)
    {
        _fileextensions = array;

    }
    public void AddFile(string file)
    {
        int point = 0;
        string extension = "";
        for (int i = 0; i < file.Length; i++)
        {
            if (file[i] == '.')
            {
                point = i;
                break;

            }
        }

        for (int i = point; i < file.Length; i++)
        {
            extension += file[i];
        }
        foreach (string addedextension in _fileextensions)
        {
            if (addedextension == extension)
            {
                _file = file;


            }

        }

    }
    public static void ShowFileTypes()
    {
        Console.WriteLine(_languagetexts[_languagemanager, 0]);
        foreach (string addedextension in _fileextensions)
        {
            Console.WriteLine(addedextension);
        }
    }
    public static void ChangeLanguage()
    {
        for (int i = 0; i < _languages.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{_languages[i]}");
        }
        _languagemanager = Convert.ToInt32(Console.ReadLine()) - 1;
    }


}

