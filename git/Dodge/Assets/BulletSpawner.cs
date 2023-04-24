using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;//������ ź���� ���� ������
    public float spawnRateMin = 0.5f;//�ּ� ���� �ֱ�
    public float spawnRateMax = 3f;//�ִ� �����ֱ�

    private Transform target;//�߻��� ���
    private float spawnRateMin;//�����ֱ�
    private float timeAfterSpawn;//�ֱ� ���� �������� ���� �ð�
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        spawnRateMax = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerDontroller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���ش������ ����
        target = FindObjectOfType<PlayerController>.(transform)
    }

    void Update()
    {
        //timeAfter Spawn ����
        timeAfterSpawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRateMin)
        {
            //������ �ð��� ����
            timeAfterSpawn = 0f;

            //bulletprefab�� �������� 
            //transform.position��ġ�� transform.rotationȸ������ ����
        }
        
        //
    }
