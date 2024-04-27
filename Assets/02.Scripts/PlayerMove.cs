using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed = 5f;
    Animator anim;
    SpriteRenderer sprit;
    private readonly int walkHash = Animator.StringToHash("Walk");
    public Vector2 move;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        sprit = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        Move();

        // �ȳ��ϼ��� �ڵ� �Ƽ� �������Դϴ�.
        // ������ ��âȣ�� �ڵ带 �� ���ĺ����� �մϴ�.
        // �� ���� �����ϰ� ���캸���� �ϰڽ��ϴ�~
        // float x = Input.GetAxisRaw("Horizontal");
        // �̰� ��ü�� ������ �����ϴ�. �Ѿ���� ����.

        // move = new Vector2(x, 0f).normalized * speed;
        // �� ���� �̷��� ���� �ڵ尡 �ִµ���.
        // ���� �� �����ٰ� �̸� vector2 move�� �����ϼ̴µ�,
        // �׳� �� �Լ� �ȿ��� �����ϼŵ� ����� �˴ϴ�.
        // Vector2 move = new Vector2(x, 0).normalized * speed;

        // anim.SetBool(walkHash, move.magnitude > 0);
        // �̰� �������� ���� �ϳ׿�.

        // if (move.x > 0)
        // {
        //     print("�m¦");
        //     sprit.flipX = false;
        // }
        // else if (move.x < 0)
        // {
        //     print("�m�l¦");
        //     sprit.flipX = true;
        // }
        // Debug.Log���ʼ�...
        // �׸��� �α������� �˾ƺ� �� �ְԲ� �Ͻʼ�...
        // �������� ������ �� ���� �ϳ׿�~

        // ���ݱ��� �ڵ� �Ƽ� �����Ϳ����ϴ�! ����~
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");

        move = new Vector2(x, 0f).normalized * speed;
        rigid.velocity = move;
        anim.SetBool(walkHash, move.magnitude > 0);
        if (move.x > 0)
        {
            
            sprit.flipX = false;
        }
        else if (move.x < 0)
        {
            
            sprit.flipX = true;
        }
    }
}
