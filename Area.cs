using System;
using System.Collections.Generic;

class Area 
{
    private string historia;
    public Area n;
    public Area s;
    public Area l;
    public Area o;
    private bool fim;
    public Area(string historia, bool fim = false)
    {
        this.historia = historia;
        this.fim = fim;
    }

    public void norte(Area area2)
    {
        this.n = area2;
        area2.s = this;
    }
    public void sul(Area area2)
    {
        this.s = area2;
        area2.n = this;
    }
    public void leste(Area area2)
    {
        this.l = area2;
        area2.o = this;
    }
    public void oeste(Area area2)
    {
        this.o = area2;
        area2.l = this;
    }

    public void ImprimeHistoria()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(historia);
        Console.ResetColor();
        if (fim)
            System.Environment.Exit(0);
    }

    public void ImprimeSaidas()
    {
        Console.Write("Saídas: ");
        if (n != null) Console.Write("n ");
        if (s != null) Console.Write("s ");
        if (l != null) Console.Write("l ");
        if (o != null) Console.Write("o");
        Console.WriteLine();
    }

    public void PegarSaida(String saida)
    {
        var saidaEscolhida = new Dictionary<string, Area>();
        saidaEscolhida.Add("n", n);
        saidaEscolhida.Add("s", s);
        saidaEscolhida.Add("l", l);
        saidaEscolhida.Add("o", o);
        if (saidaEscolhida.ContainsKey(saida) && saidaEscolhida != null) {
            Mapa.posicao = saidaEscolhida[saida];
            return;
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Essa saída não existe!");
        Console.ResetColor();
    }
}