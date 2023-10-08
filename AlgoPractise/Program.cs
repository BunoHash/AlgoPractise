using System;
using AlgoPractise_Design_Principles;
using AlgoPractise.NewFolder;

using DP.Creational.Builder;
using DP.Creational.Factory;
using DP.Creational.Prototype;
using DP.Creational.Singleton;
using AlgoPractise._Design_Principles;
using AlgoPractise.Algorithm_DS;
using AlgoPractise._02._DesignPatterns.Behavioural.Momento;
using AlgoPractise._02._DesignPatterns.Behavioural.State;
using System.IO;
using AlgoPractise._04._AlgorithmDS.Sorting.Problems;
using AlgoPractise._05._Problem_Solving;
using BasicInterfaces;
using AlgoPractise._03._CSharp.Advance_cSharp;
using AlgoPractise._04._AlgorithmDS.CondinInterview_Subeen;
using AlgoPractise._02._DesignPatterns.ObserverPattern;

namespace AlgoPractise
{

    class Program
    {
        static void Main(string[] args)
        {
            //MaxDistance.FindDistancse();
            //MaxSumContiguousSubarray.FindMaxSum();
            //SpiralMatrix.PrintSpiral();
            //SortedArrayDuplicate.Run();
            // SortItUp.Solve();
            // TestDelegate del = new TestDelegate();
            // del.Run();            

            //TestManager.RunProcess();

            //// Searching:
            //BinarySearch.StartBiranySearchProcess();

            //// Sorting: 

            // InsertionSort.StartInsertionSortProcess();
            // BubbleSort.StartBubbleSortProcess();
            // SelectionSort.StartSelectionSortProcess();
            //MargeSort.StartMargeSortProcess();
            // QuickSort.StartQuickSortProcess();


            ////Pattern:

            // BuilderExecuter.Run();
            // FluidBuidlerExecuter.Run();
            // ExecuteFacadeBuilder.Run();
            // FirstTestSuite.PersonTest();
            // ExecuteAbsfactory.Run();
            // ExecuteFactory.Run();
            // ExecutePrototype.Run();
            // ExecuteSingleton.Run();
            // MonoState.Run();
            // Singleton.Test();


            //ParanthesisStack.StackProcess();

            //SOLID ;
            //Demo.Jain();

            //Misc
            //SpiralArrayTravarse.Process();
            //ProcessMomento.test();
            //StatePattern.test();
            //var tx = "this is a text 4";
            //var path = "D:/SAYED_NEST/interview/doo.txt";
            //File.Create(path);


            //var INFO = new FileInfo(path);
            //var ykh = INFO.AppendText();
            //ykh.WriteLine("new line 5");
            //ykh.Close();


            ///// OOP:
            //Document doc = new Document("PDF1");
            //doc.Load();
            //doc.Save();

            //Inheritance.Show();

            // AsyncProgramming.AsyncWithProgress();
            // AsyncProgramming.UseAsyncAwaitWithCancallationToken();
            //HotelBookingsPossible.IsPossible();
            Observer.Run();
            Console.ReadLine();





        }
    }
 }
