using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diferençaDatas
{
    internal class Data
    {
        DateTime primeiraData;
        DateTime segundaData;

       public Data inserirData()
        {
            Data datas = new Data();
            string digitado = "";
            Console.Write("Escreva a primeira Data: ");
            digitado=Console.ReadLine();
            DateTime data=DateTime.Parse(digitado);
            datas.primeiraData = data;
            Console.Write("Escreva a segunda Data: ");
            digitado = Console.ReadLine();
            DateTime segundaData=DateTime.Parse(digitado);
            datas.segundaData = segundaData;
            return datas;
        }
        public void validarData()
        {

            Data data = inserirData();
            TimeSpan interval = data.primeiraData - data.segundaData;
           
        /*    Console.WriteLine(interval.TotalDays);
            int primeiroDia = data.primeiraData.Day;
            int primeiroMes = data.primeiraData.Month;
            int primeiroAno=data.primeiraData.Year;

            int segundaData=data.segundaData.Day;
            int segundoMes = data.segundaData.Month;
            int segundoAno = data.segundaData.Year;

            decimal totalDias = primeiroDia - segundaData;
            decimal  totalMes=primeiroMes - segundoMes;
            decimal totalAno=primeiroAno - segundoAno;
         
            if (totalDias > 0)
            {
                if (totalDias % 7 == 0)
                {
                    mostrar = totalDias / 7;
                    Console.WriteLine($"{mostrar} semanas");
                }
                else
                {
                    Console.WriteLine($"{totalDias} Dias");
                }

            }
           */
           



            int dias = Convert.ToInt32(interval.Days);
            
            decimal total = 0;
            if (dias >= 365)
            {
                total = dias / 365;
                Console.Write($"{Math.Floor(total)} anos atrás.");
            }
            if (dias < 365)
            {
                decimal totalMes = dias / 30;
                if (totalMes % 31 == 0)
                {
                    Console.Write($"{totalMes} Meses atrás");
                }             
                else
                {
                    Console.Write($"{totalMes} Meses atrás");
                }
                if (totalMes < 1)
                {
                   decimal totalDays = totalMes / 30;
                    if (totalDays % 7 != 1)
                    {
                        Console.Write($"{totalDays} dias atrás");
                    }
                    else
                    {
                         totalDays = totalDays / 7;
                        Console.Write($"{totalDays} semanas atrás");
                        
                    }

                }
                 

            }
            if (dias < 30)
            {
              int  totalDays = dias;
                if (totalDays % 7 != 0)
                {
                    Console.Write($"{totalDays} dias atrás");
                }
                else
                {
                    totalDays = totalDays / 7;
                    Console.Write($"{totalDays} semanas atrás");

                }
            }
        }

    }
}
