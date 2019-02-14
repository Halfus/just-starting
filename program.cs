class Program
{
    static void Main(string[] args)
    {
        unsafe {
            Console.WriteLine("Testing starts:");

            int[] b = new int[5] { 10, 20, 30, 40, 50 };
            int* a;
            int c = 1;
            int* d = &c;
            int** e = &d;
            int f = **e;

            a = &c;
            Console.WriteLine("0x{0:x}", (ulong)&a);
            Console.WriteLine("a = {0}", *a);
            *a = *a + 1;
            Console.WriteLine("a = {0}", *a);
            a += 1;

            Console.WriteLine("c = {0:G}", c);
            Console.WriteLine("a = {0}", *a);

            Console.WriteLine("0x[0:x]", (ulong)&a);
            Console.WriteLine("Done testing!");

            // Must pin object on heap so that it doesn't move while using interior pointers.
            fixed (int* p = &b[0])
            {
                // p is pinned as well as object, so create another pointer to show incrementing it.
                int* p2 = p;
                Console.WriteLine(*p2);
                // Incrementing p2 bumps the pointer by four bytes due to its type ...
                p2 += 1;
                Console.WriteLine(*p2);
                p2 += 1;
                Console.WriteLine(*p2);
                Console.WriteLine("--------");
                Console.WriteLine(*p);
                // Dereferencing p and incrementing changes the value of a[0] ...
                *p += 1;
                Console.WriteLine(*p);
                *p += 1;
                Console.WriteLine(*p);
                Console.ReadLine();
            }
        }
    }
}