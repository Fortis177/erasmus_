using UnityEngine;

public class TurkeyButton : MonoBehaviour
{
    // Türkiye'ye tıklanıldığında açılacak olan bilgi panelini tutacak
    public GameObject infoPanel;

    // Butona tıklanıldığında çağrılacak metod
    public void OnTurkeyClicked()
    {
        // Bilgi paneli varsa aktif et
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
            Debug.Log("Türkiye butonuna tıklandı! Panel açıldı.");
        }
        else
        {
            Debug.LogWarning("InfoPanel atanmamış! Lütfen infoPanel'i Unity Editor'den bağlayın.");
        }
    }
}
