using System;
using System.Collections.Generic;

namespace AvaliacaoCodeIT
{
    class Program
    {
        static void Main(string[] args)
        {

            SmartForTwo trajeto = new SmartForTwo();
            Aviao av = new Aviao();
            Terminal tm = new Terminal();

            var pessoas = new List<Tripulacao>
            {
                new Tripulacao { index = 0, id = 1, lider=1, permissao_dirigir=1, grupo=1,descricao="Piloto"},
                new Tripulacao { index = 1, id = 2, lider=0, permissao_dirigir=0, grupo=1,descricao="Oficial 1"},
                new Tripulacao { index = 2, id = 3, lider=0, permissao_dirigir=0, grupo=1,descricao="Oficial 2"},
                new Tripulacao { index = 3, id = 4, lider=1, permissao_dirigir=1, grupo=2,descricao="Chefe de Serviço"},
                new Tripulacao { index = 4, id = 5, lider=0, permissao_dirigir=0, grupo=2,descricao="comissária 1"},
                new Tripulacao { index = 5, id = 6, lider=0, permissao_dirigir=0, grupo=2,descricao="comissária 2"},
                new Tripulacao { index = 6, id = 7, lider=1, permissao_dirigir=1, grupo=3,descricao="Policial"},
                new Tripulacao { index = 7, id = 8, lider=1, permissao_dirigir=0, grupo=3,descricao="Presidiário"}
            };

            /*Carregar o terminal com as pessoas*/
            tm.carregaTerminal(pessoas);
            av.ListaAviao();
            tm.ListaTerminal();


            /*Trajeto*/
            //Policial leva Presidiario/  
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[7].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();
            //Policial volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[6].index, pessoas);
            //Policial leva Piloto/
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[0].index, pessoas);
         
            //Policial fica/
            trajeto.ficaAviao(pessoas[6].index, pessoas);
            //Piloto volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();
            //Piloto leva comissaria 1//
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[4].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();
            //Piloto volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);

            //Piloto leva comissaria 2//
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[5].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();

            //Piloto volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);

            //Piloto leva o Chefe de voo/
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[3].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();

            //Piloto volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);

            //Piloto leva oficial 1/
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[1].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();

            //Piloto volta com chefe de voo
            trajeto.AviaoAteTerminal(pessoas[0].index, pessoas[3].index, pessoas);
           
            //chefe de voo fica no terminal/
            //trajeto.ficaTerminal(pessoas[3].index, pessoas);

            //Piloto leva oficial 2/
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[2].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();

            //Piloto volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);

            //Piloto leva o Chefe de voo//
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[3].index, pessoas);
            trajeto.ficaAviao(pessoas[0].index, pessoas);
            av.ListaAviao();
            tm.ListaTerminal();

            Console.ReadLine();
        }
    }
}
