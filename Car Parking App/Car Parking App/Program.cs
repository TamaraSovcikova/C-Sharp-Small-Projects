using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_Parking_App
{
    internal class Program
    {
        static int maxColumn = 10;
        static int maxRow = 6;
        static string[,] CarParkGrid = new string[maxColumn, maxRow];
        static string fileName = "CarPark.txt";

        static void Main(string[] args)
        {

            int menuChoice = 0;
            SetGrid();
            ReadFromFile();
            ShowGrid();
            do
            {
                menuChoice = MenuChoice();

                switch (menuChoice)
                {
                    case 1:
                        ShowGrid();
                        break;
                    case 2:
                        ParkCar();
                        break;
                    case 3:
                        RemoveCar02();
                        break;
                    case 4:
                        Exit();
                        break;

                }
            }
            while (menuChoice != 4);

            Console.ReadKey();
        }
        static void SetGrid()
        {
            for (int i = 0; i < maxColumn; i++)
            {
                for (int j = 0; j < maxRow; j++)
                {
                    CarParkGrid[i, j] = "0";
                }
            }
        }
        static void ShowGrid()
        {
            Console.WriteLine("--- O is a free spot and X is a taken one ---");

            for (int i = 0; i < maxColumn; i++)
            {
                for (int j = 0; j < maxRow; j++)
                {
                    if (CarParkGrid[i, j] != "0")
                        Console.Write("X");
                    else
                        Console.Write(CarParkGrid[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

        }
        static void ParkCar()
        {
            Console.WriteLine("Please enter your registration number");
            string registNum = Console.ReadLine();
            Console.WriteLine("Now enter the row and column space you want to occupy");

            int row = int.Parse(Console.ReadLine()) - 1;

            if (row > maxColumn || row < 0)
            {
                Console.WriteLine("Invalid Row");
                return;
            }

            int column = int.Parse(Console.ReadLine()) - 1;
            if (column > maxRow || column < 0)
            {
                Console.WriteLine("Invalid Column");
                return;
            }

            //CarParkGrid[row, column] = "X";
            if (CarParkGrid[row, column] != "0")
            {
                Console.WriteLine("-------> This spot is already taken <---------\n");
                return;
            }

            CarParkGrid[row, column] = registNum;
            WriteToFile();
            ShowGrid();
            Console.WriteLine("\n");

        }
        static int MenuChoice()
        {
            Console.WriteLine("Welcome to the car park");
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1; Show Grid");
            Console.WriteLine("2; Park a Car");
            Console.WriteLine("3; Remove a Parked Car");
            Console.WriteLine("4; Exit");
            Console.WriteLine("------------------------");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            return choice;
        }
        static void Exit()
        {
            Console.WriteLine("Thank you for using CarPark, have a lovely rest of the day");
        }
        static void RemoveCar02()
        {
            Console.WriteLine("Please enther your registration number: ");
            string registNumE = Console.ReadLine();


            for (int i = 0; i < maxColumn; i++)
            {
                for (int j = 0; j < maxRow; j++)
                {
                    if (CarParkGrid[i, j] == registNumE)
                    {
                        Console.WriteLine("We have located you car, you may now leave");
                        CarParkGrid[i, j] = registNumE;
                        CarParkGrid[i, j] = "0";

                        Console.WriteLine("\n");
                        WriteToFile();
                        ShowGrid();
                        Console.WriteLine("\n");

                        return;

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("This car in not in our possesion.");

        }
        static void WriteToFile()
        {
            Console.WriteLine("Writing to file...");
            string[] lines = new string[maxRow];

            for (int i = 0; i < maxRow; i++)
            {
                string line = "";
                for (int j = 0; j < maxColumn; j++)
                {
                    line = line + CarParkGrid[j, i] + "\t";
                }
                lines[i] = line;
            }
            Console.WriteLine("\n");

            File.WriteAllLines(fileName, lines);
            Console.WriteLine("Succesfully saved!");
        }
        static void ReadFromFile()
        {
            Console.WriteLine("Reading from file...");

            if (!File.Exists(fileName))
            {
                return;
            }

            string[] dataFile = File.ReadAllLines(fileName);
            for (int i = 0; i < dataFile.GetLength(0); i++)
            {
                string[] cars = dataFile[i].Split('\t');
                // {"0","0",....}
                for (int j = 0; j < cars.Length && j < maxColumn; j++)
                    CarParkGrid[j, i] = cars[j];
            }

            Console.WriteLine("\n");


        }

    }
}
