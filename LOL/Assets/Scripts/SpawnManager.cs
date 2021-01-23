using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("生成物件")]
    public GameObject goSpawn;
    [Header("生成點")]
    public Transform pointSpawn;
    [Header("生成間隔"), Range(0, 30)]
    public float interval = 10f;
    [Header("每波小兵出生間隔"), Range(0, 10)]
    public float intervalOnece = 0.2f;
    [Header("每波小兵出生數量"), Range(0,4)]
    public int count = 4;

    /// <summary>
    /// 數量計數器
    /// </summary>
    int current;

    /// <summary>
    /// 生成小兵
    /// </summary>
    void Spawn()
    {
        // 如果 目前小兵數 < 每波數量
        if (current < count)
        {
            Instantiate(goSpawn, pointSpawn.position, pointSpawn.rotation);
            current++;
            Invoke("Spawn", intervalOnece); // 延遲呼叫("方法名稱", 延遲時間)
        }
        else current = 0;
    }

    private void Start()
    {
        // 重複呼叫("方法名稱", 開始時間, 間隔時間)
        InvokeRepeating("Spawn", 0, interval);
    }
}

