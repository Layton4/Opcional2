using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color prefabCol;
    public Camera cam;
    void Start()
    {
        prefabCol = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<MeshRenderer>().material.color = prefabCol;
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        cam.GetComponent<Camera>().backgroundColor = prefabCol;
        prefabCol = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<MeshRenderer>().material.color = prefabCol;
    }
}
