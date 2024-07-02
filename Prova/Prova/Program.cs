
bool boss1 = true;
bool boss2 = false;
bool jogar = true;
string opcao = "";
string acao = "";
string restart = "";
Personagem personagem = new Personagem("", 100, 30, 70, true, 50);
Guerreiro guerreiro = new Guerreiro("", 100, 30, 70, true, 50);
Troll troll= new Troll("", 100, 10, 70, true, 50);
Mago mago = new Mago("", 100, 30, 70, true, 50);
Gigante gigante= new Gigante("", 100, 10, 70, true, 50);

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("### BEM-VINDO(A) À AVENTURA ESPACIAL ###\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("# Carta do Governo #");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Soldado, você é a última esperança do seu planeta.");
    Console.WriteLine("Desde que perdemos a Grande Guerra Cósmica, os recursos ficaram inacessíveis.");
    Console.WriteLine("Explore o espaço e retorne para Goliah com suprimentos.\n");
    Console.WriteLine("Então você embarca na sua jornada e decide parar em um planeta abandonado para procurar por suprimentos.\n");

    Console.WriteLine("Insira o seu nome:");
    personagem.DefineNome(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Você é um guerreiro ou um mago?\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1 - Guerreiro \n2 - Mago");
    opcao = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Ao entrar em uma gruta um troll te para.\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("(Troll) ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("- O que um intruso está fazendo no meu planeta?");
    Console.WriteLine("(Você) - Eu vim buscar recursos para o meu povo.");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("(Troll) ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("- Para pegar a minha água tem que passar por cima de mim.");
    Console.WriteLine("(Você) - Isso não será um problema...\n");
    /*Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Escolha: \n1 - Atacar \n2 - Especial \n3 - Defender \n0 - Sair");
    Console.ForegroundColor = ConsoleColor.White;
    acao = Console.ReadLine();*/

    do
    {
        if(opcao == "1")
        {
            Console.WriteLine("Escolha:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1 - Atacar \n2 - Especial \n3 - Defender \n0 - Sair");
            Console.ForegroundColor = ConsoleColor.White;            
            acao = Console.ReadLine();

            switch (acao)
            {
                case "1":
                    Console.Clear();  
                    Console.WriteLine("Sua vez de atacar!");
                    troll.PerdeVida(guerreiro.Atacar());
                    Console.WriteLine("O troll te ataca!\n");
                    guerreiro.PerdeVida(troll.Atacar());                        
                break;
                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("Sua vez de atacar!");
                    troll.PerdeVida(guerreiro.Especial());
                    Console.WriteLine("O troll te ataca!\n");
                    guerreiro.PerdeVida(troll.Atacar());                 
                break;

                case "3":
                    Console.Clear();
                    guerreiro.Defende();
                    Console.WriteLine("Sua vez de atacar!");    
                break;

                case "0":
                    jogar = false;
                    boss1 = false;
                    boss2 = false;
                break;

                default:
                    Console.WriteLine("Selecione uma opção válida");
                    acao = Console.ReadLine();
                break;
            }
        }

        else if(opcao == "2")
        {
            Console.WriteLine("Escolha:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1 - Atacar \n2 - Especial \n3 - Defender \n0 - Sair");
            Console.ForegroundColor = ConsoleColor.White;            
            acao = Console.ReadLine(); 
            switch (acao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Sua vez de atacar!");
                    troll.PerdeVida(mago.Atacar());
                    Console.WriteLine("O troll te ataca!\n");
                    mago.PerdeVida(troll.Atacar());                   
                break;
                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("Sua vez de atacar!");
                    troll.PerdeVida(mago.Especial());
                    Console.WriteLine("O troll te ataca!\n");
                    mago.PerdeVida(troll.Atacar());              
                break;

                case "3":
                    Console.Clear();
                    mago.Defende();
                    Console.WriteLine("Sua vez de atacar!");                   
                break;

                case "0":
                    jogar = false;
                    boss1 = false;
                    boss2 = false;    
                break;

                default:
                    Console.WriteLine("Selecione uma opção válida");
                    acao = Console.ReadLine();
                break;
            }
        }
        else
        {
            Console.WriteLine("Selecione uma opção válida");
            opcao = Console.ReadLine();
        }

        if (troll.Vida() <= 0)
        {          
            boss1 = false;
            boss2 = true; 
        }

        if (guerreiro.Vida() <= 0)
        {
            personagem.Morre();
            boss1 = false;
            boss2 = false;
            Console.WriteLine("Digite 0 para recomeçar");
            acao = Console.ReadLine();
        }

        if (mago.Vida() <= 0)
        {
            personagem.Morre();
            boss1 = false;
            boss2 = false;
            Console.WriteLine("Digite 0 para recomeçar");
            acao = Console.ReadLine();
        }
    } while(boss1); 

    Console.Clear();
    troll.Morre();
    Console.WriteLine("Você sai da gruta e foge para a floresta. Lá você encontra um gigante protegendo o seu alimento.");
    Console.WriteLine("Vocês batalham por comida!");

    do
    {
        if(opcao == "1")
        {
            Console.WriteLine("Escolha:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1 - Atacar \n2 - Especial \n3 - Defender \n0 - Sair");
            Console.ForegroundColor = ConsoleColor.White;            
            acao = Console.ReadLine(); 

                switch (acao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Sua vez de atacar!");
                        gigante.PerdeVida(guerreiro.Atacar());
                        Console.WriteLine("O gigante te ataca!\n");
                        guerreiro.PerdeVida(gigante.Atacar());  
                    break;
                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Sua vez de atacar!");
                        gigante.PerdeVida(guerreiro.Especial());
                        Console.WriteLine("O gigante te ataca!\n");
                        guerreiro.PerdeVida(gigante.Atacar());  
                    break;

                    case "3":
                        Console.Clear();                    
                        guerreiro.Defende();
                        Console.WriteLine("Sua vez de atacar!");
                    break;

                    case "0":
                        boss1 = false;
                        boss2 = false;
                        jogar = false;
                    break;

                    default:
                        Console.WriteLine("Selecione uma opção válida");
                        acao = Console.ReadLine();
                    break;
                }
        }

        else if(opcao == "2")
        {
                Console.WriteLine("Escolha:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Atacar \n2 - Especial \n3 - Defender \n0 - Sair");
                Console.ForegroundColor = ConsoleColor.White;            
                acao = Console.ReadLine();

                switch (acao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Sua vez de atacar!");
                        gigante.PerdeVida(mago.Atacar());
                        Console.WriteLine("O gigante te ataca!\n");
                        mago.PerdeVida(gigante.Atacar());
                    break;
                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Sua vez de atacar!");          
                        gigante.PerdeVida(mago.Especial());
                        Console.WriteLine("O gigante te ataca!\n");
                        mago.PerdeVida(gigante.Atacar());
                    break;

                    case "3":
                        Console.Clear();                        
                        mago.Defende();
                        Console.WriteLine("Sua vez de atacar!");
                    break;

                    case "0":
                        boss1 = false;
                        boss2 = false;
                        jogar = false;
                    break;

                    default:
                        Console.WriteLine("Selecione uma opção válida");
                        acao = Console.ReadLine();
                    break;
                }
        }

        else
        {
            Console.WriteLine("Selecione uma opção válida");
            opcao = Console.ReadLine();
        }

        if (gigante.Vida() <= 0)
        {
            Console.Clear();
            gigante.Morre();
            boss1 = false;
            boss2 = false;
            Console.WriteLine("Você deseja jogar novamente? s/n");
            restart = Console.ReadLine();
            if(restart == "s" || restart == "S")
            {
                jogar = true;
                boss1 = true;
                boss2 = false;
            }
            else
            {
                jogar = false;
                boss1 = false;
                boss2 = false;
            }
        }

        if (guerreiro.Vida() <= 0)
        {
            personagem.Morre();
            boss1 = false;
            boss2 = false;
            Console.WriteLine("Digite 0 para recomeçar");
            acao = Console.ReadLine();
        }

        if (mago.Vida() <= 0)
        {
            personagem.Morre();
            boss1 = false;
            boss2 = false;
            Console.WriteLine("Digite 0 para recomeçar");
            acao = Console.ReadLine();
        }
    }while (boss2);
}while(jogar);