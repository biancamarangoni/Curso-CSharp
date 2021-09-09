using System;
using System.Threading;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem perso1 = new Personagem();
            perso1.nome = "Batman";
            perso1.idade = 46;
            perso1.armadura = "Bat Roupa";
            perso1.iA = "Alfred";
            perso1.soco = 25;
            perso1.chute = 30;

            Personagem perso2 = new Personagem();
            perso2.nome = "Wonder Woman";
            perso2.idade = 100;
            perso2.armadura = "Master Tinium";
            perso2.iA = "Amazon Prime";
            perso2.soco = 30;
            perso2.chute = 25;

            Console.WriteLine($"{perso1.nome} vs {perso2.nome}");

            string opcao, ataque, defesa;
            int contadorRound = 1;
            int contP1 = 0;
            int contP2 = 0;


            //perso2.Defender(30);
            //Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque! Sua vida restante = {perso2.ExibirVida()}");

            //perso2.Defender(40);
            //Console.WriteLine($"Pergonagem {perso2.nome} recebeu um ataque! Sua vida restante = {perso2.ExibirVida()}");
            do
            {
            Console.WriteLine($"Round {contadorRound} prepare-se!");
            Console.WriteLine("Selecione o personagem que você quer jogar:");
            if(contP1 == contP2)
            {
                Console.WriteLine($"1 - {perso1.nome} ----- vida = {perso1.ExibirVida()}");
                Console.WriteLine($"2 - {perso2.nome} ----- vida = {perso2.ExibirVida()}");
            }else if(contP1 < contP2){
                Console.WriteLine($"1 - {perso1.nome} ----- vida = {perso1.ExibirVida()}");
            }else{
                Console.WriteLine($"2 - {perso2.nome} ----- vida = {perso2.ExibirVida()}");
            }
            
            Console.WriteLine("0 - Desistir");
            opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    //atacar personagem 2
                    contP1++;
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                         ataque = Console.ReadLine();
                        Console.WriteLine($"Personagem {perso2.nome}, qual será sua defesa?");
                        Console.WriteLine("1 - Defesa de soco");
                        Console.WriteLine("2 - Defesa de chute");
                         defesa = Console.ReadLine();

                            if(ataque == defesa){
                                Console.WriteLine($"O {perso2.nome} defendeu o ataque!");
                            }else{
                                if(ataque == "1"){
                                    Console.WriteLine($"{perso2.nome} recebeu um ataque de {perso1.soco}");
                                    perso2.ReceberAtaque(perso1.soco);
                                }else{
                                    Console.WriteLine($"O {perso2.nome} recebeu um ataque de {perso1.chute}");
                                    perso2.ReceberAtaque(perso1.chute);
                                }//fim if
                                if(perso2.ExibirVida() > 0){
                                    Console.WriteLine($"Vida restante = {perso2.ExibirVida()}");
                                }else{
                                    Console.WriteLine("KO!");
                                }//fim if
                                Thread.Sleep(3000);
                            }
                    break;
                    case "2":
                        contP2++;
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                         ataque = Console.ReadLine();
                        Console.WriteLine($"Personagem {perso1.nome}, qual será sua defesa?");
                        Console.WriteLine("1 - Defesa de soco");
                        Console.WriteLine("2 - Defesa de chute");
                         defesa = Console.ReadLine();

                            if(ataque == defesa){
                                Console.WriteLine($"O {perso1.nome} defendeu o ataque!");
                            }else
                            {
                                 if(ataque == "1"){
                                    Console.WriteLine($"{perso1.nome} recebeu um ataque de {perso2.soco}");
                                    perso1.ReceberAtaque(perso2.soco);
                                }else{
                                    Console.WriteLine($"O {perso1.nome} recebeu um ataque de {perso2.chute}");
                                    perso1.ReceberAtaque(perso2.chute);
                                }//fim if
                                 if(perso1.ExibirVida() > 0){
                                    Console.WriteLine($"Vida restante = {perso1.ExibirVida()}");
                                }else{
                                    Console.WriteLine("KO!");
                                }
                                
                                Console.WriteLine($"Vida restante = {perso2.ExibirVida()}");
                                Console.WriteLine($"{perso1.nome} recebeu um dano de 25");
                                perso1.ReceberAtaque(25);
                                Console.WriteLine($"Vida restante = {perso1.ExibirVida()}");
                            }//fim do else
                    //atacar personagem 1
                    break;
                    case "0":
                    Console.WriteLine("Você perdeu por desistir!");
                    Thread.Sleep(2000);
                    break;
                    
                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }//fim while

                if(perso1.ExibirVida() <= 0)
                {
                    Console.WriteLine($"Vitória do jogador {perso2.nome}");
                    break;
                }
                else if (perso2.ExibirVida() <= 0){
                    Console.WriteLine($"Vitória do jogador {perso1.nome}");
                    break;
                }else if(opcao != "0"){
                    Console.WriteLine("Prepare-se para o próximo ROUND");
                    Thread.Sleep(2000);
                }
                Console.Clear();
                contadorRound ++;

            }while(opcao != "0");

        }//fim main
    }
}
