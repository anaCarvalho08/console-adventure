public class Mago : Personagem
{
    public Mago(string nome, int vida, int ataque, int defesa, bool comVida, int especial) : base (nome,vida,ataque,defesa,comVida,especial) {}

    public override int Atacar()
    {
        Console.WriteLine("Você ataca o inimigo com uma bola de fogo!");
        return ataque;
    }

    public override int Especial()
    {
        Console.WriteLine("Você lança uma bola de veneno no inimigo!");
        return especial;
    }

    public override int Vida()
    {
        return vida;
    }
}