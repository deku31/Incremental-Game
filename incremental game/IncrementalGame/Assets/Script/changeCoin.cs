using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCoin : MonoBehaviour
{
    public List<Sprite> img;
    public Image coin;
    public int _coin;
    public Transform _changeCoin;
    public SpriteRenderer Coin;

    public bool Open;
    // Start is called before the first frame update
    void Start()
    {
        _coin = 0;
    }
    public void next ()
    {
        if (_coin<img.Count-1)
        {
            _coin++;
        }
        else
        {
            _coin = 0;
        }
    }
    public void back() 
    {
        if (_coin>0)
        {
            _coin--;
        }
        else
        {
            _coin = img.Count-1;    
        }
    }
    public void pilih() 
    {
        Coin.sprite = img[_coin];
    }
    public void close() 
    {
        Open = false;
    }
    public void open() 
    {
        Open = true;
    }
    // Update is called once per frame
    void Update()
    {
        coin.sprite = img[_coin];

        if (Open==true)
        {
            _changeCoin.localScale = Vector3.LerpUnclamped(_changeCoin.localScale, Vector3.one, 0.5f);
        }
        else
        {
            _changeCoin.localScale = Vector2.LerpUnclamped(_changeCoin.localScale, Vector3.up, 0.5f);
        }
    }
}
