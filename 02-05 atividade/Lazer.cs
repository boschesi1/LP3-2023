namespace SP3075443;
public class Lazer:Gastos
{
    public Lazer(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margem = (ValorAcumulado * 0.03m);
        EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Lazer");
    }
}