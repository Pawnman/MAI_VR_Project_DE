using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemMoving : MonoBehaviour
{
    public Transform playerTransform; // ������ �� ��������� ������
    private ParticleSystem particleSystem; // ������ �� ��������� ParticleSystem

    void Start()
    {
        // �������� ��������� ParticleSystem ��� ������ �����
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        // ���������, ��� ����� ���������� � ��������� ParticleSystem ������������
        if (playerTransform != null && particleSystem != null)
        {
            // ����������� ��������� ������ � ������
            particleSystem.transform.position = playerTransform.position;
        }
    }
}
