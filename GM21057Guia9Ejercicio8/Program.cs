using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Guía:9
// Ejercicio:8
// Fecha: 18/5/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora:Ing. Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia9Ejercicio8
{
	//Descripcion del programa:
	//Se necesita conocer la frecuencia de cada uno de los elementos de un vector de n elementos.


	class Program
	{
		public static void Main(string[] args)
		{

			//Identificacion del programa en pantalla
			Console.Title = ("Frecuencia de cada uno de los elementos de un vector de n elementos. ");
			Console.WriteLine("Frecuencia de cada uno de los elementos de un vector de n elementos.  ");
			Console.WriteLine("Autor:Brandon Gomez");

			//DECLARACION DE VARIABLES
			int[] vector0 = { 6, 7, 5, 4, 5, 3, 6, 7, 2, 6 };
			int[] vectorRepetidos = new int[vector0.Length];
			int[] vectorFrecuencia = new int[vector0.Length];

			//ENTRADA DE DATOS


			//PROCESO DE DATOS
			for (int i = 0; i < vector0.Length; i++)
			{
				Console.Write("[{0}]", vector0[i]);
			}
			Console.Write("\n---------------------------\n");

			for (int i = 0; i < vector0.Length; i++)
			{
				int cuenta = 0;
				for (int j = 0; j < vector0.Length; j++)
				{
					if (vector0[i] == vector0[j])
					{
						cuenta++;
						if (Repetidos(vector0[i]))
						{
							vectorRepetidos[i] = vector0[i];
						}
					}
				}
				//SALIDA DE DATOS
				if (vectorRepetidos[i] != 0)
					Console.Write("[{0}] ", vectorRepetidos[i]);
			}
		
			Console.Write("\n---------------------------\n");
			for (int i = 0; i < vector0.Length; i++)
			{
				int cuenta = 0;
				for (int j = 0; j < vector0.Length; j++)
				{
					if (vector0[i] == vector0[j])
					{
						cuenta++;
						if (Frecuencia (vector0[i]))
						{
							vectorFrecuencia[i] = vector0[i];
						}
					}
				}
				//SALIDA DE DATOS
				if (vectorFrecuencia[i] != 0)
					Console.Write("[{0}] ", cuenta);
			}
			Console.ReadKey();

			//PROCESO DE DATOS
			bool Repetidos(int num)
			{
				for (int i = 0; i < vectorRepetidos.Length; i++)
				{
					if (vectorRepetidos[i] == num)
					{
						return false;
					}
				}
				return true;
			}

			//PROCESO DE DATOS
			bool Frecuencia(int num)
			{
				for (int i = 0; i < vectorFrecuencia.Length; i++)
				{
					if (vectorFrecuencia[i] == num)
					{
						return false;
					}
				}
				return true;
			}
		}
    }
}