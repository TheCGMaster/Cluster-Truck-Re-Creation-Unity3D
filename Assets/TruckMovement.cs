using UnityEngine;
using System.Collections;

public class TruckMovement : MonoBehaviour {

    public float MovementSpeed;
	void Start () {
        MovementSpeed = Random.Range(MovementSpeed, MovementSpeed + 30);
        this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().drag = Random.Range(0.1f, 1f);
	}
	
	
	void Update () {
        transform.position += this.transform.forward * Time.deltaTime * MovementSpeed;
	}
}
