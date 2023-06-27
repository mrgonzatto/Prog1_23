using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class AnimalView
    {

        private AnimalController animalController;
        private ClientController clientController;

        public AnimalView()
        {
            animalController = new AnimalController();
            clientController = new ClientController();
            this.Init();
        }        

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM ANIMALS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animal");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar Animais");
            Console.WriteLine("4 - Importar Animais");
            Console.WriteLine("5 - Pesquisar Animais");
            Console.WriteLine("");

            int option = 0;
            option = Convert.ToInt32( Console.ReadLine() );

            switch(option)
            {
                case 1 : 
                    Insert();
                break;

                case 2 :                    
                break;

                case 3 :                    
                break;

                case 4 :                    
                break;

                case 5 :                    
                break;                

                default: 
                break;
            }
        }

        private void Insert()
        {
            Animal animal = new Animal();

            animal.Id = animalController.GetNextId();

            Console.WriteLine("Informe o nome:");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Selecione o cliente pelo ID:");
            Console.WriteLine("------------");
            foreach(var client in clientController.List())
            {
                Console.WriteLine(client.ToString());
                Console.WriteLine("------------");
            }
            Console.WriteLine("------------");
            Console.WriteLine("Informe o ID:");
            int id = Convert.ToInt32( Console.ReadLine() );

            animal.Client = clientController.GetClientById(id);

            bool retorno = animalController.Insert(animal);

            if( retorno )
                Console.WriteLine("Animal inserido com sucesso!");
            else    
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }        

    }
}