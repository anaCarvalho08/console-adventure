
public class Personagem
{
    protected string nome = "";
    protected int vida = 100;
    protected int ataque = 30;
    protected int especial = 50;
    protected int defesa = 6;
    protected int dano = 10;
    protected bool comVida = true;

    public Personagem (string nome, int vida, int ataque, int defesa, bool comVida, int especial)
    {
        this.nome = nome;
        this.vida = vida;
        this.ataque = ataque;
        this.comVida = comVida;
        this.especial = especial;
    }

    public void DefineNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public virtual int Atacar()
    {
        Console.WriteLine($"Você ataca!");
        return ataque;
    }

    public virtual int Especial()
    {
        Console.WriteLine($"Você dá o especial!");
        return especial;
    }

    public virtual void PerdeVida(int dano)
    {
        Random random = new Random();
        int danoInimigo = random.Next(0, dano);
        vida -= danoInimigo;
        Console.WriteLine($"Você levou {danoInimigo} de dano e está com {vida} de vida!");
    }

    public void Defende()
    {
        Random random = new Random();
        int danoInimigo = random.Next(5, dano);
        vida += defesa;
        Console.WriteLine($"Você se defende e está com {vida} de vida!");
    }

    public virtual void Morre()
    {
        Console.WriteLine($"O herói {GetNome()} morre em busca de uma vida melhor para o seu povo...");
    }

    public virtual int Vida(){return vida;}
}