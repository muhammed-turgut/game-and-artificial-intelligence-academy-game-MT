using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement; //Bu k�t�phanede sahne ile ilgili verileri al�p verme var.
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
