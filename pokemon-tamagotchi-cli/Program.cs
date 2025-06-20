﻿// See https://aka.ms/new-console-template for more information

using pokemon_tamagotchi_cli;

Menu menu = new Menu();
PokemonApiService pokemonApiService = new PokemonApiService();
List<PokemonResult> especiesDisponiveis = pokemonApiService.ObterEspeciesDisponiveis();
List<Mascote> mascotesAdotados = new List<Mascote>();

menu.MostrarMensagemDeBoasVindas();

while (true)
{
    menu.MostrarMenuPrincipal();
    int escolha = menu.ObterEscolhaDoJogador();

    switch (escolha)
    {
        case 1:
            while (true)
            {
                menu.MostrarMenuDeAdocao();
                escolha = menu.ObterEscolhaDoJogador();
                switch (escolha)
                {
                    case 1:
                        menu.MostrarEspeciesDisponiveis(especiesDisponiveis);
                        break;
                    case 2:
                        menu.MostrarEspeciesDisponiveis(especiesDisponiveis);
                        int indiceEspecie = menu.ObterEspecieEscolhida(especiesDisponiveis);
                        Mascote detalhes = pokemonApiService.ObterDetalhesDaEspecie(especiesDisponiveis[indiceEspecie]);
                        menu.MostrarDetalhesDaEspecie(detalhes);
                        break;
                    case 3:
                        menu.MostrarEspeciesDisponiveis(especiesDisponiveis);
                        indiceEspecie = menu.ObterEspecieEscolhida(especiesDisponiveis);
                        detalhes = pokemonApiService.ObterDetalhesDaEspecie(especiesDisponiveis[indiceEspecie]);
                        menu.MostrarDetalhesDaEspecie(detalhes);
                        if (menu.ConfirmarAdocao())
                        {
                            mascotesAdotados.Add(detalhes);
                            Console.WriteLine("Parabéns! Você adotou um " + detalhes.Name + "!");
                            Console.WriteLine("──────────────");
                            Console.WriteLine("────▄████▄────");
                            Console.WriteLine("──▄████████▄──");
                            Console.WriteLine("──██████████──");
                            Console.WriteLine("──▀████████▀──");
                            Console.WriteLine("─────▀██▀─────");
                            Console.WriteLine("──────────────");
                        }
                        break;
                    case 4:
                        break;
                }
                if (escolha == 4)
                {
                    break;
                }
            }
            break;
        case 2:
            menu.MostrarMascotesAdotados(mascotesAdotados);
            break;
        case 3:
            Console.WriteLine("Obrigado por jogar! Até a próxima!");
            return;
    }
}
        
