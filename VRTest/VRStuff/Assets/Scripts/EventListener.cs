using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour {

    private int CurrentColor = 0;
    private Renderer _renderer;
    private Color[] aColors = new Color[] { Color.red, Color.blue, Color.green };
    //  public GvrControllerInput abcd;// = gameObject.GetComponent<GvrControllerInput>();


    public GvrControllerInputDevice ControllerInputDevice;

    // Use this for initialization
    void Start () {
       _renderer = gameObject.GetComponent<Renderer>();

     
     //  abcd = GameObject.FindObjectOfType(typeof(GvrControllerInput)) as GvrControllerInput;
     //  abcd.
}
	
	public void OnEnter()
    {
        _renderer.material.color = Color.red;
    }

    public void OnExit()
    {
        _renderer.material.color = Color.white;
    }

    public void OnGrab()
    {
        Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
        transform.SetParent(pointerTransform, true);
    }

    public void OnClick()
    {
        _renderer.material.color = aColors[CurrentColor];

        CurrentColor = CurrentColor + 1;

        if (CurrentColor > 2)
        {
            CurrentColor = 0;
        }
    }

    public void OnAppClick()
    {
        if ()
        {
            _renderer.material.color = Color.black;
        }
    }

    public void OnRelease()
    {
        transform.SetParent(null, true);
    }
}
