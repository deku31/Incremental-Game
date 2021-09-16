using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCoin : MonoBehaviour
{
    // list gambar koin
    public List<Sprite> img;
    public Image coin;

    //menentukan koin yg akan dipakai
    public int _coin;
    public Transform _changeCoin;
    public SpriteRenderer Coin;

    public bool Open;
    // Start is called before the first frame update
    void Start()
    {
        _coin = 0;
    }
    //menukar koin selanjutnya
    public void next ()
    {
        if (_coin<img.Count-1)
        {
            _coin++;
        }
        //jika telah mencapai akhir kembali ke koin awal
        else
        {
            _coin = 0;
        }
    }
    //menukar koin sebelumnya
    public void back() 
    {
        if (_coin>0)
        {
            _coin--;
        }
        //jika mencapai awal akan ke koin akhir
        else
        {
            _coin = img.Count-1;    
        }
    }
    //memilih koin yang ingin digunakan
    public void pilih() 
    {
        Coin.sprite = img[_coin];
    }
    //tombol keluar
    public void close() 
    {
        Open = false;
    }
    //tombol buka tukar koin
    public void open() 
    {
        Open = true;
    }
    void Update()
    {
        coin.sprite = img[_coin];
        //amimasi muncul panel
        if (Open==true)
        {
            _changeCoin.localScale = Vector3.LerpUnclamped(_changeCoin.localScale, Vector3.one, 0.5f);
        }
        //animasi close panel
        else
        {
            _changeCoin.localScale = Vector2.LerpUnclamped(_changeCoin.localScale, Vector3.up, 0.5f);
        }
    }
}
