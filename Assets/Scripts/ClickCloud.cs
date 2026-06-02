using UnityEngine;

public class ClickCloud : MonoBehaviour
{
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Example using the classic Input manager; switch to your Input Action context if needed
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            
            if (hit.collider != null)
            {
                Cloud cloud = hit.collider.GetComponent<Cloud>();
                if (cloud != null)
                Debug.Log("Raycast hit target: " + hit.collider.gameObject.name);
            }
        }
    }
}
