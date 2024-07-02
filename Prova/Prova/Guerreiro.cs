public class Guerreiro : Personagem
{
    public Guerreiro(string nome, int vida, int ataque, int defesa, bool comVida, int especial) : base (nome,vida,ataque,defesa,comVida,especial) {}

    public override int Atacar()
    {
        Console.WriteLine("Você ataca com a sua espada e corta o inimigo!");
        return ataque;
    }

    public override int Especial()
    {
        Console.WriteLine("Você utiliza o seu machado duplo e machuca seu oponente!");
        return especial;
    }

    public override int Vida()
    {
        return vida;
    }


}