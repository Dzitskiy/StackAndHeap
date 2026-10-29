Example example = new Example();
example.a = 0x22222222;
example.b = 0x11111111;

/*Example example2 = new Example();
example2.a = 0x44444444;
example2.b = 0x33333333;

Example example3 = new Example();
example3.a = 0x55555555;
example3.b = 0x66666666;*/

lock (example)
{
    example.Show();
}
;

class Example
{
    public int a;
    public int b;

    public void Show()
    { }
}