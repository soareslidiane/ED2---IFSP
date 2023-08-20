using System;

class Venda
{
    private int qtde;
    private double valor;

    public Venda(int qtde, double valor)
    {
        this.qtde = qtde;
        this.valor = valor;
    }

    public double ValorMedio()
    {
        return valor / qtde;
    }
}

class Vendedor
{
    private int id;
    private string nome;
    private double percComissao;
    private Venda[] asVendas;

    public Vendedor(int id, string nome, double percComissao)
    {
        this.id = id;
        this.nome = nome;
        this.percComissao = percComissao;
        asVendas = new Venda[31];
    }

    public void RegistrarVenda(int dia, Venda venda)
    {
        asVendas[dia - 1] = venda;
    }

    public double ValorVendas()
    {
        double totalVendas = 0;
        foreach (Venda venda in asVendas)
        {
            if (venda != null)
            {
                totalVendas += venda.ValorMedio();
            }
        }
        return totalVendas;
    }

    public double ValorComissao()
    {
        return ValorVendas() * percComissao;
    }
}

class Vendedores
{
    private Vendedor[] osVendedores;
    private int max;
    private int qtde;

    public Vendedores(int max)
    {
        this.max = max;
        osVendedores = new Vendedor[max];
        qtde = 0;
    }

    public bool AddVendedor(Vendedor v)
    {
        if (qtde < max)
        {
            osVendedores[qtde] = v;
            qtde++;
            return true;
        }
        return false;
    }

    public bool DelVendedor(Vendedor v)
    {
        if (!VendedorHasSales(v))
        {
            for (int i = 0; i < qtde; i++)
            {
                if (osVendedores[i] == v)
                {
                    osVendedores[i] = osVendedores[qtde - 1];
                    osVendedores[qtde - 1] = null;
                    qtde--;
                    return true;
                }
            }
        }
        return false;
    }

    public bool VendedorHasSales(Vendedor v)
    {
        foreach (Vendedor vend in osVendedores)
        {
            if (vend == v)
            {
                foreach (Venda venda in vend.AsVendas)
                {
                    if (venda != null)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public Vendedor SearchVendedor(Vendedor v)
    {
        foreach (Vendedor vend in osVendedores)
        {
            if (vend == v)
            {
                return vend;
            }
        }
        return null;
    }

    public double ValorVendas()
    {
        double totalVendas = 0;
        foreach (Vendedor vendedor in osVendedores)
        {
            if (vendedor != null)
            {
                totalVendas += vendedor.ValorVendas();
            }
        }
        return totalVendas;
    }

    public double ValorComissao()
    {
        double totalComissao = 0;
        foreach (Vendedor vendedor in osVendedores)
        {
            if (vendedor != null)
            {
                totalComissao += vendedor.ValorComissao();
            }
        }
        return totalComissao;
    }

    public void ListarVendedores()
    {
        Console.WriteLine("Listagem de Vendedores:");
        foreach (Vendedor vendedor in osVendedores)
        {
            if (vendedor != null)
            {
                Console.WriteLine($"ID: {vendedor.ID}, Nome: {vendedor.Nome}, Valor Total de Vendas: {vendedor.ValorVendas()}, Valor da Comissão: {vendedor.ValorComissao()}");
            }
        }
        Console.WriteLine($"Total Geral de Vendas: {ValorVendas()}, Total Geral de Comissão: {ValorComissao()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vendedores vendedores = new Vendedores(10);
        int option;

        do
        {
            Console.WriteLine("OPÇÕES:\n" +
                "0. Sair\n" +
                "1. Cadastrar vendedor\n" +
                "2. Consultar vendedor\n" +
                "3. Excluir vendedor\n" +
                "4. Registrar venda\n" +
                "5. Listar vendedores");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite o ID, Nome e Percentual de Comissão do Vendedor:");
                    int id = int.Parse(Console.ReadLine());
                    string nome = Console.ReadLine();
                    double percComissao = double.Parse(Console.ReadLine());
                    Vendedor novoVendedor = new Vendedor(id, nome, percComissao);
                    if (vendedores.AddVendedor(novoVendedor))
                    {
                        Console.WriteLine("Vendedor cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Limite máximo de vendedores alcançado.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Digite o ID do Vendedor a ser consultado:");
                    int idConsulta = int.Parse(Console.ReadLine());
                    Vendedor vendedorConsulta = new Vendedor(idConsulta, "", 0);
                    Vendedor vendedorEncontrado = vendedores.SearchVendedor(vendedorConsulta);
                    if (vendedorEncontrado != null)
                    {
                        Console.WriteLine($"ID: {vendedorEncontrado.ID}, Nome: {vendedorEncontrado.Nome}");
                        Console.WriteLine($"Valor Total de Vendas: {vendedorEncontrado.ValorVendas()}");
                        Console.WriteLine($"Valor da Comissão: {vendedorEncontrado.ValorComissao()}");
                        Console.WriteLine("Valores Médios das Vendas Diárias:");
                        for (int i = 0; i < vendedorEncontrado.AsVendas.Length; i++)
                        {
                            if (vendedorEncontrado.AsVendas[i] != null)
                            {
                                Console.WriteLine($"Dia {i + 1}: {vendedorEncontrado.AsVendas[i].ValorMedio()}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vendedor não encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Digite o ID do Vendedor a ser excluído:");
                    int idExclusao = int.Parse(Console.ReadLine());
                    Vendedor vendedorExclusao = new Vendedor(idExclusao, "", 0);
                    if (vendedores.DelVendedor(vendedorExclusao))
                    {
                        Console.WriteLine("Vendedor excluído com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Vendedor não encontrado ou possui vendas associadas.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Digite o ID do Vendedor e o Dia da Venda:");
                    int idVenda = int.Parse(Console.ReadLine());
                    int diaVenda = int.Parse(Console.ReadLine());
                    Vendedor vendedorVenda = new Vendedor(idVenda, "", 0);
                    Vendedor vendedorParaVenda = vendedores.SearchVendedor(vendedorVenda);
                    if (vendedorParaVenda != null)
                    {
                        Console.WriteLine("Digite a Quantidade de Vendas e o Valor Total da Venda:");
                        int qtdeVendas = int.Parse(Console.ReadLine());
                        double valorVenda = double.Parse(Console.ReadLine());
                        Venda novaVenda = new Venda(qtdeVendas, valorVenda);
                        vendedorParaVenda.RegistrarVenda(diaVenda - 1, novaVenda);
                        Console.WriteLine("Venda registrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Vendedor não encontrado.");
                    }
                    break;

                case 5:
                    vendedores.ListarVendedores();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (option != 0);
    }
}
