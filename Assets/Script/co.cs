using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class co : MonoBehaviour
{
    private Rigidbody rb;
    public float powore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * powore;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
