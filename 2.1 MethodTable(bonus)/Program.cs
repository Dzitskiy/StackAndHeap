using System.Reflection;

Example example = new Example();

Type t = example.GetType();
RuntimeTypeHandle h = t.TypeHandle;

example.Return0();

class Example
{
    public int Return0()
    { 
        return 0;
    }
}