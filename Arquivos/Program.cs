﻿using Arquivos.Views;

/*
    Programa para leitura de dados de pessoas
    e exportação em arquivo .txt
*/

int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");    
    Console.WriteLine("1 - Clientes");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
            Console.WriteLine("OPÇÃO CLIENTES");
            ClientView clientView = new ClientView();
        break;
    }
}
while( option > 0 );