using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    public GameObject Eagle_;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cherry")
        {
            Destroy(gameObject);
            StartCoroutine(Spawn1());
        }
    }
    IEnumerator Spawn1()
    {
        while (!Player.lose)
        {
            Instantiate(Eagle_, new Vector2(Random.Range(-2.31f, 2.31f), 6.81f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}