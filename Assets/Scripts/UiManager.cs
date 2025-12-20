using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private int currentScore;

   
    private void OnEnable()
    {
        Item.OnAnyCollected += AddScore;
    }

    private void OnDisable()
    {
        Item.OnAnyCollected -= AddScore;
    }

    private void AddScore(int points)
    {
        currentScore += points;
        scoreText.text = $"Items: {currentScore}";
    }
}
