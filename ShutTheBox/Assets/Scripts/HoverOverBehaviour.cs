using TMPro;
using UnityEngine;

public class HoverOverBehaviour : MonoBehaviour
{
    private TextMeshPro _textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshPro>();
        _textMeshPro.color = Color.white;
    }

    private void OnMouseEnter()
    {
        _textMeshPro.color = Color.green;

        if (_textMeshPro.text == "Quit")
        {
            _textMeshPro.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        _textMeshPro.color = Color.white;
    }
}