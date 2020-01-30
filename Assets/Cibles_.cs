using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cibles_ : MonoBehaviour
{
    [SerializeField] private GameObject cibles = default;
    private float x_pos;
    private float y_pos;
    private float z_pos;

    // Start is called before the first frame update
    private IEnumerator periode;
    void Start()
    {
        periode = Spawn_Cibles(1f);
        StartCoroutine(periode);
    }

    // Update is called once per frame
    void Update()
    {
        x_pos = Random.Range(-40,40);
        y_pos = Random.Range(3,30);
        z_pos = Random.Range(-40,40);
    }

    private IEnumerator Spawn_Cibles(float duree)
    {
        while (true)
        {
            yield return new WaitForSeconds(duree);
            Instantiate(cibles, new Vector3(x_pos,y_pos,z_pos), Quaternion.identity);
        }
    }
    
}
