using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public SpriteRenderer mapColor;//获取地图的render
    private Color mcolor;
    

    private void Start()
    {
        StartColor();
    }
    /// <summary>
    /// 改变游戏地图和背景颜色
    /// </summary>
    private void StartColor()
    {
        mcolor = new Color(Random.Range(0, 256) / 255f, Random.Range(0, 256) / 255f, Random.Range(0, 256) / 255f);
        mapColor.color = mcolor;

        mcolor = new Color(Random.Range(0, 256) / 255f, Random.Range(0, 256) / 255f, Random.Range(0, 256) / 255f);
        Camera.main.backgroundColor = mcolor;
    }
}
