using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public float speedx = 0.0f;
    public float speedxx = 0.0f;

    private Rigidbody2D r2D;
    private Animator _animator;
    

    // Bu fonksiyon oyun �al��t��� ilk an �al��an bir fonksiyon.
    void Start()
    {
        r2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Bu fonksiyon oyun �al��t��� her an ve her karede �a�r�l�r.
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            speedx = 1.0f;
            Debug.Log("H�z 1.0f");
        }
        else
        {
            speedx = 0.0f;
            Debug.Log("H�z 0.0f");
        }
        _animator.SetFloat("speed", speedx);
        r2D.velocity = new Vector2(speedx, 0f);


        if (Input.GetKey(KeyCode.A))
        {
            speedxx = 1.0f;
            Debug.Log("H�z 0.1f");

           
        }
        else
        {
            speedxx = 0.0f;
            Debug.Log("H�z 0.0f");
        }

        _animator.SetFloat("speed", speedxx);
        r2D.velocity = new Vector2(-speedxx, 0f);






    }
}
