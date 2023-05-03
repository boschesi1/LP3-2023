namespace SP3075443;

public class Gastos{
    public string Cliente { get; set;}
    public decimal ValorAcumulado
    {
    get
    {
        decimal saldo = 0m;
        foreach (var item in todasTransacoes)
        {
            saldo += item.Valor;
        }

        return saldo;
    }
    }
    public Gastos(string nome, decimal valorInicial)
    {
        this.Cliente = nome;
        EfetuarTransacao(valorInicial, DateTime.Now, "Valor Inicial");
    }
    private List<Transacao> todasTransacoes = new List<Transacao>();
    public void EfetuarTransacao(decimal valor, DateTime data, string descricao)
    {
        var saque = new Transacao(valor, data, descricao);
        todasTransacoes.Add(saque);
    }

    public string ObterHistoricodeConta()
    {
    var relatorio = new System.Text.StringBuilder();

    decimal saldo = 0m;
    relatorio.AppendLine("Data            Valor   Valor Acumulado   Descrição");
    foreach (var item in todasTransacoes)
    {
        saldo += item.Valor;
        relatorio.AppendLine($"{item.Data.ToShortDateString()} {item.Valor, 10}        {saldo, 10}   {item.Descricao}");
    }

    return relatorio.ToString();
    }
    public virtual void ExecutarTransacaoFimdeMes() { }
}