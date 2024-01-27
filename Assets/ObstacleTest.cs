using UnityEngine;

public class ObstacleTest : MonoBehaviour
{
    public LayerMask playerLayers;

    // Start is called before the first frame update
    void Start()
    {
        // Tambahkan inisialisasi jika diperlukan
    }

    // Update is called once per frame
    void Update()
    {
        Detection();
    }

    void Detection()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1f, playerLayers);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("player"))
            {
                Destroy(collider.gameObject); 
            }
        }
    }
}
