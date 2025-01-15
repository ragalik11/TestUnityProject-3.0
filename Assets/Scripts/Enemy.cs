using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
    }
}

