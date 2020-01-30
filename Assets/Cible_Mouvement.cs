using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cible_Mouvement : MonoBehaviour
{
    float timeCounter = 0;
    float x_init;
    float y_init;
    float z_init;

    void Start()
    {
        x_init = transform.position.x;
        y_init = transform.position.y;
        z_init = transform.position.z;

    }

    void Update()
    {
        timeCounter += Time.deltaTime;

        float x = 5*Mathf.Cos(timeCounter) + x_init;
        float y = 5*Mathf.Sin(timeCounter) + y_init;
        float z = z_init;

        transform.position = new Vector3(x,y,z);

    }
}
