using System.Runtime.InteropServices;

int[] a = new int[5] { 0x10, 0x20, 0x30, 0x40, 0x50 };

// Pin the array in memory using GCHandle
GCHandle handle = GCHandle.Alloc(a, GCHandleType.Pinned);

try
{
    // Get the pointer to the array
    IntPtr pointer = handle.AddrOfPinnedObject();
    Console.WriteLine("Array pinned at memory location: " + pointer);

    // Access elements using pointer (optional)
    unsafe
    {
        byte* p = (byte*)pointer.ToPointer();
        for (byte i = 0; i < 20; i++)
        {
            Console.WriteLine("Element {0}: {1}", i, *(p + i));
        }
    }
}
finally
{
    // Free the pinned handle to avoid memory leaks
    handle.Free();
}
