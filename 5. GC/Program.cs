Example2 example2 = new Example2();

for (int a = 0; a < 20000; a++)
{
    if(a%1000==0)
        GC.Collect();

    Example example = new Example();
}

example2.GetHashCode();


class Example
{
    public Example()
    {
        Array.Fill<byte>(data, 0x0A);
    }
    byte[] data = new byte[1000];
}

class Example2
{
    public Example2()
    {
        Array.Fill<byte>(data, 0x0A);
    }
    byte[] data = new byte[1000];
}