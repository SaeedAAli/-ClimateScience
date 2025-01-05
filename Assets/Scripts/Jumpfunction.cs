using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpfunction : MonoBehaviour
{
    public float JumpBalance;
    public Rigidbody2D rb;
    public bool ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}