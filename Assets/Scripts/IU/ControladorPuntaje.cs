using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntaje : MonoBehaviour
{
	[Header("Score")]
	public int puntuacion;
	private static bool created;

	public void Start()
	{
		if (created)
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
		created = true;
	}

	private void Load()
	{
		if (PlayerPrefs.HasKey("Puntuacion"))
		{
			puntuacion = PlayerPrefs.GetInt("Puntuacion");
		}
	}
}
