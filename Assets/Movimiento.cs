using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

    public float velocidadDespzamiento = null;
	// Use this for initialization
	void Start () {

        if (velocidadDespzamiento == null)
        {
            velocidadDespzamiento = 0.1f;
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            this.transform.Translate(Vector3.forward * velocidadDespzamiento,Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * velocidadDespzamiento, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * velocidadDespzamiento, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * velocidadDespzamiento, Space.World);
        }
	}
}
