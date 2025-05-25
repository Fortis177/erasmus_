using UnityEngine;

public class TurkeySelector : MonoBehaviour
{
    public GameObject infoPanel; // Türkiye ile ilgili bilgilerin olduðu panel

    private void OnMouseDown()
    {
        // Türkiye'ye týklanýnca paneli aç
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
        }
    }
}
