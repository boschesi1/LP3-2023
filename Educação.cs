namespace SP3075443;
public class Educacao:Gastos
{
    public Educacao(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margem = (ValorAcumulado * 0.04m);
        EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Educação");
    }
}