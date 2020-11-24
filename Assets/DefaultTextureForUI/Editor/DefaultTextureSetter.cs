using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CustomEditor(typeof(CanvasRenderer), true)]
[CanEditMultipleObjects]
public class DefaultTextureSetter : Editor
{
    public Sprite defaultSprite;
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var script = (Component)target;
        var imageComponent = script.GetComponent<Image>();
        if (imageComponent != null && imageComponent.sprite == null)
        {
            imageComponent.sprite = defaultSprite;
            return;
        }

        var rawImageComponent = script.GetComponent<RawImage>();
        if (rawImageComponent != null && rawImageComponent.texture == null)
        {
            rawImageComponent.texture = defaultSprite.texture;
        }
    }
}