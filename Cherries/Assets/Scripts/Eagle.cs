using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    public GameObject Eagle_;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cherry") //TODO: не думаю что это бест практис, ты уверен что это единственный метод проверки?
        {
            Destroy(gameObject);
            StartCoroutine(Spawn1());
        }
    }
    IEnumerator Spawn1()
    {
        while (!Player.lose)
        {
            Instantiate(Eagle_, new Vector2(Random.Range(-2.31f, 2.31f), 6.81f), Quaternion.identity);//TODO: откуда числа?
            yield return new WaitForSeconds(3f);
        }
    }
}