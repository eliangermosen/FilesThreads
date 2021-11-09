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
            //Stopwatch tiempoJson = new Stopwatch();
            ////string almacena = $"DATOS DEL ESTUDIANTE:\nMATRICULA: {Matricula}\nNOMBRE: {Nombre}\nAPELLIDO: {Apellido}\nCARRERA: {Carrera}\nDIRECCION: {Direccion}\nTELEFONO: {Telefono}\nEMAIL: {Email}\n";
            //string pathFile = "json.json";
            //string vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
            //File.AppendAllText(pathFile, vJson);
            Console.WriteLine("\nJSON GUARDADO CON EXITO!!!\n");
        }

    }
}
