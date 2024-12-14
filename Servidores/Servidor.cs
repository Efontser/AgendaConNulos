using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidores
{
    public static class Servidor
    {

        private static string rutaCarpeta = @".\FicheroServidores";
        private static string rutaFichero = @".\FicheroServidores\Servidores.txt";
        private static string maquinaEdu = $"EDUFONT*EDUFONT";
        private static string maquinaLuismi = $"DESKTOP-M6IBFCR*DESKTOP-M6IBFCR\\SQLEXPRESS";
        private static string maquinaMaria = $"4V-PRO-948*4V-PRO-948\\SQLEXPRESS";
        private static String[] maquinas = { maquinaEdu, maquinaMaria, maquinaLuismi };

        private static Boolean ComprobarCarpeta()
        {
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);

                File.WriteAllLines(rutaFichero, maquinas); // TODO Esto lo hace en ambos casos mejor escribirlo 1 sola vez
                return false;
            }
            if (!File.Exists(rutaFichero)){
                File.WriteAllLines(rutaFichero, maquinas);
                return false;
            }
            return true;
        }

        private static Boolean EsServidor(String servidor)
        {
            if (String.IsNullOrWhiteSpace(servidor))
            {
                return false;
            }
            if (!servidor.Contains("*"))
            {
                return false;
            }
            if (servidor.LastIndexOf("*") != servidor.IndexOf("*"))
            {
                return false;
            }
            if (servidor.Trim().StartsWith("*"))
            {
                return false;
            }
            String[] servidorMaquina = servidor.Split('*');
            if (!servidorMaquina[1].StartsWith(servidorMaquina[0])) // TODO Quita esto porque no tiene porqué ocurrir
            {
                return false;
            }
            return true;
        }
        private static void LeerFichero(List<String> servidores)
        {
            //Lógica modifica una lista con los servidores que haya en el fichero.
            Boolean esCarpeta = ComprobarCarpeta();
            if (esCarpeta)
            {
                Boolean reescribirArchivo = false;
                String[] servidoresArray = File.ReadAllLines(rutaFichero);
                foreach (String linea in servidoresArray)
                {
                    if (EsServidor(linea))
                    {
                        servidores.Add(linea);
                    }
                    else
                    {
                        reescribirArchivo = true;
                    }                }
                foreach (String maquina in maquinas) {
                    if (!servidores.Contains(maquina)) { 
                        servidores.Add(maquina);
                        reescribirArchivo = true;
                    }
                }
               
                if (reescribirArchivo)
                {
                    File.WriteAllLines(rutaFichero, servidores);
                }

            }
        }

        public static String ServidorActual()
        {
            //Lógica que devuelve los servidores.
            List<String> maquinas = new List<string>();
            LeerFichero(maquinas);
            if (maquinas.Count == 0)
            {
                foreach(String maquina in maquinas)
                {
                    maquinas.Add(maquina);
                }
            }
            foreach (String linea in maquinas)
            {
                if (Environment.MachineName == linea.Substring(0, linea.IndexOf("*")))
                {
                    return linea.Substring(linea.IndexOf("*") + 1);
                }
            }
            return ".";
        }

    }
}
