using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoCodeIT
{
    class SmartForTwo
    {
        Aviao av = new Aviao();
        Terminal tm = new Terminal();

        public void TerminalAteAviao(int index_motorista, int index_passageiro, List<Tripulacao> pessoas)
        {
            
                        
            var motorista   = pessoas[index_motorista].descricao;
            var passageiro  = pessoas[index_passageiro].descricao;
            

            
            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }
        
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " leva " + passageiro + " do terminal até o avião.");
                av.SetPessoasAviao(index_passageiro, pessoas);
                tm.RemovePessoasTerminal(index_passageiro, pessoas);
                tm.RemovePessoasTerminal(index_motorista, pessoas);
            }
            

        }
        public void AviaoAteTerminal(int index_motorista, int index_passageiro, List<Tripulacao> pessoas)
        {
            var motorista = pessoas[index_motorista].descricao;
            var passageiro = pessoas[index_passageiro].descricao;
            


            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista +  " não pode dirigir");
            }
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " leva " + passageiro + " do avião até o terminal.");
                av.RemovePessoasAviao(index_passageiro, pessoas);
                tm.SetPessoasTerminal(index_passageiro, pessoas);
            }
         

        }

        public void TerminalAteAviaoVazio(int index_motorista,  List<Tripulacao> pessoas) 
        {
            var motorista = pessoas[index_motorista].descricao;




            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " vai sozinho do terminal até o avião.");
                
            }
        }
        public void AviaoAteTerminalVazio(int index_motorista, List<Tripulacao> pessoas) 
        {
            var motorista = pessoas[index_motorista].descricao;
            


            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " vai sozinho do avião até o terminal.");
                av.RemovePessoasAviao(index_motorista, pessoas);
            }
        }

        public void ficaAviao(int index_pessoa, List<Tripulacao> pessoas)
        {

            
            var pessoa = pessoas[index_pessoa].descricao;
            

 
            Console.WriteLine(pessoa + " Fica no avião ");
            av.SetPessoasAviao(index_pessoa, pessoas);
            


        }
        public void ficaTerminal(int index_pessoa, List<Tripulacao> pessoas)
        {


            var pessoa = pessoas[index_pessoa].descricao;



            Console.WriteLine(pessoa + " Fica no avião ");
            tm.SetPessoasTerminal(index_pessoa, pessoas);



        }
    }
}
