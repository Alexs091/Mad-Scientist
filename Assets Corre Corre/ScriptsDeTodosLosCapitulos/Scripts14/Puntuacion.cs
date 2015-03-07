using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

	private int puntuacion = 0;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion+=puntosAIncrementar;
		Debug.Log("Incrementado "+puntosAIncrementar+" puntos. Total ganados: "+puntuacion);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
