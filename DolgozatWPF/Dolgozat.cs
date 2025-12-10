using System;

public class Dolgozat
{
    public string Nev { get; set; }
    public int Eletkor { get; set; }
    public int Pontszam { get; set; }

    public int EredmenyJegy()
    {
        if (Pontszam >= 80) return 5;
        if (Pontszam >= 60) return 4;
        if (Pontszam >= 40) return 3;
        if (Pontszam >= 20) return 2;
        return 1;
    }

    public override string ToString()
    {
        return $"{Nev};{Eletkor};{Pontszam}";
    }
}
