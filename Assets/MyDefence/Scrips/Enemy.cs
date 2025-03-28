using Unity.VisualScripting;
using UnityEngine;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {
        //필드
        #region Field
        private float speed = 5f;

        private Vector3 targetPosition;
        //wayPoint 오브젝트의 트랜스폼 객체 
        private Transform target;
        //wayPoint 배열의 인덱스
        private int wayPointIndex = 0;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            wayPointIndex =0;
            target = WayPoints.wayPoints[wayPointIndex];
        }

        // Update is called once per frame
        void Update()
        {
            //이동 구현
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance <= 0.1f)
            {
                //다음 타겟 셋팅
                GetNextTaget();


                /*
                if()
                {
                    targetPosition = new Vector3(-8, 1, -5);
                }
                */
            }
        }
        //다음 타겟 얻어오기
        void GetNextTaget()
        {
            if (wayPointIndex == WayPoints.wayPoints.Length -1)
            {
                Debug.Log("종점도착");
                Destroy(this.gameObject);
                return;
            }
            wayPointIndex++;
            target = WayPoints.wayPoints[wayPointIndex];

            Debug.Log($"wayPointIndex:{wayPointIndex}");
        }
    }
}