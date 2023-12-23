using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikincihafta : MonoBehaviour
{

    ArrayList bireBölünenler= new ArrayList();
    ArrayList ikiBölünenler= new ArrayList();
    ArrayList üçeBölünenler= new ArrayList();
    ArrayList dördeBölünenler= new ArrayList();
    ArrayList beşeBölünenler= new ArrayList();

    public int ilk;
    public int iki;

    // Start is called before the first frame update
    void Start()
    {
        aralik(ilk,iki);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void aralik(int ilk,int iki) {
        {
            for (int i= ilk; i<= iki; i++)
            {
                if(i%1==0)
                {
                    bireBölünenler.Add(i);
                }
            }

            
            for (int i= ilk; i<= iki; i++)
            {
                if(i%2==0)
                {
                    ikiBölünenler.Add(i);
                }
            }

             for (int i= ilk; i<= iki; i++)
            {
                if(i%3==0)
                {
                    üçeBölünenler.Add(i);
                }
            }

             for (int i= ilk; i<= iki; i++)
            {
                if(i%4==0)
                {
                    dördeBölünenler.Add(i);
                }
            }

             for (int i= ilk; i<= iki; i++)
            {
                if(i%5==0)
                {
                    beşeBölünenler.Add(i);
                }
            }


            foreach (var item in bireBölünenler)
            {
                print("bire bölünenler"+ item);
            }

             foreach (var item in ikiBölünenler)
            {
                print("ikiye bölünenler"+ item);
            }

             foreach (var item in üçeBölünenler)
            {
                print("üçe bölünenler"+ item);
            }

             foreach (var item in dördeBölünenler)
            {
                print("dörde bölünenler"+ item);
            }

             foreach (var item in beşeBölünenler)
            {
                print("beşe bölünenler"+ item);
            }
        }
    }
}
