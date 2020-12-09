using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEventManager : MonoBehaviour
{
    public delegate void Spin();
    public static event Spin OnSpin;

    public delegate void Still();
    public static event Still OnStill;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallSpin()
    {
        if (OnSpin != null)
        {
            OnSpin();
        }

    }
    public void CallStill()
    {
        if (OnStill != null)
        {
            OnStill();
        }

    }
}
