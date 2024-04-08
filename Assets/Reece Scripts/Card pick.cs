using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardpick : MonoBehaviour
{
    public GameObject[] objectstopick;

    // Start is called before the first frame update
    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, objectstopick.Length);
        GameObject clone = Instantiate(objectstopick[randomIndex], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
