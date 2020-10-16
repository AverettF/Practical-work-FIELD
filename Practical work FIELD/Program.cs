using System;

namespace Practical_work_FIELD
{
    class Program
    {
        static void Main(string[] args)
        {

            //┌ ┬ ┐
            int fieldWidth = 3; //ширина поля 
            int fieldHeight = 2;//высота поля 
            int indentUp = 5;   //отступ сверху
            int indentLeft = 4;// отступ слева 
            int cellHeight = 2;//высота ячейки
            int cellWidth = 5;//ширина ячейки

            PrintIndentUp(indentUp);
            PrintUpLine(fieldWidth, cellWidth, indentLeft);

            for (int i = 0; i < fieldHeight; i++)// кол-во всех ячеек 
            {
                for (int J = 0; J < cellHeight; J++) //высота одно ячейки
                {
                    PrintIndentLeft(indentLeft);
                    for (int k = 0; k < fieldWidth; k++) //длина одно линии
                    {
                        PrintCells(cellWidth, indentLeft);
                    }
                    Console.WriteLine("│");
                }
                if (i != fieldHeight-1)
                    PrintCentralLine(fieldWidth, cellWidth, indentLeft);
                else
                    PrintEndLine(fieldWidth, cellWidth, indentLeft);
            }

        }

        static void PrintIndentUp(int indentUp)
        {
            for (int i = 0; i < indentUp; i++)
            {
                Console.WriteLine();
            }
        }

        static void PrintUpLine(int fieldWidth, int cellWidth,int indentLeft)
        {
            PrintIndentLeft(indentLeft);

            Console.Write("┌");
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < cellWidth; j++)
                {
                    Console.Write("─");
                }

                if(i!= fieldWidth-1)                
                    Console.Write("┬");                
                else                
                    Console.WriteLine("┐");
              
            }
        }

        static void PrintCells(int cellWidth, int indentLeft)
        {
            Console.Write("│");
            for (int i = 0; i < cellWidth; i++)
            {
                Console.Write(" ");
            }
        }

        static void PrintIndentLeft(int indentLeft)
        {
            for (int i = 0; i < indentLeft; i++)
            {
                Console.Write(" ");
            }
        }

        static void PrintCentralLine(int fieldWidth, int cellWidth, int indentLeft)
        {
            PrintIndentLeft(indentLeft);

            Console.Write("├");
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < cellWidth; j++)
                {
                    Console.Write("─");
                }

                if (i != fieldWidth - 1)
                {
                    Console.Write("┼");
                }
                else
                {
                    Console.WriteLine("┤");

                }
            }
        }

        static void PrintEndLine(int fieldWidth, int cellWidth, int indentLeft)
        {                        
            PrintIndentLeft(indentLeft);

            Console.Write("└");
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < cellWidth; j++)
                {
                    Console.Write("─");
                }

                if (i != fieldWidth - 1)
                {
                    Console.Write("┴");
                }
                else
                {
                    Console.WriteLine("┘");

                }
            }           
        }
    }
}
