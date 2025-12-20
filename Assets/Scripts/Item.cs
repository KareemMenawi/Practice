using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int points;
    public static event Action<int> OnAnyCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnAnyCollected?.Invoke(points);
            Destroy(gameObject);
        }
    }
}
