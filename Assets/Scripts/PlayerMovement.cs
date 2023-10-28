using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float playerSpeed = 2f;
    private Vector2 v;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        v = new Vector2(horizontal, vertical);
    }

    private void FixedUpdate()
    {
        rigid.velocity = playerSpeed * v;
    }
}
