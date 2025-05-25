using UnityEngine;
using UnityEngine.SceneManagement;

public class CountrySelectorScript : MonoBehaviour
{
    // Bu metod, bir nesneye týklandýðýnda çaðrýlýr.
    private void OnMouseDown()
    {
        // Türkiye'yi seçtiðimizde GameScene sahnesine geçiyoruz
        SceneManager.LoadScene("GameScene");
    }
}
