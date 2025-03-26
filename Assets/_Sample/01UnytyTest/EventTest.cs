using UnityEngine;

public class EventTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("[1]Awake 실행"); //1회만 실행
    }

    private void OnEnable()
    {
        Debug.Log("[6-1]OnEnable 실행"); //(활성화 될때) 1회 실행
    }

    private void OnDisnable()
     {
        Debug.Log("[6-2]OnDisnable 실행"); //(비활성화 될때) 1회 실행
     }
    private void OnDstory()
    {
        Debug.Log("[7]OnDstory 실행"); // 소멸 될 때 1회만 실행
    }


    private void Start()
    {
        Debug.Log("[2]Start 실행"); //1회만 실행
    }

    private void FixedUpdate()
    {
        Debug.Log("[3]FixedUpdate 실행"); //1초에 50프레임 고정
    }

    private void Update()
    {
        Debug.Log("[4]Update 실행"); //매 프레임마다 호출
    }
    private void LateUpdate()
    {
        Debug.Log("[5]LateUpdate 실행"); //Update 실행 뒤에 바로 따라서 실행
    }

    
}
