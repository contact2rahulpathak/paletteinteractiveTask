using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;

namespace ConsoleAppCore
{
   public class Calculator

    {
        JsonWriter writer;
        public Calculator()
        {

            string path = @"F:\Pracjuly2020\Assignment\ConsoleAppCore\bin\Debug\netcoreapp3.1\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    Trace.Listeners.Add(new TextWriterTraceListener(sw));
                    Trace.AutoFlush = true;
                    Trace.WriteLine("Starting Calculator Log");
                    Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
                }
            }

            //string path1 = @"F:\Pracjuly2020\Assignment\ConsoleAppCore\bin\Debug\netcoreapp3.1\calculatorlog.json";
            //if (!File.Exists(path1))
            //{
            //    // Create a file to write to.
            //    using (StreamWriter sw = File.CreateText(path1))
            //    {
            //       // StreamWriter logFile = File.CreateText(sw);
            //        //logFile.AutoFlush = true;
            //        writer = new JsonTextWriter(sw);
            //        writer.Formatting = Formatting.Indented;
            //        writer.WriteStartObject();
            //        writer.WritePropertyName("Operations");
            //        writer.WriteStartArray();
            //    }
            //}

            //StreamWriter logFile = File.CreateText("calculator.log");
            //Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            //Trace.AutoFlush = true;
            //Trace.WriteLine("Starting Calculator Log");
            //Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));



            using (StreamWriter logFile = File.CreateText("calculatorlog.json"))
            {
                logFile.AutoFlush = true;
                writer = new JsonTextWriter(logFile);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                writer.WritePropertyName("Operations");
                writer.WriteStartArray();
            }


        }
        public  int DoOperation(int num1, int num2, string op)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;

                int result = 0;// Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
                writer.WritePropertyName("Operations");
                writer.WriteStartArray();
                writer.WriteStartObject();
                writer.WritePropertyName("Operand1");
                writer.WriteValue(num1);
                writer.WritePropertyName("Operand2");
                writer.WriteValue(num2);
                writer.WritePropertyName("Operation");
                CalculatorService cs = new CalculatorService();
                // Use a switch statement to do the math.
                switch (op)
                {
                    case "a":
                        string str1 = "Addition";
                        result = cs.Add(num1, num2);
                        string str2 = String.Format("{0} + {1} = {2}", num1, num2, result);
                        Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
                        Log(str2, str1);
                        
                         writer.WriteValue("Add");
                        result = num1 + num2;
                        break;
                    case "s":
                        result = cs.Subtract(num1, num2);
                        string str3 = String.Format("{0} + {1} = {2}", num1, num2, result);
                        Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
                        System.IO.File.AppendAllText("MyTest.txt", str3 + Environment.NewLine);
                        writer.WriteValue("Subtract");
                        result = num1 - num2;
                        break;
                    case "m":
                        result = cs.Multiply(num1, num2);
                        string str4 = String.Format("{0} + {1} = {2}", num1, num2, result);
                        Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
                        System.IO.File.AppendAllText("MyTest.txt", str4 + Environment.NewLine);
                        writer.WriteValue("Multiply");
                        result = num1 * num2;
                        break;
                    case "d":
                        // Ask the user to enter a non-zero divisor.
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                       // Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                       // break;

                        if (num2 != 0)
                        {
                            result = cs.Divide(num1, num2);
                            string str5 = String.Format("{0} + {1} = {2}", num1, num2, result);
                            Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
                            System.IO.File.AppendAllText("MyTest.txt", str5 + Environment.NewLine);
                            writer.WriteValue("Divide");
                            result = num1 / num2;
                        }

                        break;
                    // Return text for an incorrect option entry.
                    default:
                        break;
                }
                writer.WritePropertyName("Result");
                writer.WriteValue(result);
                
                writer.WriteEndObject();
                writer.WriteEnd();
                // And call to close the JSON writer before return
                // Calculator c = new Calculator();
                //c.Finish();
                Console.WriteLine(sb);
                return result;
            }
        }
        public  void Log(string str, string op )
        {
            string path = @"F:\Pracjuly2020\Assignment\ConsoleAppCore\bin\Debug\netcoreapp3.1\MyTest.txt";
          
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Trace.Listeners.Add(new TextWriterTraceListener(sw));
                    Trace.AutoFlush = true;
                    Trace.WriteLine('"' + op + '"');
                    Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
                    Trace.WriteLine('"' + str + '"');
                
                }
            }
           
        }
        public void Finish()
        {

            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }

}
