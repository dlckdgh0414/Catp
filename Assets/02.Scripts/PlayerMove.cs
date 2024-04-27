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

        // 안녕하세요 코드 훈수 마스터입니다.
        // 오늘은 이창호의 코드를 좀 고쳐보려고 합니다.
        // 자 먼저 간단하게 살펴보도록 하겠습니다~
        // float x = Input.GetAxisRaw("Horizontal");
        // 이거 자체는 문제는 없습니다. 넘어가도록 하죠.

        // move = new Vector2(x, 0f).normalized * speed;
        // 자 지금 이렇게 멋진 코드가 있는데요.
        // 지금 맨 위에다가 미리 vector2 move를 선언하셨는데,
        // 그냥 저 함수 안에서 선언하셔도 충분히 됩니다.
        // Vector2 move = new Vector2(x, 0).normalized * speed;

        // anim.SetBool(walkHash, move.magnitude > 0);
        // 이건 괜찮은것 같긴 하네요.

        // if (move.x > 0)
        // {
        //     print("햙짝");
        //     sprit.flipX = false;
        // }
        // else if (move.x < 0)
        // {
        //     print("햙햘짝");
        //     sprit.flipX = true;
        // }
        // Debug.Log쓰십쇼...
        // 그리고 로그찍을땐 알아볼 수 있게끔 하십쇼...
        // 나머지는 괜찮은 것 같긴 하네요~

        // 지금까지 코드 훈수 마스터였습니다! 유바~
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
