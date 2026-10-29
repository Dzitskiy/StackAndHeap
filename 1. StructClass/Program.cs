Point point = new Point();

Change(point);

//Результат различен для ссылочных и значимых типов
Console.WriteLine($"X = {point.x}, Y = {point.x}");
;
void Change(Point point)
{
    point.x = 10;
    point.y = 10;
}

//В случае со struct - значение копируется при переходе в метод

struct

//В случае с class - копируется ссылка и изменяется объект
/*class*/
Point
{
    public int x;
    public int y;
}