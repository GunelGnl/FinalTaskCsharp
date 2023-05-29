//Task 64
Console.WriteLine("Add digit n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Add digit m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"n={n}, m={m}");
if (m>n)
for (int i = n; i <= m; i++)
    Console.WriteLine($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.WriteLine($" {i}");
        
        Console.ReadLine();




//Task 66 

 Console.WriteLine("Add digit n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Add digit m: ");
        int m = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"n={n}, m={m}");
        
        int sum = 0;
        
        if (m > n)
        {
            for (int i = n; i <= m; i++)
            {
                sum += i;
            }
        }
        else
        {
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
        }
        
        Console.WriteLine($"Sum of digits: {sum}");
        Console.ReadLine();
    

