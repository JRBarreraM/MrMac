using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ControlArchivo : MonoBehaviour
{
	//public static string rutaTxt = @"C:\Users\carlos\Desktop\Unity\Proyectos\JuegoMac\Progreso\progreso.txt";
	public static string rutaJson = @"C:\Users\JuanMSI\Desktop\JJ\dat.json";
	public static string rutaJson = @"/home/invitado/Documents/Safford/dat.json";

	static string cadenaJson;

	public static void ActualizarGrupo(string nombre_ = "Grupo no registrado")
	{
		cadenaJson = File.ReadAllText (rutaJson);
		Grupo grupo = JsonUtility.FromJson<Grupo> (cadenaJson);
		grupo.nombre = nombre_;

		cadenaJson = JsonUtility.ToJson (grupo);
		File.WriteAllText (rutaJson, cadenaJson);
	}

	public static void ActualizarProgreso(string progreso = "0")
	{
		cadenaJson = File.ReadAllText (rutaJson);
		Grupo grupo = JsonUtility.FromJson<Grupo> (cadenaJson);
		grupo.porcentaje = progreso;

		cadenaJson = JsonUtility.ToJson (grupo);
		File.WriteAllText (rutaJson, cadenaJson);
	}

	public static void ActualizarTiempo(string tiempo = "00:00:00")
	{
		cadenaJson = File.ReadAllText (rutaJson);
		Grupo grupo = JsonUtility.FromJson<Grupo> (cadenaJson);
		grupo.tiempo = tiempo;

		cadenaJson = JsonUtility.ToJson (grupo);
		File.WriteAllText (rutaJson, cadenaJson);
	}

	public static void ActualizarArchivo(string texto = "vacio")
	{
		string textoBase = "0";

		ResetearArchivo (rutaTxt);

		using(StreamWriter entrada = new StreamWriter(rutaTxt,false))
		{
			if (texto == "vacio") {
				entrada.Write (textoBase);
			}
			else
			{
				entrada.Write (texto);
			}

			entrada.Close ();
		}
	}

	static void ResetearArchivo(string ruta) 
	{
		string[] lineas = File.ReadAllLines (ruta);

		for (int i = 0; i < lineas.Length; i++) 
		{
			lineas [i] = string.Empty;
		}

		File.WriteAllLines (ruta,lineas);
	}

}
[System.Serializable]
public class Grupo
{
	public string nombre;
	public string porcentaje;
	public string tiempo;
}