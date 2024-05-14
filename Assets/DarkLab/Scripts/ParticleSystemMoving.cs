using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemMoving : MonoBehaviour
{
    public Transform playerTransform; // Ссылка на трансформ игрока
    private ParticleSystem particleSystem; // Ссылка на компонент ParticleSystem

    void Start()
    {
        // Получаем компонент ParticleSystem при старте сцены
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        // Проверяем, что игрок существует и компонент ParticleSystem присутствует
        if (playerTransform != null && particleSystem != null)
        {
            // Привязываем положение частиц к игроку
            particleSystem.transform.position = playerTransform.position;
        }
    }
}
