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
            DateTime data=DateTime.Parse(digitado);
            datas.primeiraData = DateTime.Now;
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

            int dias = Convert.ToInt32(interval.TotalDays);
            
            decimal total = 0;
            if (dias >= 365)
            {
                total = dias / 365;
                Console.Write($"{Math.Floor(total)} anos atrás.");
            }
            if (dias >= 30 && dias<=365)
            {                                   
                int totalMes = dias/30;              
                  Console.Write($"{totalMes} Meses atrás ");
                  int totalConta = totalMes * 30;
                  int totalDays = dias - totalConta;
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
