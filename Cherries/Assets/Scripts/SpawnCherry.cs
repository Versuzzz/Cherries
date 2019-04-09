using System.Collections;
using UnityEngine;

public class SpawnCherry : MonoBehaviour
{
    public GameObject cherry;
    public void Start()
    {
        StartCoroutine(Spawn1());
    }

    IEnumerator Spawn1()
    {
        while (!Player.lose)
        {
            Instantiate(cherry, new Vector2(Random.Range(-2.31f, 2.31f), 6.81f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
