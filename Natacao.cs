namespace SP3075443;

public class Natacao:Gastos
{
    private readonly decimal _bonusNatacao = 50m;
    public Natacao(string Cliente, decimal valorInicial, decimal bonusnatacao = 50) : base(Cliente, valorInicial)
    => _bonusNatacao = bonusnatacao;
    public override void ExecutarTransacaoFimdeMes()
    {
    decimal margem = (ValorAcumulado * 0.03m);
    EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Natação");
    if (_bonusNatacao != 0)
    {
        EfetuarTransacao(-_bonusNatacao, DateTime.Now, "Bonus Natação");
    }
    }
}