using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //Amaci: Kullanan nesneyi z ekseninde dondurmek icin kullaniriz.


    [SerializeField] private float speed = 1f; //kac kez ters cevirecegimizi ayarlamak icin.



    
     private void Update()
    {
        transform.Rotate(0,0,360*speed*Time.deltaTime); //x,y ve z eksenine dondurme acisi: 2d old icin z ekseninde dondururuz.


        
    }


}
