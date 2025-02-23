using UnityEngine;
using UnityEngine.SceneManagement; //Bu k�t�phanede sahne ile ilgili verileri al�p verme var.


//Burda ama� karakter engelere �araparsa sahneyiba�tan al�yor.
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
