# Библиотека для win12
Скачать можно [тут](https://github.com/nnn-ssn-ru/nnn-lib/releases/tag/main).
## Использование
```cs
using System;
using System.Diagnostics;
using nnn;

namespace nnn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool started;
            started = nnn.startProcess("regedit.exe", arguments="", createWindow=true);
            //                         Путь к файлу   Аргументы     Создать окно? (false - запустить в фоне)
        }
    }
}
```
## Версия 0.0.1 Pre-release
### Добавленно
 - Запуск проложений (bool startProcess)
 - Регистрация и авторизация (class NNNAuth)
 - Путь к конфигу (string configPath)
