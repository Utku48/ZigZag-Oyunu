using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;

    public void SetRigidBodyValues()
    {
        /*Coroutine fonksiyonları ile bizim yaptığımızda bu sürekli çağrılma durumu yerine
         verdiğimiz sürelerde beklemeye geçip, komutlarımızın çalışmasını sağlamaktadır. 
         Örnek olarak=> Belirli aralıklarla ışıkları yakıp söndürmek
          silahın belirli aralıklarla ateşlenmesini sağlamak*/
        StartCoroutine(groundFallController.SetRigidBodyValues());
    }

}
