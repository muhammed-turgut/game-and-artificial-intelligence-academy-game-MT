using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D r2D;
    private Animator _animator;
    private Vector3 charPos;
    [SerializeField] private GameObject _camera;


    // Bu fonksiyon oyun �al��t��� ilk an �al��an bir fonksiyon.
    void Start()
    {
        r2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charPos = transform.position;
    }
    private void FixedUpdate()
    {
       
    }

    // Bu fonksiyon oyun �al��t��� her an ve her karede �a�r�l�r.
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            speed = 8.0f;
            Debug.Log("Hiz 1.0f");
        }
        else
        {
            speed = 0.0f;
            Debug.Log("Hiz 0.0f");
        }


        charPos = new Vector3(charPos.x + (speed * Time.deltaTime), charPos.y);//delta time iki fram arasnındaki zaman
        transform.position = charPos;//burda yeni hesaplatığımız fizik hesabını kullanmasını sağladık


        _animator.SetFloat("speed", speed);
       

    }

    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f); //kamera takip fonksiyonu.
    }
}

