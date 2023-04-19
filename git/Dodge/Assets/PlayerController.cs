using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;//이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;//이동속력
    private Vector3 newVelocity;

    void Strat()
    {
        //게임오브젝트에서 Rigidbodym컴포넌트를 찾아 playRingidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update(float zInput) 
    {
        //수평축과 수직축의 입력값을 받아 저장
        float xInput = Input.GetAxis("Horizental");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vertor3 속도를(xSpeed, 0, zSpeed)로 생성
        Vector3 newVELOCITY = new Vector3(xSpeed, 0f, zSpeed);
        //리지드바디의 속도에 newVelocity할당
        playerRigidbody.velocity = newVelocity;
    }
        
    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}