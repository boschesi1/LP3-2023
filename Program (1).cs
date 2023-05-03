using SP3075443;

var gasto = new Gastos ("Lorrany", 0);


var laser = new Lazer("Lorrany", 0);
laser.EfetuarTransacao(20, DateTime.Now, "Cinema");
laser.EfetuarTransacao(50, DateTime.Now, "Parque");
laser.ExecutarTransacaoFimdeMes();
Console.WriteLine(laser.ObterHistoricodeConta()); 

var educacao = new Educacao("Lorrany", 0);

educacao.EfetuarTransacao(100, DateTime.Now, "Linguagem C#");
educacao.EfetuarTransacao(50, DateTime.Now, "Linguagem Java");
educacao.EfetuarTransacao(250, DateTime.Now, "HTML");
educacao.ExecutarTransacaoFimdeMes();
Console.WriteLine(educacao.ObterHistoricodeConta());

var natacao = new Natacao("Lorrany", 0);

natacao.EfetuarTransacao(200, DateTime.Now, "Trage de banho");
natacao.ExecutarTransacaoFimdeMes();
Console.WriteLine(natacao.ObterHistoricodeConta());

var danca = new Danca("Lorrany", 0);

danca.EfetuarTransacao(1000, DateTime.Now, "Roupa confortável");
danca.ExecutarTransacaoFimdeMes();
Console.WriteLine(danca.ObterHistoricodeConta());