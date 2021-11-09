using System;
using System.Threading;

namespace FilesThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*GENERADOR ARCHIVO SIN HILOS*/
            GeneradorArchivo generadorArchivo = new GeneradorArchivo();//instancia clase de generadorarchivo sin hilo
            //generadorArchivo.ArchivoTxt();
            generadorArchivo.ArchivoExcel();
            //generadorArchivo.ArchivoJson();

            /*GENERADOR ARCHIVO CON HILOS*/
            //GeneradorArchivoThreads generadorArchivoThreads = new GeneradorArchivoThreads();//instancia clase de generadorarchivo con hilo
            //Thread archivoTxt = new Thread(new ThreadStart(generadorArchivoThreads.ArchivoTxt));//hilo 1 de generador archivo TXT
            //Thread archivoExcel = new Thread(new ThreadStart(generadorArchivoThreads.ArchivoExcel));//hilo 2 de generador archivo EXCEL
            //Thread archivoJson = new Thread(new ThreadStart(generadorArchivoThreads.ArchivoJson));//hilo 3 de generador archivo JSON
            //archivoTxt.Start();
            //archivoExcel.Start();
            //archivoJson.Start();
        }
    }
}
