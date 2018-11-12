using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progreso : MonoBehaviour 
{
	[Header("Parámetros de progreso")]
	public float cantidadNiveles = 5f;
	public float tamañoBarraMinimo = 0f;
	public float tamañoBarraMaximo = 2f;
	public RawImage barraProgreso;

	private float progresoPorNivel = 0f;
	private float escala = 0f;

	void Start()
	{
		barraProgreso.rectTransform.localScale = new Vector3 (tamañoBarraMinimo,
															  barraProgreso.rectTransform.localScale.y,
															  barraProgreso.rectTransform.localScale.z);
		progresoPorNivel = tamañoBarraMaximo/cantidadNiveles; 

		GuardarProgreso ();
	}

	public void ActualizarProgreso()
	{
		if (escala < tamañoBarraMaximo - progresoPorNivel)
		{
			escala = escala + progresoPorNivel;
		}

		barraProgreso.rectTransform.localScale = new Vector3 (escala,
															  barraProgreso.rectTransform.localScale.y,
															  barraProgreso.rectTransform.localScale.z);

		GuardarProgreso ();
	}

	float CalcularPorcentaje(float maximo, float actual)
	{
		float solucion = (actual * 100f) / maximo;
		solucion = Mathf.Round (solucion);

		return solucion;
	}

	void GuardarProgreso()
	{
		ControlArchivo.ActualizarProgreso (CalcularPorcentaje (tamañoBarraMaximo,escala).ToString());	
	}
		
}