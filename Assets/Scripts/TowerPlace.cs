using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Color normal;
    [SerializeField] Color onMouse;

    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }
    private void Start()
    {
        render.material.color = normal;
        render.material.SetColor("_EmissionColor", Color.red * 10f);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Å¬¸¯");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        render.material.color = onMouse;
        render.material.SetColor("_EmissionColor", Color.white * 5f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        render.material.color = normal;
        render.material.SetColor("_EmissionColor", Color.red * 10f);

    }
}
