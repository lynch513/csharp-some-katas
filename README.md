## О проекте

Набор типичных решений и просто кода из учебных курсов, из собеседований и прочее. В общем склад того о чем могут спросить и можно будет дать ссылку �

## Оглавление

### [Проверка числа на наличие двух рядом стоящих цифр](https://github.com/lynch513/csharp-some-katas/blob/master/CheckNumberForAdjacentDigits.csx)

Ничего сложного если помнить про целочисленное деление и остаток о деления.

### [Подсчет количества чисел содержащих две рядом стоящие цифры из заданного диапазона](https://github.com/lynch513/csharp-some-katas/blob/master/AdjancentDigitsRangeCounter.csx)

Не забудьте про аналитическое решение и про комбинаторику в частности. Например для расчета числа для диапазона от 0 до 999999:

```math
S(6) = 9^6 + 9^5 + 9^4 + 9^3 + 9^2 +9^1 + 9^0 = (9^7–1)/8 = 597 871 
```

Но конечно программист просто переберет значения и все.

### [FizzBuzz на F#](https://github.com/lynch513/FizzBuzz/blob/master/Program.fs)

Пример того до чего можно себя довести, если слишком увлечься. Ветка **starting** - FizzBuzz здорового человека, если вдруг он решит сделать это на F# и далее до того, что получилось в **master**.

## Установка

Необходима установка dotnet для вашей платформы. Желательно .NET 5.0:

[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

Так как код представляет собой набор скриптов на C#, необходим dotnet-script:

```bash
$ dotnet tool install -g dotnet-script
```

Клонируем репозитарии [https://github.com/lynch513/csharp-some-katas.git](https://github.com/lynch513/csharp-some-katas.git) локально:

```bash
$ git clone https://github.com/lynch513/csharp-some-katas.git
```

Далее запускаем скрипт:

```bash
$ dotnet script somefile.csx
```

Если у вас VS Code то можно установить поддержку из текущей директории проекта:

```bash
$ dotnet-script init
```

После у вас станет доступен запуск из VS Code и дебаггер C# и прочee:

```bash
$ code somefile.csx
```

Если есть замечания и исправления, пожалуйста пишите

