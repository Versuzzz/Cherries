using UnityEngine;

public class MoveDown : MonoBehaviour {
    public  static float fallspeed = 5f;

   
    
    void Update ()
    {

        if(transform.position.y < -6f) //6f?, смотри если ты не указываешь точное расширение в настройках проетка, то 6f может быть разным на разных устройствах
        {
            Destroy(gameObject);
        }
        
        transform.position -= new Vector3(0, fallspeed * Time.deltaTime, 0); //TODO: жуе писал в предыдущем файле

	}
}
