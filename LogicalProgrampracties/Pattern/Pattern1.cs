using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Pattern
{
    public class Pattern1
    {
      
            //*****
            //*****
            //*****
            //*****
            //*****
            public void pattern1()
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
            }

        public void Pattern2()
        {
            //*
            //**
            //***
            //****
            //*****
            for (int i = 1; i <= 5; i++)
            {

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void pattern3()
        {
            //1
            //12
            //123
            //1234
            //12345

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void pattern4()
        {



            //1
            //22
            //333
            //4444
            //55555

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public void Pattern5()
        {
            //*****
            //****
            //***
            //**
            //*

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void pattern6()
        {

            //    *
            //   **
            //  ***
            // ****
            //*****
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");

                for (int k = i - 1; k < 5; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
