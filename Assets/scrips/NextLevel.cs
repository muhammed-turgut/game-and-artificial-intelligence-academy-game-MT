using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement; //Bu kütüphanede sahne ile ilgili verileri alýp verme var.
public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            SceneManager.LoadScene("2");


        }
    }
}
