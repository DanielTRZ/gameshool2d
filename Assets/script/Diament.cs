using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Diament : MonoBehaviour
{

    [SerializeField] float speed;
   // float x = 1f;
    bool increase;




    void Update()
    {
     //   if (increase)
     //   {
      //      x += speed * Time.deltaTime;
      //      if (x > 1f)
     //       {
             //  increase = false;
    //        }
      //  }

     //   else
      //  {
      //      x -= speed * Time.deltaTime;
       //     if (x < 0.1f)
       //     {
        //        {
        //            increase = true;
       //         }
       //         transform.localScale = new Vector3(x, 1f, 1f);
      //      }
      //  }


    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectable"))
        {
            print("mamy to");
            Destroy(collision.gameObject);

            ScoreMenager.instance.AddPoint();


        }
    }
}


