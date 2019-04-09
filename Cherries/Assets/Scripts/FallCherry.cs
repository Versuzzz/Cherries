using UnityEngine;

public class FallCherry : MonoBehaviour
{
    [SerializeField]
    private float fallspeed = 5f;

    public void test2(Collider2D others)
    {
        while (true)
        {
            if (others.gameObject.tag == "Cherry")
            {
                Destroy(gameObject);
            }
        }
    }
    void Update()
    {
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, fallspeed * Time.deltaTime, 0);

    }
}
