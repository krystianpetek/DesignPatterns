using System;

namespace cwiczeniaExtra;

class Program
{
    static void Main(string[] args)
    {
        int x;
        int[] tabX = new int[15];
        x = new int();
        tabX[6] = 5;
        Console.WriteLine(1354392131503453092);
        wypiszFor();
        wypiszWhile();
        wypiszDoWhile();
        Animal animal = new Animal();
        hello();
        Console.WriteLine(toDisplay());
        Console.WriteLine(dodawanie(4, 3));
        int[] tablica = new int[10];
        for (int liczba = 0; liczba < tablica.Length; liczba++)
        {
            tablica[liczba] = new Random().Next(0, 50);
        }
        Console.WriteLine(minimum(tablica));

        string[] tablicaStringow = new string[] { "Aa", "CaD", "bB" , "b"};
        int index = 0;
        string toFind = "Aa";
        Console.WriteLine(tabStringow(tablicaStringow, toFind, index));
    }
    public static void wypiszFor()
    {
        Console.WriteLine("for");
        for(int i = 0; i < 15; i++)
        Console.WriteLine("hello world");
    }
    public static void wypiszWhile()
    {
        int i = 0;
        Console.WriteLine("while");
        while (i < 15)
        {
            Console.WriteLine("hello world");
            i++;
        }
    }
    public static void wypiszDoWhile()
    {
        int i = 0;
        Console.WriteLine("dowhile");
        do
        {
            Console.WriteLine("hello world");
            i++;
        } while (i < 15);
    }
    public static void hello()
    {
        Console.WriteLine("hello from function");
    }
    public static string toDisplay()
    {
        return "toDisplay";
    }
    public static int dodawanie(int a,int b)
    {
        return a + b;
    }
    public static int minimum(int[] tablica)
    {
        int temp = tablica[0];
        foreach (var x in tablica)
        {
            if (temp >= x)
                temp = x;
        }
        return temp;
    }
    public static bool tabStringow(string[] tablica, string toFind, int index)
    {
        if (tablica[index] != toFind)
            throw new ArgumentException("błąd");

        else
            return true;
    }
}
public class Animal
{
    
}


//Zadeklaruj zmienną typu integer
//Zadeklaruj tablicę 15 elementów typu integer
//Zainicjalizuj zmienną z pierwszego punktu
//Wykonaj instrukcję przypisania wartości 5 do siódmego z kolei elementu tablicy z drugiego punktu
//Wywołaj funkcję Console.WriteLine dla dowolnego argumentu typu long
//Stwórz funkcję, która wypiszę w konsoli 'hello world' 15 razy (for)
//Stwórz funkcję, która wypiszę w konsoli 'hello world' 15 razy (while)
//Stwórz funkcję, która wypiszę w konsoli 'hello world' 15 razy (while)
//Stwórz klasę Animal i jej instancję (obiekt)
//Stwórz metodę wypisującą 'hello from function'
//Stwórz metodę wypisującą wartość argumentu 'toDisplay'
//Stwórz metodę przyjmująca dwie wartości typu int i zwracającą wynik ich dodawania
//Stwórz metodę przyjmującą tablicę elementów typu integer i zwracająca najmniejszy element tablicy
//Stwórz metodę przyjmującą tablicę elementów typu string, argument o nazwie 'toFind' i index tablicy, pod którym znajduje się szukana wartość. Jeśli wartość nie istnieje w tablicy, wyrzucamy wyjątek