using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]

public class crearMalla : MonoBehaviour
{
  Mesh mesh;
  Vector3[] vertices;
  int[] triangles;
    
    // Start is called before the first frame update
    void Start()
    {

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        createMesh();
        updateMesh();


    }

    // Update is called once per frame
    void Update()
    {
        //LLeno los arreglos de vertices
    }
    
    
    void createMesh()
    {
        vertices = new Vector3[]
        {
            //Primer Triangulo
            //Esquina Izquierda Inf base
            new Vector3(0, 0, 0),
            //Esquina Izquierda Sup base 
            new Vector3(0, 0, 1),
            //Esquina Derecha Inf base
            new Vector3(1, 0, 0),
            //Esquina Derecha Sup base
            new Vector3(1,0,1),
            
            //Segundo Cuadro
            //1.0_4
            //Esquina Izquierda Inf top
            new Vector3(0,1,0),
            //1.1_5
            //Esquina Izquierda Sup top
            new Vector3(0,1,1),
            //1.2_6
            //Esquina Derecha Inf top
            new Vector3(1,1,0),
            //1.3_7
            //Esquina Derecha Sup top
            new Vector3(1,1,1)
            
            
            //Segundo Triangulo
            
       
        };

        triangles = new int[]
        {
            0,1,2,
            1,3,2,
            4,5,6,
            5,7,6,
            0,4,2,
            4,6,2,
            1,5,0,
            5,4,0,
            1,5,3,
            5,7,3,
            2,6,3,
            6,7,3
            
            

        };
    }

    void updateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
    
}


