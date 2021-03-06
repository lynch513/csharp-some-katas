## О проекте

Набор типичных решений и просто кода из учебных курсов, из собеседований и прочее. В общем склад того о чем могут спросить и можно будет дать ссылку 😉

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

Пример того до чего можно себя довести, если слишком увлечься. Ветка **starting** - FizzBuzz здорового человека (если конечно он решит сделать это на F#) и далее до того, что получилось в **master**.

### FizzBuzz на C#

1. [Императивная классика](https://github.com/lynch513/csharp-some-katas/blob/master/FizzBuzzClassic.csx)
2. [Сопоставление шаблона. Вариант 1](https://github.com/lynch513/csharp-some-katas/blob/master/FizzBuzzPatternMatching1.csx)
3. [Сопоставление шаблона. Вариант 2](https://github.com/lynch513/csharp-some-katas/blob/master/FizzBuzzPatternMatching2.csx)
4. [Сопоставление шаблона. Вариант 3](https://github.com/lynch513/csharp-some-katas/blob/master/FizzBuzzPatternMatching3.csx)
4. [Сопоставление шаблона, без использования циклов](https://github.com/lynch513/csharp-some-katas/blob/master/FizzBuzzPatternMatchingWithoutLoop.csx)

### [Подсчет частоты слов на F#](https://github.com/lynch513/WordFrequency)

Если вдруг захотелось подсчитать частоту встречающихся в тексте слов. Но при этом вы не ищете легких путей)))

### Подсчет количества чисел делящихся на 2, на 3 и на 5 в заданном диапазоне

1. [Перебор с помощью цикла](https://github.com/lynch513/csharp-some-katas/blob/master/DivisionRemainderCounterClassic.csx)
2. [Перебор с одну строку на Enumerable.Range](https://github.com/lynch513/csharp-some-katas/blob/master/DivisionRemainderCounterRange.csx)
3. [Аналитически с помощью формулы включений-исключений для трех множеств](https://github.com/lynch513/csharp-some-katas/blob/master/DivisionRemainderCounterAnalytical.csx)

```math
|A'∩B'∩C'| = |X| - |A| - |B| - |C| + |A∩B| + |B∩C| + |A∩C| - |A∩B∩C|
```

4. [Замеры производительности](https://github.com/lynch513/csharp-some-katas/blob/master/DivisionRemainderCounterDiagnostic.csx)

В диапазоне меньше ста, аналитика оказывается медленнее перебора циклом. В диапазоне тысяч, аналитика вырывается вперед. Перебор на Enumerable.Range всегда самый медленный. Про то, что можно уменьшить количество умножений и заменить деление на сдвиги я знаю, C# это все-таки больше про читаемость кода.

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

