# C#_Lab1

# Лабораторная работа №1
## «Типы данных, классы»

# Цели работы:
## Научиться работать с переменными разных типов данных CTS средствами языка C#.
## Научиться создавать классы и поля классов, инициализировать свойства классов. Научиться создавать перегруженные конструкторы классов.
## Научиться создавать тесты для реализованных методов и классов.

# Задание№1
```sh
Выведите на консоль минимальные и максимальные значения для предопределенных типов данных CTS.
```
# Задание№2
```sh
Создайте класс с именем Rectangle.
В теле класса создайте два поля, описывающие длины сторон double side1, side2.
Создайте пользовательский конструктор Rectangle(double sideA, double sideB), в теле которого поля sideA и sideB инициализируются значениями аргументов.
Создайте два private метода, вычисляющие площадь прямоугольника - double CalculateArea() и периметр прямоугольника - double CalculatePerimeter ().
Создайте два свойства double Area и double Perimeter с одним методом доступа get, вызывающим созданные ранее методы.
Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle.
```
# Задание №3
```sh
Создайте классы Point и Figure.
Класс Point должен содержать два целочисленных поля с координатами точки.
Создайте два свойства с одним методом доступа get.
Создайте пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point, а также строковое автосвойство для хранения названия фигуры.
Создайте два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; double PerimeterCalculator(), который рассчитывает периметр многоугольника.
Напишите программу, которая выводит на экран название и периметр многоугольника. Покройте тестами методы класса Figure.

Примечание: Избегайте повторения кода при реализации перегруженных конструкторов, используйте реализованные ранее конструкторы с помощью ключевого слова this, например, так:
```



<img width="387" alt="image" src="https://github.com/3Artem99/C-Lab1/assets/113392103/2914a34d-01e3-4981-9215-706357cb3cff">

