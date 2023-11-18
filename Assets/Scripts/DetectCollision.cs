using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private static int score = 0;
    private AnimalHunger animalHunger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            Destroy(gameObject);
            other.GetComponent<AnimalHunger>().FeedAnimal(1);

        }
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log("Score: " + score);

    }

}
