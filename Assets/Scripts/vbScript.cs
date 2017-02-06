using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbButtonObject;
    //private GameObject cube;
    // Use this for initialization
    void Start () {
        vbButtonObject = GameObject.Find("actionButton");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //cube = GameObject.Find("Cube");
        //Debug.Log("cube is" + cube);
    }

    public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button down!");
        //cube.transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
