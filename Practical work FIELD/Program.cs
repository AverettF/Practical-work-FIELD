using System;

namespace Practical_work_FIELD
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldWidth = 2; //ширина поля 
            int fieldHeight = 2;//высота поля 
            int indentUp = 4;   //отступ сверху
            int indentLeft = 4;// отступ слева 
            int cellHeight = 4;//высота ячейки
            int cellWidth = 4;//ширина ячейки
            int selectedCellX = 1;
            int selectedCellY = 1;

            PrintIndentUp(indentUp);
            PrintLine("┌", "┬", "┐", "─", fieldWidth, cellWidth, indentLeft);

            for (int y = 1; y <= fieldHeight; y++)// кол-во всех ячеек по Y
            {
                for (int x = 1; x <= cellHeight; x++) //высота одной ячейки
                {
                    for (int i=1;i<= fieldWidth;i++) 
                    {
                        PrintLine("│", "│", "│", " ", fieldWidth, cellWidth, indentLeft);
                    }
                }

                if (y != fieldHeight)
                    PrintLine("├", "┼", "┤", "─", fieldWidth, cellWidth, indentLeft);
                else
                    PrintLine("└", "┴", "┘", "─", fieldWidth, cellWidth, indentLeft);
            }

        }

        static void PrintIndentUp(int indentUp)
        {
            for (int i = 0; i < indentUp; i++)
            {
                Console.WriteLine();
            }
        }

        static void PrintLine(string left, string top, string ringht,string middle, int fieldWidth, int cellWidth,int indentLeft)
        {
            PrintIndentLeft(indentLeft);

            Console.Write(left);
            for (int i = 1; i <= fieldWidth; i++)
            {
                for (int j = 1; j <= cellWidth; j++)
                {
                    Console.Write(middle);
                }

                if(i!= fieldWidth)                
                    Console.Write(top);                
                else                
                    Console.WriteLine(ringht);
              
            }
        }

        static void PrintIndentLeft(int indentLeft)
        {
            for (int i = 0; i < indentLeft; i++)
            {
                Console.Write(" ");
            }
        }

        //static void PrintColorCells(int cellWidth, int indentLeft)
        //{
        //    Console.Write("│");
        //    for (int i = 0; i < cellWidth; i++)
        //    {
        //        Console.BackgroundColor = ConsoleColor.White;
        //        Console.Write(" ");
        //    }
        //}
        //if (selectedCellX == J || selectedCellY == k)
        //    PrintCells(cellWidth, indentLeft);
        //else
        //    PrintIndentLeft(indentLeft);
    }
}
