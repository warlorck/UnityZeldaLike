using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovements : MonoBehaviour
{
    public float speed;
    [HideInInspector]
    public Vector2 moveInputs;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        moveInputs = new Vector2(x, y);
    }

    void FixedUpdate()
    {
        Vector2 target = rb.position + moveInputs * speed * Time.deltaTime;
        rb.MovePosition(target);
    }
}