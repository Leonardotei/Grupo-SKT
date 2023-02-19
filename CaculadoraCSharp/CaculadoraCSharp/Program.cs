using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp 
{

    class Calculator 
    {
        #region [Gets e Sets]
        int num1;
        int num2;

        public void SetNum1(int num) 
        {
            num1 = num;
        }

        public int GetNum1() 
        {
            return num1;
        }

        public void SetNum2(int num) 
        {
            num2 = num;
        }

        public int GetNum2() 
        {
            return num2;
        }
        #endregion

        #region [Operacoes]
        //Soma
        public int Somar() 
        {
            return num1 + num2;
        }

        //Subtracao
        public int Subtrair() 
        {
            return num1 - num2;
        }
        #endregion

    }

    internal class Program 
    {

        static void Main(string[] args) 
        {
            int x = 20, y = 10, resp = 0;

            Calculator calculator = new Calculator();
            calculator.SetNum1(x);
            calculator.SetNum2(y);

            Console.WriteLine("Resultados:\n");

            //Soma
            resp = calculator.Somar();
            Console.WriteLine("{0} + {1} = {2}", x, y, resp);

            //Subtracao
            resp = calculator.Subtrair();
            Console.WriteLine("{0} - {1} = {2}", x, y, resp);
        }
    }
}