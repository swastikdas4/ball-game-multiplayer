using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addplayercontrolledvelocity : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keypositive;
    [SerializeField]
    KeyCode keynegative;


    void Update()
    {
        if (Input.GetKey(keypositive))
            GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(keynegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
