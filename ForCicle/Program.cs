
// los ciclos for se componen por una varible, una condicion y la candtiafda de  repeticiones

for (int i = 0/*condicion inicial*/; i < 50/*limite de repeticiones*/; i= i+10/*incremento*/) 
{
    Console.WriteLine("hello world #{0}", i);
}



for (int a= 0; a <= 50; a++)
{
    int residuo = (a % 2);
    if(residuo == 0)
    {
        string mensaje = " es par";
        Console.WriteLine("el numero "+a+ mensaje);
    }
    else
    {
        string mensaje = " es impar";
        Console.WriteLine("el numero " + a + mensaje);
    }   
}
for (int i = 0, j = 0; i < 10 && j > -10; i++, j--)
{
    Console.WriteLine("i: " + i + " j: " + j);
}
