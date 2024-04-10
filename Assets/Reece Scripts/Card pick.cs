using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardpick : MonoBehaviour
{
    public static List<GameObject> objectstopick;

    public List<GameObject> selector;

    public GameObject spawnpoint;
    // Start is called before the first frame update
    void Start()
    { 
        objectstopick.AddRange(selector);
        Pick();
    }

    public void Pick()
    {
        
        int randomIndex = Random.Range(0, selector.Count);
        GameObject clone = Instantiate(selector[randomIndex], spawnpoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
