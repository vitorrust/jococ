﻿// DESENVOLVIDO POR PEDRO FERNANDES - TADS 
// DUPLA: PEDRO FERNANDES BARROS FILHO E VITOR RODRIGUES DE LUCENA 

using System;
using System.Collections;

public class meuJogo
{
    static int pontosjg1 = 0;
    static int pontosjg2 = 0;
    static int vezesCartaoAmareloJg1 = 0;
    static int vezesCartaoAmareloJg2 = 0;
    static int valorPont = 0;
    static int valorPont2 = 0;
    static int valorPont3 = 0;
    static int pontosPorRodada = 0;
    static int gols1 = 0;
    static int gols2 = 0;

    static string nickJogador = "";


    public static void Main(string[] args)
    {
        // INTRODUÇÃO
        Console.WriteLine("NOME DO JOGADOR 1: ");
        string nickJogador1 = Console.ReadLine();

        // PLAYER VS PLAYER
        Console.WriteLine("NOME DO JOGADOR 2: ");
        string nickJogador2 = Console.ReadLine();

        int energyJg1 = 10;
        int energyJg2 = 10;

        // SORTEIO DE QUEM VAI COMEÇAR O JOGO
        Random objRand = new Random();
        int ordemJogador = objRand.Next(1, 3);
        int proximoJogador = ordemJogador;

        if (ordemJogador == 1)
        {
            Console.WriteLine("==== O JOGADOR 1 COMEÇA O JOGO =====");
        }
        else
        {
            Console.WriteLine("==== O JOGADOR 2 COMEÇA O JOGO =====");
        }

        // LOOP ATÉ QUE ENERGIA SEJA 0
        while (energyJg1 > 0 || energyJg2 > 0)
        {
             // VERIFICA SE O JOGADOR 1 PODE JOGAR E TEM SALDO DE ENERGIAS DISPONÍVEIS.
            if (ordemJogador == 1 && energyJg1 <= 0)
            {
                Console.WriteLine("O JOGADOR 1 FICOU SEM ENERGIA. O JOGO CONTINUA COM O JOGADOR 2.");
                ordemJogador = 2; // ALTERNAR PARA O JOGADOR 2 JOGAR
                continue;
            }

            // VERIFICA SE O JOGADOR 2 PODE JOGARE TEM SALDO DE ENERGIAS DISPONÍVEIS.
            if (ordemJogador == 2 && energyJg2 <= 0)
            {
                Console.WriteLine("O JOGADOR 2 FICOU SEM ENERGIA. O JOGO CONTINUA COM O JOGADOR 1.");
                ordemJogador = 1; // ALTERNA PARA O JOGADOR 1 JOGAR
                continue;
            }

            Console.WriteLine("PRESSIONE << ENTER >> PARA SORTEAR AS CARTAS.");
            string start = Console.ReadLine();
            Console.WriteLine("===================================");
            Console.Clear();

            // SORTEIO RANDOM DAS CARTAS
            Random objCard = new Random();
            int sorteioCartas = objCard.Next(1, 7);

            Random objCard2 = new Random();
            int sorteioCartas2 = objCard2.Next(1, 7);

            Random objCard3 = new Random();
            int sorteioCartas3 = objCard3.Next(1, 7);


            string nomeCartaUm = "";

            switch (sorteioCartas)
            {
                case 1:
                    nomeCartaUm = "Gol";
                    valorPont = 3;
                    break;
                case 2:
                    nomeCartaUm = "Penalti";
                    valorPont = 2;
                    break;
                case 3:
                    nomeCartaUm = "Falta";
                    valorPont = 1;
                    break;
                case 4:
                    nomeCartaUm = "Cartão Amarelo";
                    valorPont = 1;
                    break;
                case 5:
                    nomeCartaUm = "Cartão Vermelho";
                    valorPont = 0;
                    break;
                case 6:
                    nomeCartaUm = "Energia";
                    valorPont = 2;
                    break;
            }

            string nomeCartaDois = "";

            switch (sorteioCartas2)
            {
                case 1:
                    nomeCartaDois = "Gol";
                    valorPont2 = 3;
                    break;
                case 2:
                    nomeCartaDois = "Penalti";
                    valorPont2 = 2;
                    break;
                case 3:
                    nomeCartaDois = "Falta";
                    valorPont2 = 1;
                    break;
                case 4:
                    nomeCartaDois = "Cartão Amarelo";
                    valorPont2 = 1;
                    break;
                case 5:
                    nomeCartaDois = "Cartão Vermelho";
                    valorPont2 = 0;
                    break;
                case 6:
                    nomeCartaDois = "Energia";
                    valorPont2 = 2;
                    break;
            }

            string nomeCartaTres = "";

            switch (sorteioCartas3)
            {
                case 1:
                    nomeCartaTres = "Gol";
                    valorPont3 = 3;
                    break;
                case 2:
                    nomeCartaTres = "Penalti";
                    valorPont3 = 2;
                    break;
                case 3:
                    nomeCartaTres = "Falta";
                    valorPont3 = 1;
                    break;
                case 4:
                    nomeCartaTres = "Cartão Amarelo";
                    valorPont3 = 1;
                    break;
                case 5:
                    nomeCartaTres = "Cartão Vermelho";
                    valorPont3 = 0;
                    break;
                case 6:
                    nomeCartaTres = "Energia";
                    valorPont3 = 2;
                    break;
            }

            string c1 = sorteioCartas.ToString();
            string c2 = sorteioCartas2.ToString();
            string c3 = sorteioCartas3.ToString();

            Console.WriteLine(nomeCartaUm + " -- " + nomeCartaDois + " -- " + nomeCartaTres);
            Console.WriteLine("===================================");

            // LÓGICA QUE ALTERNA OS JOGADORES 1 E 2
            if (ordemJogador == 1)
            {
                proximoJogador = 2;
            }
            else
            {
                proximoJogador = 1;
            }


            // ESCOPO QUE VERIFICA TODOS OS REQUISITOS E CONDIÇÕES PROPOSTOS
            if ((sorteioCartas != sorteioCartas2 && sorteioCartas != sorteioCartas3) || (sorteioCartas2 != sorteioCartas && sorteioCartas2 != sorteioCartas3) || (sorteioCartas3 != sorteioCartas && sorteioCartas3 != sorteioCartas2))
            {
                pontosPorRodada = valorPont + valorPont2 + valorPont3;
                Console.WriteLine("PONTOS DA RODADA: " + pontosPorRodada);
                if (ordemJogador == 1)
                {
                    energyJg1 = energyJg1 - 1;
                    pontosjg1 += pontosPorRodada;
                    proximoJogador = 2;
                }
                else
                {
                    energyJg2 = energyJg2 - 1;
                    pontosjg2 += pontosPorRodada;
                    proximoJogador = 1;
                }
            }

            if (nomeCartaUm == "Gol" && nomeCartaDois == "Gol" && nomeCartaTres == "Gol")
            {
                Console.WriteLine("O JOGADOR " + ordemJogador + " GANHOU UM PONTO E MARCOU 1 GOL!");

                if (ordemJogador == 1)
                {
                    pontosjg1++;

                    gols1 += 1;
                }
                else
                {
                    pontosjg2++;
                    energyJg2 = energyJg2 - 1;
                    gols2 += 1;
                }
            }


            if (nomeCartaUm == "Energia" && nomeCartaDois == "Energia" && nomeCartaTres == "Energia")
            {
                Console.WriteLine("VOCÊ GANHOU 1 ENERGIA!");
                if (ordemJogador == 1)
                {
                    energyJg1++;
                }
                else
                {
                    energyJg2++;
                }
            }

            if (nomeCartaUm == "Penalti" && nomeCartaDois == "Penalti" && nomeCartaTres == "Penalti")
            {
                Console.WriteLine("ESCOLHA UMA OPÇÃO PARA BATER O PÊNALTI: ESQUERDA[E], DIREITA[D], CENTRO[C]");
                string escolhaPenalti = Console.ReadLine();

                Console.WriteLine("ONDE VAI DEFENDER O PÊNALTI: ESQUERDA[E], DIREITA[D], CENTRO[C]");
                string defesaPenalti = Console.ReadLine();

                if (escolhaPenalti != defesaPenalti)
                {
                    Console.WriteLine("GOOOOOOLLL!!");
                    if (ordemJogador == 1)
                    {
                        gols1 += 1;
                    }
                    else
                    {
                        gols2 += 1;
                    }
                }
                else
                {
                    Console.WriteLine("DEFENDEUUUU!!");
                }
                if (ordemJogador == 1)
                {
                    pontosjg1++;
                    energyJg1 = energyJg1 - 1;
                }
                else
                {
                    pontosjg2++;
                    energyJg2 = energyJg2 - 1;
                }
            }

            if (nomeCartaUm == "Falta" && nomeCartaDois == "Falta" && nomeCartaTres == "Falta")
            {
                Console.WriteLine("PASSOU A VEZ!");
                if (ordemJogador == 1)
                {
                    energyJg1 = energyJg1 - 1;
                }
                else
                {
                    energyJg2 = energyJg2 - 1;
                }
            }

            if (nomeCartaUm == "Cartão Amarelo" && nomeCartaDois == "Cartão Amarelo" && nomeCartaTres == "Cartão Amarelo")
            {
                if (ordemJogador == 1)
                {
                    energyJg1 = energyJg1 - 1;
                }
                else
                {
                    energyJg2 = energyJg2 - 1;
                }
                Console.WriteLine("O JOGADOR " + ordemJogador + " PERDEU UMA ENERGIA.");

                if ((ordemJogador == 1 && vezesCartaoAmareloJg1 == 1) || (ordemJogador == 2 && vezesCartaoAmareloJg2 == 1))
                {
                    Console.WriteLine("O jogador " + ordemJogador + " perdeu 2 energias.");
                    if (ordemJogador == 1)
                    {
                        energyJg1 -= 2;
                        vezesCartaoAmareloJg1 += 1;
                    }
                    else
                    {
                        energyJg2 -= 2;
                        vezesCartaoAmareloJg2 += 1;
                    }
                }
                else
                {
                    Console.WriteLine("NO PRÓXIMO CARTÃO AMARELO PERDERÁ 2 ENERGIAS!");
                    if (ordemJogador == 1)
                    {
                        energyJg1 -= 1;
                        vezesCartaoAmareloJg1 = 1;
                    }
                    else
                    {
                        energyJg2 -= 1;
                        vezesCartaoAmareloJg2 = 1;
                    }
                }

            }


            if (nomeCartaUm == "Cartão Vermelho" && nomeCartaDois == "Cartão Vermelho" && nomeCartaTres == "Cartão Vermelho")
            {
                Console.WriteLine("O JOGADOR " + ordemJogador + " PERDEU 2 ENERGIAS");

                if (ordemJogador == 1)
                {
                    energyJg1 -= 2;
                }
                else
                {
                    energyJg2 -= 2;
                }
            }


            Console.WriteLine("VEZ DO JOGADOR " + proximoJogador + "!");


            ordemJogador = proximoJogador;
            
            // MOSTRA AO USUÁRIO AS INFORMAÇÕES CONFORME O DECORRER DA PARTIDA
            Console.WriteLine("= = = = = = = = = = = = = = = = =");
            Console.WriteLine("PONTOS DO JOGADOR 1: " + pontosjg1);
            Console.WriteLine("PONTOS DO JOGADOR 2: " + pontosjg2);
            Console.WriteLine("= = = = = = = = = = = = = = = = =");
            Console.WriteLine("ENERGIAS DO JOGADOR 1: " + energyJg1);
            Console.WriteLine("ENERGIAS DO JOGADOR 2: " + energyJg2);
            Console.WriteLine("= = = = = = = = = = = = = = = = =");
            Console.WriteLine("GOLS DO JOGADOR 1: " + gols1);
            Console.WriteLine("GOLS DO JOGADOR 2: " + gols2);
            Console.WriteLine("= = = = = = = = = = = = = = = = =");

        }
        
        // LÓGICA QUE FINALIZA O JOGO E DETERMINA O VENCEDOR/EMPATE
        if (energyJg1 <= 0 && energyJg2 <= 0)
        {
            Console.WriteLine("= = = = = = = = = = = = = = = = =");
            Console.WriteLine("FIM DE JOGO!");


            if (gols1 == gols2 && pontosjg1 == pontosjg2)
            {
                Console.WriteLine("A PARTIDA EMPATOU!!");
                Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 1 " + " GOLS: " + gols1 + " / " + "PONTOS: " + pontosjg1);
                Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 2: " + " GOLS: " + gols2 + " / " + "PONTOS: " + pontosjg2);
            }
            else if (gols1 == gols2)
            {
                if (pontosjg1 > pontosjg2)
                {
                    Console.WriteLine("O JOGADOR 1 VENCEU A PARTIDA!");
                    Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 1: " + " GOLS: " + gols1 + " / " + "PONTOS: " + pontosjg1);
                    Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 2: " + " GOLS: " + gols2 + " / " + "PONTOS: " + pontosjg2);
                }
                else
                {
                    Console.WriteLine("O JOGADOR 2 VENCEU A PARTIDA!");
                    Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 1 " + " GOLS: " + gols1 + " / " + "PONTOS: " + pontosjg1);
                    Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 2: " + " GOLS: " + gols2 + " / " + "PONTOS: " + pontosjg2);
                }
            }
            else if (gols1 > gols2)
            {
                Console.WriteLine("O JOGADOR 1 VENCEU A PARTIDA!");
                Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 1 " + " GOLS: " + gols1 + " - " + "PONTOS: " + pontosjg1);
                Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 2: " + " GOLS: " + gols2 + " / " + "PONTOS: " + pontosjg2);
            }
            else
            {
                Console.WriteLine("O JOGADOR 2 VENCEU A PARTIDA!");
                Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 1 " + " GOLS: " + gols1 + " / " + "PONTOS: " + pontosjg1);
                Console.WriteLine("SALDO DE GOLS E PONTOS JOGADOR 2: " + " GOLS: " + gols2 + " / " + "PONTOS: " + pontosjg2);
            }

            Console.WriteLine("DIGITE '-1' PARA SAIR, OU DIGITE '0' PARA UMA NOVA PARTIDA.");
            string opcao = Console.ReadLine();

            if (opcao == "-1")
            {
                //SAIR DO PROGRAMA
                Console.WriteLine("OBRIGADO POR JOGAR! ATÉ A PRÓXIMA.");
                Environment.Exit(0);
            }
            else if (opcao == "0")
            {
                // REINICIAR O JOGO
                Main(args);
            }
            else
            {
                // OPÇÃO INVÁLIDA.
                Console.WriteLine("OPÇÃO INVÁLIDA.");
            }
        }
    }
}
