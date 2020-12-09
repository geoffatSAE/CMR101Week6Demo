using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRed : MonoBehaviour
{

    public enum DropCube {  still, spinning };
    public DropCube dropCube;

    private void OnEnable()
    {
        MyEventManager.OnSpin += StartSpinning;
        MyEventManager.OnStill += StopSpinning;
    }

    private void OnDisable()
    {
        MyEventManager.OnSpin -= StartSpinning;
        MyEventManager.OnStill -= StopSpinning;

    }


    Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (dropCube)
        {
            case DropCube.still:
                Debug.Log("the dropcube is still");
                
                 break;

            case DropCube.spinning:
                Debug.Log("the dropcube is spinning");
                transform.Rotate(Vector3.up * 2);
                break;

        }


    }



    public void MakeRed()
    {
        r.material.color = Color.red;
    }

    public void MakeBlue()
    {
        r.material.color = Color.blue;
    }

    public void StartSpinning()
    {
        dropCube = DropCube.spinning;
        MakeBlue();
    }

    public void StopSpinning()
    {
        dropCube = DropCube.still;
        MakeRed();
    }
}
