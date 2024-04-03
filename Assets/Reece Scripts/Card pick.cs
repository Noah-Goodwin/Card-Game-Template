using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardpick : MonoBehaviour
{


    public bool Picked;


    // Start is called before the first frame update
    void Start()
    {
        int[] cards = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("");
            Picked = true;

        }
    }

    void roundStart()
    {

    }

    void tostring()
    {
        
    }

}
