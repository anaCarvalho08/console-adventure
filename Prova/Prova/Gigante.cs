public class Gigante : Personagem
{
    public Gigante(string nome, int vida, int ataque, int defesa, bool comVida, int especial) : base (nome,vida,ataque,defesa,comVida,especial) {}

    public override int Atacar()
    {
        Console.WriteLine("O gigante pisa em você!");
        return ataque;
    }

    public override void PerdeVida(int dano)
    {
        Random random = new Random();
        int danoInimigo = random.Next(4, dano);
        vida -= danoInimigo;
        Console.WriteLine($"O gigante levou {danoInimigo} de dano e está com {vida} de vida!");
    }

    public override void Morre()
    {
        Console.WriteLine("Você conseguiu matar o gigante!\n");
        Console.WriteLine("Após quase morrer e matar monstros terríveis, você finalmente volta para casa.");
        Console.WriteLine("Com recurso suficiente para a população, o governo te agradece com uma homenagem.");
        Console.WriteLine("Eles constroem uma estátua em homenagem ao herói que salvou seu povo da miséria.");
    }

    public override int Vida()
    {
        return vida;
    }

}