using UnityEngine;

public class MoveDown : MonoBehaviour {
    public  static float fallspeed = 5f;

   
    
    void Update ()
    {

        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
        
        transform.position -= new Vector3(0, fallspeed * Time.deltaTime, 0);

	}
}
