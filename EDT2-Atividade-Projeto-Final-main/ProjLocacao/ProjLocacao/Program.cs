using System;

namespace ProjLocacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipamentos equipamentos = new Equipamentos();
            Equipamento equipamento = new Equipamento();
            ContratoLocacoes locacoes = new ContratoLocacoes();
            ContratoLocacao contratoLocacao = new ContratoLocacao();
            TipoEquipamento tipoequipamento = new TipoEquipamento();
            int opcao;
            #region Menu
            do
            {
                Console.WriteLine(" __________________________________________________________");
                Console.WriteLine("|0. Sair                                                   |");
                Console.WriteLine("|1. Cadastrar tipo de equipamento                          |");
                Console.WriteLine("|2. Consultar tipo de equipamento                          |");
                Console.WriteLine("|3. Cadastrar equipamento                                  |");
                Console.WriteLine("|4. Registrar Contrato de Locação                          |");
                Console.WriteLine("|5. Consultar Contratos de Locação                         |");
                Console.WriteLine("|6. Liberar de Contrato de Locação                         |");
                Console.WriteLine("|7. Consultar Contratos de Locação liberados               |");
                Console.WriteLine("|8. Devolver equipamentos de Contrato de Locação liberado  |");
                Console.WriteLine(" __________________________________________________________");
                Console.WriteLine("Escolha uma opção:");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                #endregion
                switch (opcao)
                {
                    #region sair
                    case 0:
                        Console.WriteLine("Saindo");
                        break;
                    #endregion
                    #region Cadastrar Tipo
                    case 1:
                        Console.WriteLine("Digite o tipo de equipamento:");
                        string tipo = Console.ReadLine();
                        tipoequipamento.Nome = tipo;
                        equipamentos.incluir(tipoequipamento);
                        break;
                    #endregion
                    #region Consultar
                    case 2:
                        Console.WriteLine("Digite o tipo de equipamento:");
                        string tipo1 = Console.ReadLine();
                        tipoequipamento.Nome = tipo1;
                        foreach (TipoEquipamento tipoEquipamentoConsultar in equipamentos.Estoque)
                        {
                            if (tipoEquipamentoConsultar.Equals(tipoequipamento))
                                Console.WriteLine("Tipo:" + tipoequipamento.Nome);
                                foreach (Equipamento equipamentoConsultar in tipoEquipamentoConsultar.Itens)
                                {
                                    Console.WriteLine("Id:" + equipamentoConsultar.Id + 
                                                    "\nAvariado:" + equipamentoConsultar.Avariado + 
                                                    "\nDisponivel:" + equipamentoConsultar.Locado+
                                                    "\n");
                                }
                        }
                        break;
                    #endregion
                    #region Cadastrar Equipamento
                    case 3:
                        Console.WriteLine("Digite o tipo de equipamento:");
                        string tipo2 = Console.ReadLine();
                        tipoequipamento.Nome = tipo2;
                        foreach (TipoEquipamento tipoEquipamentoCadastrar in equipamentos.Estoque)
                        {
                            if (tipoEquipamentoCadastrar.Equals(tipoequipamento))
                                Console.WriteLine("Quantos equipamentos deseja cadastrar:");
                                int qtd = int.Parse(Console.ReadLine());
                                for (int i = 0; i < qtd; i++)
                                {
                                    equipamento.Locado = false;
                                    equipamento.Avariado = false;
                                    tipoEquipamentoCadastrar.incluir(equipamento);
                                }
                        }
                        break;
                    #endregion
                    #region Registrar Contrato
                    case 4:
                        Console.WriteLine("Data de saida:");
                        string saida = Console.ReadLine();
                        Console.WriteLine("Data de retorno:");
                        string retorno = Console.ReadLine();
                        contratoLocacao.Saida = DateTime.Parse(saida);
                        contratoLocacao.Retorno = DateTime.Parse(retorno);
                        string op = "";
                        while (op != "0")
                        {
                            Console.WriteLine("Tipo de equipamento:");
                            string tipo3 = Console.ReadLine();
                            tipoequipamento.Nome = tipo3;
                            Console.WriteLine("Quantidade de equipamentos:");
                            int qtd = int.Parse(Console.ReadLine());
                            for (int i = 0; i < qtd; i++)
                            {
                                equipamento.Locado = false;
                                equipamento.Avariado = false;
                                tipoequipamento.incluir(equipamento);
                                foreach (TipoEquipamento tipoequipamentoRegistrarContrato in equipamentos.Estoque)
                                {
                                    if (equipamentos.Estoque.Equals(tipoequipamento))
                                        foreach (Equipamento equipamentoRegistrarContrato in tipoequipamentoRegistrarContrato.Itens)
                                        {
                                            if (equipamentoRegistrarContrato.Equals(equipamento))
                                                equipamentoRegistrarContrato.Locado = true;
                                        }
                                }

                            }
                            contratoLocacao.incluir(tipoequipamento);

                            Console.WriteLine("0.Sair ");
                            op = Console.ReadLine();
                        }

                        locacoes.incluir(contratoLocacao);
                        break;
                    #endregion
                    #region Consultar Contrato
                    case 5:
                        Console.WriteLine("Digite o ID do Contrato:");
                        int id1 = int.Parse(Console.ReadLine());
                        
                        contratoLocacao.Id = id1;
                        foreach (ContratoLocacao contratoLocacaoConsultarContrato in locacoes.Contratos)
                        {
                            if (contratoLocacaoConsultarContrato.Equals(contratoLocacao))
                                contratoLocacao = contratoLocacaoConsultarContrato;
                                foreach (TipoEquipamento tipoEquipamentoConsultarContrato in contratoLocacao.Itens)
                                {
                                    Console.WriteLine("Tipo:" + tipoEquipamentoConsultarContrato.Nome);
                                    foreach (Equipamento equipamentoEquipamentoConsultarContrato in tipoEquipamentoConsultarContrato.Itens)
                                    {
                                        Console.WriteLine("Id:" + equipamentoEquipamentoConsultarContrato.Id + 
                                                          "\nAvariado:" + equipamentoEquipamentoConsultarContrato.Avariado + 
                                                          "\nAlocado:" + equipamentoEquipamentoConsultarContrato.Locado+
                                                          "\n");

                                    }
                                }
                        }
                        break;
                    #endregion
                    #region Liberar Contrato
                    case 6:
                        Console.WriteLine("Digite o ID do Contrato:");
                        int id2= int.Parse(Console.ReadLine());
                        contratoLocacao.Id = id2;
                        foreach (ContratoLocacao contratoLocacaoLiberar in locacoes.Contratos)
                        {
                            if (contratoLocacaoLiberar.Equals(contratoLocacao))
                                contratoLocacaoLiberar.Liberado = true;
                        }
                        break;
                    #endregion
                    #region Consultar Liberados
                    case 7:
                        foreach (ContratoLocacao contratoLocacaoLConsultarLiberados in locacoes.Contratos)
                        {
                            if (contratoLocacaoLConsultarLiberados.Liberado == true)
                                Console.WriteLine("Id:" + contratoLocacaoLConsultarLiberados.Id + 
                                                  "\nDataSaida:" + contratoLocacaoLConsultarLiberados.Saida + 
                                                  "\nDataRetorno:" + contratoLocacaoLConsultarLiberados.Retorno);
                            foreach (TipoEquipamento tipoEquipamentoConsultarLiberado in contratoLocacaoLConsultarLiberados.Itens)
                            {
                                Console.WriteLine("Tipo:" + tipoEquipamentoConsultarLiberado.Nome);
                                foreach (Equipamento equipamentoConsultarLiberados in tipoEquipamentoConsultarLiberado.Itens)
                                {
                                    Console.WriteLine("Id:" + equipamentoConsultarLiberados.Id +
                                                      "\nAvariado:" + equipamentoConsultarLiberados.Avariado + 
                                                      "\nDisponivel:" + equipamentoConsultarLiberados.Locado +
                                                      "\n");
                                }
                            }
                        }
                        break;
                    #endregion
                    #region Devolução
                    case 8:
                        Console.WriteLine("Digite o codigo do Contrato:");
                        int id3 = int.Parse(Console.ReadLine());
                        contratoLocacao.Id = id3;
                        foreach (ContratoLocacao contratoLocacaoDevolucao in locacoes.Contratos)
                        {
                            if (contratoLocacaoDevolucao.Equals(contratoLocacao))
                                contratoLocacao = contratoLocacaoDevolucao;
                                foreach (TipoEquipamento tipoequipamentoDevolucao in contratoLocacao.Itens)
                                {
                                    foreach (TipoEquipamento tipoequipamento2 in equipamentos.Estoque)
                                    {
                                        if (tipoequipamentoDevolucao == tipoequipamento2)
                                            foreach (Equipamento equipamentoDevolucao in tipoequipamentoDevolucao.Itens)
                                            {
                                                foreach (Equipamento e1 in tipoequipamento2.Itens)
                                                {
                                                    if (equipamentoDevolucao == e1)
                                                        equipamentoDevolucao.Locado = false;
                                                }
                                            }
                                    }
                            }
                        }
                        break;
                        #endregion
                }
                Console.WriteLine("Click");
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
        }
    }
}
