using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChecker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int _score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Enemy>(out _))
        {
            _score++;
            scoreText.text = _score.ToString();
        }
    }
}

