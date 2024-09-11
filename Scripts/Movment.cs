
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody2D rb;
    
    public float moveSpeed = 5f; // Karakterin hareket h�z�
    public float swipeThreshold = 50f; // Parma��n kayd�r�lma mesafesi e�i�i
    public float[] lanePositions; // Sabit noktalar�n x koordinatlar�
    private int currentLaneIndex = 1; // Mevcut pozisyon indeksi, ba�lang��ta orta �eritte (0: sol, 1: orta, 2: sa�)

    private Vector2 startTouchPosition;
    private Vector2 currentTouchPosition;
    private bool isSwiping = false;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Map_sc.instance.player_movment == false)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
            if (Input.GetMouseButtonDown(0))
            {
                startTouchPosition = Input.mousePosition;
                isSwiping = true;
            }

            // Parma��n ekranda hareket etti�i an
            if (Input.GetMouseButton(0) && isSwiping)
            {
                currentTouchPosition = (Vector2)Input.mousePosition;
                Vector2 distance = currentTouchPosition - startTouchPosition;

                // Sa� kayd�rma
                if (distance.x > swipeThreshold)
                {
                    MoveRight();
                    isSwiping = false;
                }
                // Sol kayd�rma
                else if (distance.x < -swipeThreshold)
                {
                    MoveLeft();
                    isSwiping = false;
                }
            }

            // Parma��n ekrandan kalkt��� an
            if (Input.GetMouseButtonUp(0))
            {
                isSwiping = false;
            }

            // Karakteri sabit noktaya do�ru hareket ettir
            Vector3 targetPosition = new Vector3(lanePositions[currentLaneIndex], transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            /*float move = joystick.Horizontal * sp;
            Vector3 v1 = new Vector3(move,0, 0);
            transform.position += v1 * sp * Time.deltaTime;

            float fly = joystick.Vertical;

            if (fly >= .2f)
            {
                Vector3 v2= new Vector3(0,fly, 0);
                transform.position += v2 * fp * Time.deltaTime;
            }
            if (fly <= -.2f)
            {
                Vector3 v2 = new Vector3(0, fly, 0);
                transform.position += v2 * fp * Time.deltaTime;
            }

            if (move > 0) { transform.eulerAngles = new Vector3(0, 0, 0); }
            else if (move < 0) { transform.eulerAngles = new Vector3(0, 180, 0); }
            */
        
    }
        private void MoveRight()
        {
            if (currentLaneIndex < lanePositions.Length - 1)
            {
                currentLaneIndex++;
            }
        }

        private void MoveLeft()
        {
            if (currentLaneIndex > 0)
            {
                currentLaneIndex--;
            }
        }
    
}
