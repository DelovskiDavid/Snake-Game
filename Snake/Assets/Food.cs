using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;

    private void Start()
    {
        RandomizePosition();

    }
    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(Mathf.Round(bounds.min.x), Mathf.Round(bounds.max.x));
        float y = Random.Range(Mathf.Round(bounds.min.y), Mathf.Round(bounds.max.y));

        this.transform.position = new Vector3(Mathf.Round(x),Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            RandomizePosition();
        }
    }
}
