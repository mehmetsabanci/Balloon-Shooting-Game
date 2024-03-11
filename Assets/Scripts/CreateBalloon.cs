using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalloon : MonoBehaviour
{
    
    public float timeSayac = 0f;
    public float createBalonTime = 1f;
    [SerializeField]
    List<GameObject> RandomBalonPrefabs = new List<GameObject>();

    List<GameObject> balonlist = new List<GameObject>();
    OyunKontrol oyunKontrol;
    // Start is called before the first frame update
    void Start()
    {
        oyunKontrol= this.gameObject.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomBalloonUret();
    }
    public void RandomBalloonUret()
    {
            timeSayac -= Time.deltaTime;
            if (timeSayac < 0 && oyunKontrol.zamanSayaci>0)
            {
                GameObject go = Instantiate(RandomBalonPrefabs[Random.Range(0, 4)], new Vector3(Random.Range(-2.75f, 2.04f), -7f, 0), Quaternion.Euler(0, 0, 0));
            timeSayac = createBalonTime;
                balonlist.Add(go);
            }
        }
    }

