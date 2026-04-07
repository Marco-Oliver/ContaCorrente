
using System.Security.Cryptography;
class Progam
{
    static void Main(string[] args)
    {
        //Conta corrente 1
        ContaCorrente contaUm = new ContaCorrente();
        contaUm.numeroIdentificacao = 1;
        contaUm.titular = "Marco";



        // Conta corrente 2
        ContaCorrente contaDois = new ContaCorrente();
        contaDois.numeroIdentificacao = 2;
        contaDois.titular = "Rech";
        contaDois.saldo = 1200;


        TelaPrincipal tela = new TelaPrincipal();
        ContaCorrente contaAcessada = contaUm;

        while (true)
        {
            string? opcaoMenu = tela.ApresentarMenuOpcoes(contaAcessada);

            if (opcaoMenu == "S")
                break;

            if (opcaoMenu == "1")
            {
                tela.ApresentarOperacaoSaque(contaAcessada);
            }

            else if (opcaoMenu == "2")
            {
                tela.ApresentarOperacaoDeposito(contaAcessada);
            }

            else if (opcaoMenu == "3")
            {
                tela.ApresentarOperacaoTransferencia(contaAcessada, contaDois);
            }


            else if (opcaoMenu == "4")
            {
                tela.ApresentarOperacaoObterSaldo(contaAcessada);
            }



        }


    }

}


