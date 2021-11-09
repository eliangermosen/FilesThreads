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
    class GeneradorArchivo : IGenerador
    {
        public void ArchivoTxt()
        {
            Stopwatch tiempoTxt = new Stopwatch();
            StreamWriter TXT = File.AppendText("txt.txt");
            TXT.WriteLine("                                  TXT SIN HILOS:                                  \n");
            for (int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (i == 1)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoTxt}.");
                    TXT.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoTxt.Elapsed.Seconds} s.\n");
                }
                if (i == 2 || i < 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoTxt}.");
                    TXT.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoTxt.Elapsed.Seconds} s.\n");
                }
                else if (i == 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoTxt}.");
                    TXT.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoTxt.Elapsed.Seconds} s.\n");
                }
                else
                {
                    Console.WriteLine("TXT");
                }
                //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoTxt}.");
                //TXT.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoTxt}.\n");
                //Console.ResetColor();
            }
            TXT.Close();
            tiempoTxt.Stop(); // Detener la medición de tiempo.
                              //Console.WriteLine($"\nTIEMPO FINAL CON HILO: {tiempoHilo.Elapsed.TotalSeconds} s.");
                              //Console.WriteLine($"TIEMPO FINAL CON HILO: {tiempoHilo.Elapsed.Seconds} s.\n");
            Console.WriteLine($"\nTXT GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoTxt.Elapsed.TotalSeconds} s.!!!\n");
            Console.WriteLine($"\nTXT GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoTxt.Elapsed.Seconds} s.!!!\n");
            Console.ResetColor();
        }

        public void ArchivoExcel()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Stopwatch tiempoExcel = new Stopwatch();

            SLDocument slDocument = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("EXCEL SIN HILOS:", typeof(string));

            for (int i = 1; i <= 100; i++)
            {
                if (i == 1)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoExcel}.");
                    dt.Rows.Add($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoExcel.Elapsed.Seconds} s.\n");
                }
                if (i == 2 || i < 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoExcel}.");
                    dt.Rows.Add($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoExcel.Elapsed.Seconds} s.\n");
                }
                else if (i == 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoExcel}.");
                    dt.Rows.Add($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoExcel.Elapsed.Seconds} s.\n");
                }
                else
                {
                    Console.WriteLine("EXCEL");
                }
            }
            //dt.Rows.Add();
            slDocument.ImportDataTable(1, 1, dt, true);
            slDocument.SaveAs("excel.xlsx");
            tiempoExcel.Stop();
            Console.WriteLine($"\nEXCEL GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoExcel.Elapsed.TotalSeconds} s.!!!\n");
            Console.WriteLine($"\nEXCEL GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoExcel.Elapsed.Seconds} s.!!!\n");
            Console.ResetColor();
        }

        public void ArchivoJson()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Stopwatch tiempoJson = new Stopwatch();

            string pathFile = "json.json";
            string almacena;
            string vJson;
            for (int i = 1; i <= 100; i++)
            {
                if (i == 1)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoExcel}.");
                    almacena = $"ESTA ES MI VUELTA INICIAL, EN UN TIEMPO DE {tiempoJson.Elapsed.Seconds} s.\n";

                    vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                    File.AppendAllText(pathFile, vJson);
                }
                if (i == 2 || i < 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoExcel}.");
                    almacena = $"ESTA ES MI VUELTA #{i}, EN UN TIEMPO DE {tiempoJson.Elapsed.Seconds} s.\n";

                    vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                    File.AppendAllText(pathFile, vJson);
                }
                else if (i == 100)
                {
                    //Console.WriteLine($"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoExcel}.");
                    almacena = $"ESTA ES MI VUELTA FINAL, EN UN TIEMPO DE {tiempoJson.Elapsed.Seconds} s.\n";

                    vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                    File.AppendAllText(pathFile, vJson);
                }
                else
                {
                    Console.WriteLine("JSON");
                }
                //string vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
                //File.AppendAllText(pathFile, vJson);
            }
            //almacena = $"DATOS DEL ESTUDIANTE:\nMATRICULA:\n";
            //string vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
            //File.AppendAllText(pathFile, vJson);
            tiempoJson.Stop();
            Console.WriteLine($"\nJSON GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoJson.Elapsed.TotalSeconds} s.!!!\n");
            Console.WriteLine($"\nJSON GUARDADO CON EXITO EN UN TIEMPO FINAL DE {tiempoJson.Elapsed.Seconds} s.!!!\n");
            Console.ResetColor();
        }

    }
}
