using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{

    public static bool lose = false;
    public GameObject restart;
    public GameObject player;
    public GameObject Menu;
    public int score;
    public Text scoreText;
    public GameObject Cherry;

    private void Awake()
    {
        lose = false;
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            restart.SetActive(true);
            Menu.SetActive(true);
            player.SetActive(true);
            lose = true;
            Destroy(gameObject);
            
            

        }
        if (other.gameObject.tag == "Cherry")
        {
            score += 1;
            scoreText.text = score + " points"; // не оч, лучше отдельный лейбл для + points, отдельный для очков
        }
    }
}
