using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            List<Trainer> trainers = new List<Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] splittedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = splittedInput[0];
                string pokemonName = splittedInput[1];
                string pokemonElement = splittedInput[2];
                int pokemonHealth = int.Parse(splittedInput[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);


                Trainer trainer = new Trainer(trainerName, 0, new List<Pokemon>());

                bool HasTrainer = false;

                foreach (Trainer item in trainers)
                {
                    if (item.Name == trainerName)
                    {
                        item.Pokemons.Add(pokemon);
                        HasTrainer = true;
                    }
                }
                if (!HasTrainer)
                {
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                bool hasElement = false;
                foreach (Trainer trainer in trainers)
                {
                    List<Pokemon> newList = new List<Pokemon>();
                    foreach (var item in trainer.Pokemons)
                    {
                        newList.Add(item);
                    }
                    foreach (var item in trainer.Pokemons)
                    {
                        if (item.Element == command)
                        {
                            trainer.Badges++;
                            hasElement = true;
                        }
                    }
                    if (!hasElement)
                    {
                        foreach (var item in trainer.Pokemons)
                        {
                            item.Health -= 10;
                            if (item.Health <= 0)
                            {
                                newList.Remove(item);
                                
                            }
                        }
                    }
                    trainer.Pokemons = newList;
                }

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
