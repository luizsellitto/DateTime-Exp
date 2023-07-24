using Microsoft.VisualBasic;

DateTime data1 = new DateTime(2022, 07, 24);
Console.WriteLine(data1);

DateTime data2 = new DateTime(2023, 07, 24, 15, 30, 50);
Console.WriteLine(data2);

Console.WriteLine(DateTime.Now);                                //Horário de agora
Console.WriteLine(DateTime.Today);                              //Horário do dia de Hoje, só que meia noite
Console.WriteLine(DateTime.UtcNow);                             //Horário de Greenwich


Console.WriteLine(data2.Year);                                  //Retorna o ano(pode ser convertido em int...)
Console.WriteLine(data2.Month);                                 //Retorna o total de mêses(pode ser convertido em int...)
Console.WriteLine(data2.DayOfWeek);                             //Retorna o dia da semana(pode ser convertido em string...)
Console.WriteLine(data2.DayOfYear);                             //Retorna o dia do ano(pode ser convertido em int...)

int diaAno = data2.DayOfYear;

DateTime data3 = data2.AddDays(5);                              //Adiciona dias a uma data, FUnciona com Month, Year..

DateTime data4 = new DateTime(2006, 09, 26, 08, 15, 30);
TimeSpan data5 = (DateTime.Now).Subtract(data4);                //Subtrai a data

Console.WriteLine(data5.Days);                                  //Retorna os dias totais

TimeSpan a = new TimeSpan(6145, 00, 00, 00);             //Timespan - usa dias, horas, minutos e segundos
DateTime novaData = DateTime.Now.Subtract(a);            //Usando os dias para ssaber a minha data de Aniversário

Console.WriteLine(novaData);

Console.WriteLine("Informe a data de nascimento: ");
DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine(dataNasc.DayOfWeek);                          //Descobre o dia da semana que nasceu


DateTime d1 = new DateTime(2023, 07, 24);
DateTime d2 = new DateTime(2023, 07, 24);
// 0 - datas iguais
// -1 - a primeira data é anterior a segunda
// 1 - a primeira data é posterior a segunda
Console.WriteLine(d1.CompareTo(d2));                            //Método não-estático
int retornoCOmparaDatas = DateTime.Compare(d1,d2);                     //Método estático (não dá para usar referente a um objeto

if (retornoCOmparaDatas == 0)
{
    Console.WriteLine("São datas iguais");
}
else if(retornoCOmparaDatas < 0)
{
    Console.WriteLine($"A data {d1} é anterior a {d2}");
}
else
{
    Console.WriteLine($"A data {d1} é posterior a {d2}");
}


DateTime data6 = DateTime.Parse("26/09/2006");                   //Usa do .Parse para poder trocar a ordem do Ano, Mês e Dia
Console.WriteLine(data6);