using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarPrefab : MonoBehaviour
{

    public GameObject PrefabCoche;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate(PrefabCoche, position, Quaternion.Euler(Random.Range(-10.0f, 10.0f), Random.Range(-20.0f, 20.0f), Random.Range(-30.0f, 3-.0f)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
