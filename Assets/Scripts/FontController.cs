using TMPro;
using UnityEngine;

public class FontController : MonoBehaviour
{
    public TMP_Text targetText;

    public void IncreaseFontSize()
    {
        if (targetText.fontSize < 60)
        {
            targetText.fontSize += 2;
        }
    }

    public void DecreaseFontSize()
    {
        if (targetText.fontSize > 20)
        {
            targetText.fontSize -= 2;
        }
    }
}