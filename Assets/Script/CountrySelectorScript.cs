using UnityEngine;
using UnityEngine.SceneManagement;

public class CountrySelectorScript : MonoBehaviour
{
    // Bu metod, bir nesneye t�kland���nda �a�r�l�r.
    private void OnMouseDown()
    {
        // T�rkiye'yi se�ti�imizde GameScene sahnesine ge�iyoruz
        SceneManager.LoadScene("GameScene");
    }
}
