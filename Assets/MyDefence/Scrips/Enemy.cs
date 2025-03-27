using UnityEngine;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {
        //필드
        #region Field
        private float speed = 10f;

        private Vector3 targetPosition;
        private int wayPointIndex = 0;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            wayPointIndex =0;
            targetPosition = WayPoints.wayPoints[wayPointIndex].position;
        }

        // Update is called once per frame
        void Update()
        {
            //이동 구현
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(targetPosition, this.transform.position);
            if (distance <= 0.1f)
            {
                Debug.Log("도착");
                //new Vector3(-2, 1, -10);
                //다음 타겟 셋팅

                targetPosition = WayPoints.wayPoints[1].position;

                /*
                if()
                {
                    targetPosition = new Vector3(-8, 1, -5);
                }
                */
            }
        }
    }
}