using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRed : MonoBehaviour
{

    Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeRed()
    {
        r.material.color = Color.red;
    }

    public void MakeBlue()
    {
        r.material.color = Color.blue;
    }
}
