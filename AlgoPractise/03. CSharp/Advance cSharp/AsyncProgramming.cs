using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using static AlgoPractise._03._CSharp.Advance_cSharp.AsyncProgramming;

namespace AlgoPractise._03._CSharp.Advance_cSharp
{
    internal static class AsyncProgramming
    {
        public delegate Task<string> AsyncDetegatedTask();
        private static async Task<string> SayMyName() => "Hisenbarg";
        private static async Task<string> SayYourName() => "Hisenbarg";
        private static async Task<string> RepeatMyName(string name) => $"My name is {name}";

        private static IList<int> GetFactors(int inpput)
        {
            IList<int> result = new List<int>();
            for (int i = 1; i * i < inpput; i++)
            {
                if (inpput % i == 0)
                {
                    result.Add(i);
                    result.Add(inpput / i);
                }
            }
            return result;

        }

        private static void ProcessData()
        {
            Console.WriteLine("Task Started");
            Thread.Sleep(5000);
            Console.WriteLine("Task Finished");

        }

        private async static Task<string> GetLearningWebsite(string url, CancellationTokenSource cts)
        {
            // Always use using block/ dispose source, when using token: to stop memory lekage
            // Beacuse cancallation token implements Idesposable Interface 
            try
            {
                Console.WriteLine("Getting async");
                var client = new HttpClient();
                var response = await client.GetStringAsync(url, cts.Token);

                return (response);
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                cts.Dispose();
            }
            

        }
        private async static Task ProcessDataWithSteps()
        {

        }

        public static void TestAsyncBasics() 
        {
            Console.WriteLine("Let's start");
            var process = new Task(ProcessData);
            //var process1 = new Task(RepeatMyName("Sayed"));
            AsyncDetegatedTask taskDelegate = SayMyName;
            taskDelegate += SayYourName;


            // Starting a task:


            process.Start();
            Task.Run(ProcessData);
            Task<string> dataTask = Task.Run(SayMyName);
            taskDelegate.Invoke();


            // Frezzing main thred, until the task is done. Used if the next codes are dependent on it : Bad practice

            process.Wait();
            string result = dataTask.Result;


            // Continuation: used to unblock thread for a dependent task also. Work like callback
            // Only execute when the revious task is complete , but don't hault the thred

            dataTask.ContinueWith(callbacktask =>
            {
                Console.WriteLine(callbacktask.Result.ToString());
            }, TaskContinuationOptions.NotOnCanceled);


            Console.WriteLine("Ready to take user input");

            
            Console.ReadLine();
        
        }        
        
        // its not recommended to run async operation like this, thankfully we have the await wrapper now.
        public static void RunContinuation() {
            
            Console.WriteLine("Process Started");

            Task<IList<int>> factores = Task.Run(() => GetFactors(34));

            factores.ContinueWith(output =>
            {
                foreach (var factor in output.Result)
                {
                    Console.WriteLine(factor);
                }
            });
            Console.WriteLine("Process ended");
            Console.ReadKey();
           
        
        }

        public static void UseAsyncAwaitWithCancallationToken()
        {
            Console.WriteLine("Starting Async");
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(6000);
            var page_content = GetLearningWebsite("https://www.linkedinlearning.com",cts);
            Console.WriteLine(page_content);
            
            Console.WriteLine("Free for user input");
        }

        public static void AsyncWithProgress()
        {
            Console.WriteLine("Main method caller started");
            string[] depts = { "IT", "HR", "SALES", "MARKETING" };

            IProgress<string> progress = new Progress<string>(name => Console.WriteLine($"Processin dept: {name}"));
            Task task = ProcessProgress(depts, progress);


            Console.WriteLine("Ready for user input");

        }

        private async static Task ProcessProgress(string[] depts, IProgress<string> progress)
        {
            foreach(var dept in depts)
            {
                progress.Report(dept);
                await Task.Delay(1000);
            }
            Console.WriteLine("Done Processing Data");
            
        }
    }
}
