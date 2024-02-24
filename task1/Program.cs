// Побочный эффект функции - когда функция ничего не возвращает? но
// имеет влияние на окружающую среду. Например, функция, которая выводит сообщение

// Метод = Функция

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double res = numenator / denomenator; // если оба int, то несмотря на то, что res - double, все равно потеряется дробная часть
    return res;
}

Console.Write(CalculateFormula(1, 2, 3, 4));