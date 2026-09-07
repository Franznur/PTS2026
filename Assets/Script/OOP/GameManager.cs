using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalKoin;
    private int koinTerkumpul = 0;

    void Start()
    {
        //Menghitung otomatis jumlah semua koin yang punya tag "Coin" di scene
        totalKoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        Debug.Log("Total koin di scene: " + totalKoin);
    }

    public void AmbilKoin()
    {
        koinTerkumpul++;

        //Jika koin yang terkumpul sama dengan total koin, panggil fungsi Menang
        if (koinTerkumpul == totalKoin)
        {
            Menang();
        }
    }

    void Menang()
    {
        //Pesan kemenangan di Console
        Debug.Log("KAMU MENANG!");
    }
}
