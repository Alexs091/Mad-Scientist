using UnityEngine;
using System.Collections;

public class EstadoJuego : MonoBehaviour {

	public int puntuacionMaxima = 0;

	public static EstadoJuego estadoJuego;

	void Awake(){
		if(estadoJuego==null){
			estadoJuego = this;
			DontDestroyOnLoad(gameObject);
		}else if(estadoJuego!=this){
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
