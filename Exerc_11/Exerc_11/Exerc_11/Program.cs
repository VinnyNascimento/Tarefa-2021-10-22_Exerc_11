using System;

namespace Exerc_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra o seu IMC");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o peso (em kg): ");
            s.setNum1(double.Parse(Console.ReadLine()));

            Console.Write("Informe a altura (em metros): ");
            s.setNum2(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("Com o peso em kg de {0} com a Altura em metros de {1}, o IMC é: {2}", s.getNum1(), s.getNum2(), s.getResultado());
            #endregion
        }
    }
}