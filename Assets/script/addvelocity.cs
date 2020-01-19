using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addvelocity : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 v3Force;
    void Update()
    {
        GetComponent<Rigidbody>().velocity += v3Force;
    }
}
