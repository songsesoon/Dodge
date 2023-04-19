using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;//�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;//�̵��ӷ�
    private Vector3 newVelocity;

    void Strat()
    {
        //���ӿ�����Ʈ���� Rigidbodym������Ʈ�� ã�� playRingidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update(float zInput) 
    {
        //������� �������� �Է°��� �޾� ����
        float xInput = Input.GetAxis("Horizental");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vertor3 �ӵ���(xSpeed, 0, zSpeed)�� ����
        Vector3 newVELOCITY = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ��� newVelocity�Ҵ�
        playerRigidbody.velocity = newVelocity;
    }
        
    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}