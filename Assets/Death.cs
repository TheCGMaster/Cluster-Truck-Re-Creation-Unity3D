using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Application.LoadLevel(0);
        }
    }
}
