using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color prefabCol; 
    public Camera cam;
    void Start()
    {
        prefabCol = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); //generamos un color random para el gameobject
        GetComponent<MeshRenderer>().material.color = prefabCol; //se lo asociamos para que tenga un color nada m�s empezar el juego
    }
    private void OnMouseDown()
    {
        cam.GetComponent<Camera>().backgroundColor = prefabCol; //accedemos a la c�mara y su componente background para poder cambiarle el color por el que hemos clicado
        prefabCol = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); 
        GetComponent<MeshRenderer>().material.color = prefabCol; //sustituiremos el color del bot�n que hemos pulsado por uno nuevo random
    }
   
}
