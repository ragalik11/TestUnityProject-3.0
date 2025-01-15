using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private enum Side { Left, Right }

    public float leftX;
    public float rightX;
    public float speed;

    private Vector3 _target;
    private Side _nowSide;

    private void Start()
    {
        _target = transform.position;
        // Initialize the starting side based on the current position
        _nowSide = transform.position.x <= leftX ? Side.Left : Side.Right;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (_nowSide)
            {
                case Side.Left:
                    _target = new Vector3(rightX, transform.position.y);
                    _nowSide = Side.Right;
                    break;
                case Side.Right:
                    _target = new Vector3(leftX, transform.position.y);
                    _nowSide = Side.Left;
                    break;
            }
        }

        transform.position = Vector3.Lerp(transform.position, _target, speed * Time.deltaTime);

        
    }
       private void OnCollisionEnter(Collision other)
    {
        if (other.collider.TryGetComponent<Enemy>(out _))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}


