using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;//�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;//�̵��ӷ�

    void Strat()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}