using UnityEngine;

public class Elevation_Entry : MonoBehaviour
{

    public Collider2D[] mountainColliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (Collider2D mountain in mountainColliders)
        {
            mountain.enabled = false;
        }
        collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
    }
}
