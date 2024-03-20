using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ButtonKnight : MonoBehaviour
{
    public Vector3 Spawn;

    public GameObject KPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnKnight()
    {
        Instantiate(KPrefab, Spawn, quaternion.identity);
        Destroy(gameObject);
    }
}
