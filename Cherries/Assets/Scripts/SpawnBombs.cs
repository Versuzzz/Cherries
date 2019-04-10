using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {
    public GameObject bomb;
    public void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.31f, 2.31f), 6.81f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Cherry" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
