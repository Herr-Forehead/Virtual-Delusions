using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Controller : MonoBehaviour
{

    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    Transform katanaBlade;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void PullTrigger()
  {
    Instantiate(bulletPrefab, katanaBlade.position, katanaBlade.rotation);
  }

}
