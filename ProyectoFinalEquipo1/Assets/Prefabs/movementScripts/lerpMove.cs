using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpMove : MonoBehaviour
{

    private Vector3 startPos;
    private Vector3 endPos;
    private float elapsedTime;
    public float timeDuration;
    
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(0, 0, 0);
        endPos = new Vector3(5, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        transform.position = Vector3.Lerp(startPos, endPos, elapsedTime / timeDuration);
    }
}
