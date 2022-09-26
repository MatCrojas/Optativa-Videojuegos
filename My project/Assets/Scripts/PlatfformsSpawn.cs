using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfformsSpawn : MonoBehaviour
{
    public Vector2 randRange;

    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnPlatform");
    }


    private IEnumerator spawnPlatform()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            GameObject instance = Instantiate(platform, transform.position, Quaternion.identity);
            instance.transform.localScale = new Vector3(instance.transform.localScale.x,
                instance.transform.localScale.y,
                Random.Range(randRange.x, randRange.y));

            Time.timeScale *= 1.1f;
            
        }
    }
}
