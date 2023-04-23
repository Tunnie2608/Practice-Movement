using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    private Rigidbody rb;
    private Vector3 direction, v;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        v = rb.velocity;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = direction.normalized * speed;
    }
}
