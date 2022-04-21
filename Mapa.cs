using System;

class Mapa
{
    public static Area posicao;

    public Mapa() {
        criarMapa();
        while (true)
        {
            posicao.ImprimeHistoria();
            posicao.ImprimeSaidas();
            string saida = Console.ReadLine();
            posicao.PegarSaida(saida);
        }

    }
    public void criarMapa()
    {
        var quarto = new Area("Você acordou com amnésia em um quarto comum. Sua barriga ronca e você está com muita fome, mas não sabe onde tem comida.");
        posicao = quarto;

        var sala = new Area("Você está na sala, aqui tem um sofá, uma televisão antiga e uma estante de livros, não parece ter nada para comer...");
        var escritorio = new Area("Aqui parece ser um escritório, com uma escrivaninha, uma estante de livros, parece que essa pessoa gosta mesmo de ler... (você ainda está com fome!)");
        var banheiro = new Area("Você está no banheiro da casa, acho que você não vai querer comer nada daqui...");
        var cozinha = new Area("Parabéns, você chegou a cozinha, ao abrir a geladeira você encontrou uma bela pizza que parece ser de ontem. Após comer você se lembra de tudo!", true);
        quarto.sul(sala);
        sala.oeste(escritorio);
        sala.sul(banheiro);
        sala.leste(cozinha);
    }
}