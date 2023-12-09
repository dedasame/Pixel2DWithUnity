using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player; //Transform tipi: koordinat tutar ( Playerin koordinatlari)

    //Kamera Hareketi
    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        //transform kameranin koordinatlari = playerin x ve ysi ve onceden ayarlanmis z degerini tutmaya devam eder.

    }
}
