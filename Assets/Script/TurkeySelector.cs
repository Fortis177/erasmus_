using UnityEngine;

public class TurkeySelector : MonoBehaviour
{
    public GameObject infoPanel; // T�rkiye ile ilgili bilgilerin oldu�u panel

    private void OnMouseDown()
    {
        // T�rkiye'ye t�klan�nca paneli a�
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
        }
    }
}
