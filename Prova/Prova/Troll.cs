public class Troll : Personagem
{
    public Troll(string nome, int vida, int ataque, int defesa, bool comVida, int especial) : base (nome,vida,ataque,defesa,comVida,especial) {}

    public override int Atacar()
    {
        Console.WriteLine("O troll te ataca com um bastão");
        return ataque;
    }
    
    public override void Morre()
    {
        Console.WriteLine("Você conseguiu matar o troll!");
        Console.WriteLine("Com água suficiente para o seu povo, sua missão na gruta estava concluída.");
    }

    public override void PerdeVida(int dano)
    {
        Random random = new Random();
        int danoInimigo = random.Next(8, dano);
        vida -= danoInimigo;
        Console.WriteLine($"O troll levou {danoInimigo} de dano e está com {vida} de vida!");
    }

    public override int Vida()
    {
        return vida;
    }
}
