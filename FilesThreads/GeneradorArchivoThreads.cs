using Newtonsoft.Json;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace FilesThreads
{
    class GeneradorArchivoThreads : IGenerador
    {

        public void ArchivoTxt()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Stopwatch tiempoTxt = new Stopwatch();
            tiempoTxt.Start();
            StreamWriter TXT = File.AppendText("txtThreads.txt");
            TXT.WriteLine("                                  TXT CON HILOS:                                  \n");
            for (int i = 1; i <= 100; i++)
            {
                if (i == 1)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoTxt.Elapsed.TotalSeconds} s.");
                    TXT.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoTxt.Elapsed.TotalSeconds} s.\n");
                }
                if (i == 2 || i < 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoTxt.Elapsed.TotalSeconds} s.");
                    TXT.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoTxt.Elapsed.TotalSeconds} s.\n");
                }
                else if (i == 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoTxt.Elapsed.TotalSeconds} s.");
                    TXT.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoTxt.Elapsed.TotalSeconds} s.\n");
                }
                else
                {
                    Console.WriteLine("TXT");
                }
                Thread.Sleep(100);
            }
            TXT.Close();
            tiempoTxt.Stop(); // Detener la medición de tiempo.
            Console.WriteLine($"\nTXT GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoTxt.Elapsed.TotalSeconds} s.!!!\n");
            Console.ResetColor();
        }

        public void ArchivoExcel()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Stopwatch tiempoExcel = new Stopwatch();
            tiempoExcel.Start();
            SLDocument slDocument = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("EXCEL CON HILOS:", typeof(string));

            for (int i = 1; i <= 100; i++)
            {
                if (i == 1)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoExcel.Elapsed.TotalSeconds} s.");
                    dt.Rows.Add($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoExcel.Elapsed.TotalSeconds} s.\n");
                }
                if (i == 2 || i < 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoExcel.Elapsed.TotalSeconds} s.");
                    dt.Rows.Add($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoExcel.Elapsed.TotalSeconds} s.\n");
                }
                else if (i == 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoExcel.Elapsed.TotalSeconds} s.");
                    dt.Rows.Add($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoExcel.Elapsed.TotalSeconds} s.\n");
                }
                else
                {
                    Console.WriteLine("EXCEL");
                }
                Thread.Sleep(100);
            }
            slDocument.ImportDataTable(1, 1, dt, true);
            slDocument.SaveAs("excelThreads.xlsx");
            tiempoExcel.Stop();
            Console.WriteLine($"\nEXCEL GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoExcel.Elapsed.TotalSeconds} s.!!!\n");
            Console.ResetColor();
        }

        public void ArchivoJson()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Stopwatch tiempoJson = new Stopwatch();
            tiempoJson.Start();
            string pathFile = "jsonThreads.json";
            string almacena;
            string vJson;

            for (int i = 1; i <= 100; i++)
            {
                if (i == 1)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoJson.Elapsed.TotalSeconds} s.");
                    almacena = $"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoJson.Elapsed.TotalSeconds} s.\n";

                    vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                    File.AppendAllText(pathFile, vJson);
                }
                if (i == 2 || i < 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoJson.Elapsed.TotalSeconds} s.");
                    almacena = $"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoJson.Elapsed.TotalSeconds} s.\n";

                    vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                    File.AppendAllText(pathFile, vJson);
                }
                else if (i == 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoJson.Elapsed.TotalSeconds} s.");
                    almacena = $"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoJson.Elapsed.TotalSeconds} s.\n";

                    vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                    File.AppendAllText(pathFile, vJson);
                }
                else
                {
                    Console.WriteLine("JSON");
                }
                Thread.Sleep(100);
            }
            tiempoJson.Stop();
            Console.WriteLine($"\nJSON GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoJson.Elapsed.TotalSeconds} s.!!!\n");
            Console.ResetColor();
        }

    }
}
