﻿using System.Runtime.ExceptionServices;
using Plantao_UC_COD_BACK.Classes;

string opcao = "";
PessoaJuridica PJ = new PessoaJuridica();

PessoaJuridica PJ2 = new PessoaJuridica();
PJ2.Cnpj = "649846";
PJ2.Nome = "Caique";

do{
    Console.WriteLine(@"
    
    1 - Cadastrar
    2 - Sair
    
    ");

    opcao = Console.ReadLine();

    if (opcao == "1"){
        PessoaJuridica pj = new PessoaJuridica();
        Console.WriteLine("Digite o nome da Pessoa Juridica");
        pj.Nome = Console.ReadLine();

        Console.WriteLine("Digite o rendimento da Pessoa Juridica");
        pj.Rendimento =  float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o cnpj da Pessoa Juridica");
        pj.Cnpj = Console.ReadLine();

        PJ.Inserir(pj);
    }
}while(opcao != "2");


