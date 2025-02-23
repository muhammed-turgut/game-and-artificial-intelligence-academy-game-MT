using UnityEngine;
using UnityEngine.SceneManagement; //Bu kütüphanede sahne ile ilgili verileri alýp verme var.


//Burda amaç karakter engelere çaraparsa sahneyibaþtan alýyor.
public class Engel : MonoBehaviour
{
    private Scene _scene;

    private void Awake()
    {

        _scene = SceneManager.GetActiveScene();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            SceneManager.LoadScene(_scene.name);


        }
    }
}
