using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 _defaultPos;

    public Stack<GameObject> _bPool = new Stack<GameObject>();
    public Stack<GameObject> _bPoolAlive = new Stack<GameObject>();

    //private static BulletPoolManager privateInstance;

    //public static BulletPoolManager publicinstance
    //{
    //    get
    //    {
    //        if (privateInstance == null)
    //        {
    //            privateInstance = (new GameObject("container").AddComponent<BulletPoolManager>());
    //            Debug.Log("create");
    //        }

    //        return privateInstance;
    //    }
    //}

    //TODO: create a structure to contain a collection of bullets


    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("aa");
        _defaultPos = new Vector3(0.0f, 0.0f, 0.0f);
        // TODO: add a series of bullets to the Bullet Pool
        for (int i = 0; i <= 50; i++)
        {
            _bPool.Push(Instantiate(bullet, _defaultPos, Quaternion.identity));
            _bPool.Peek().SetActive(false);
        }

    }

    public void _Init()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {

        return bullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        _bPool.Push(bullet);
        _bPoolAlive.Pop();
    }
}
