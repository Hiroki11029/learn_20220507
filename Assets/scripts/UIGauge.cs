using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIGauge : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    public void OnChangeValue(float value)
    {
        //TransformクラスをRectTransformにキャスト
        //C++; var rect = (RectTransform)transform;

        //構造体(Vector等)の変数にアクセスする書き方
        //var rect = transform as RectTransform;
        //var anchorMax = rect.anchorMax;
        //anchorMax.x = value;
        //rect.anchorMax = anchorMax;

        //slider.value = value;
    }
}
