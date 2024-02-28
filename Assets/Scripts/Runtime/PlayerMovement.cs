using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 touchPosition;
    private float deltaX;
    private float deltaY;
    public float speed = 0.1f;
    int screenWidth = Screen.width;
    int screenHeight = Screen.height;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchPosition = touch.position;
                    break;

                case TouchPhase.Moved:
                    deltaX = (touch.position.x - touchPosition.x)/ screenWidth;
                    deltaY = (touch.position.y - touchPosition.y)/ screenHeight;
                    transform.position += new Vector3(deltaX * speed * Time.deltaTime, 0, deltaY * speed * Time.deltaTime);
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    deltaX = 0;
                    deltaY = 0;
                    break;
            }
        }
    }
}

