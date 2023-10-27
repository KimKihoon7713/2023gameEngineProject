using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10.0f; // 점프 힘 조절용 변수
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 바를 누를 때 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // 오브젝트에 점프 힘을 적용
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

}