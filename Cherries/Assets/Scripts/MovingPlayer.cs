using UnityEngine;

public class MovingPlayer : MonoBehaviour {
    public Transform player;
    [SerializeField]
    private float speed = 20f;

    private void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.31f ? 2.31f : mousePos.x;
            mousePos.x = mousePos.x < -2.31f ? -2.31f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
        }
    }
}
