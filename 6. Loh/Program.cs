Example example = new Example();

Example example2 = new Example();

//ссылка убивается и корень будет удален, но байты сохранятся
example = null;

//после принудительной сборки мусора объект также будет на месте
GC.Collect();
;

Example example3 = new Example();
class Example
{
    public Example()
    {
        Array.Fill<byte>(data, 0x11);
    }
    byte[] data = new byte[85000];
}