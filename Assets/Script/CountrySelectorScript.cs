using UnityEngine;
using UnityEngine.SceneManagement;

public class CountrySelectorScript : MonoBehaviour
{
    // Bu metod, bir nesneye tıklandığında çağrılır.
    private void OnMouseDown()
    {
        // Türkiye'yi seçtiğimizde GameScene sahnesine geçiyoruz
        SceneManager.LoadScene("GameScene");
    }
}
