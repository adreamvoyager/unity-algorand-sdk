using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NftDisplayBox : MonoBehaviour
{

    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI nameText, idText;


    public void setFields(Texture texture, string name, string id)
    {

        nameText.text = name;
        idText.text = id;


        Sprite sprite = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

        image.sprite = sprite;

    }    


}
