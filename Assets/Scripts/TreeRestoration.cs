using UnityEngine;
using UnityEngine.EventSystems;

public class TreeRestoration : MonoBehaviour, IPointerClickHandler
{
    private Animator animator;
    private bool restored = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!restored)
        {
            animator.SetTrigger("Restore");
            restored = true;

            Debug.Log("Iniciando restauración del árbol");
        }
    }
}