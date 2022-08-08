using ExemploEnumsDescricao_ConsoleApp;

Cores corEscolhida = Cores.Azul;
if (corEscolhida == Cores.Azul)
{
    //Executa comando 1 
}
else if (corEscolhida == Cores.Verde)
{
    //Executa comando 2
}

Console.WriteLine(Cores.Azul.ToString());
Console.WriteLine(corEscolhida.ToString());

Console.WriteLine("Sem a descrição customizada: " + Meses.Marco.ToString());
Console.WriteLine("Com a descrição customizada: " + EnumExtensionHelper.GetDescription(Meses.Marco));

Console.Read();
