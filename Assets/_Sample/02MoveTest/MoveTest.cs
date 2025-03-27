using UnityEngine;
namespace Sample
{
    public class MoveTest : MonoBehaviour
    {
        //필드
        //이동 속도
        private float speed = 5f;
        
        //이동목표 지정
        Vector3 targetposition = new Vector3(7f, 1f,8f);

        //Transform transform;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.tranceform
            //: MoveTest 클래스가 붙어있는 게임 프로젝트의 Transform 인스턴스
            //this.transform.position =new Vector3(7f, 1f,8f);
            //transform.position = new Vector3(7f, 1f, 8f);
            //Debug.Log(this.transform.position);
        }

        // Update is called once per frame
        void Update()
        {
            // this.transform.position = this.transform.position.z +1

            //뒤, 좌, 우,위
            //this.transform.position += new Vector3(0f, 0f, -0.01f);
            //Debug.Log("뒤");

            //this.transform.position += new Vector3(0f, 0f, 0.01f);
            //Debug.Log("앞");

            //this.transform.position += new Vector3(0f, 0f, -0.01f);
            //Debug.Log("아래");

            //this.transform.position += new Vector3(0f, 0.01f, 0f);
            //Debug.Log("위");

            //this.transform.position += new Vector3(0.01f, 0f, 0f);
            //Debug.Log("우");

            //this.transform.position += new Vector3(-0.01f, 0f, 0f);
            //Debug.Log("좌");

            //this.transform.position += Vector3. forward;
            //this.transform.position += Vector3. right;

            //속도
            // 앞 방향으로 1초에 1Unit 만큼 이동
            //this.transform.position += new Vector3.forward * Time.deltaTime;

            // 앞 방향으로 1초에 speed(5)Unit 만큼 이동
            //this.transform.position += new Vector3.forward * Time.deltaTime * speed;

            //Transmate :이동 함수
            //방향 : 앞방향
            //Time.deltaTime : 동일한 시간에 동일한 거리를 이동하게 해준다.
            //speed :이동속도 - 초당 이동하는 거리
            //Vector3 * Float * float => Vector3
            this.transform.Translate(Vector3.forward  * Time.deltaTime * speed);
            // 이동 방향 구하기 : (목표위치 - 현재위치)
            // dir.magnitude : 벡터의 크기, 길이
            // dir.magnitude : 길이가 1인 벡터
            //Vector3 dir = targetposition - this.transform.position;
            //transform.Translate(dir.normalized * Time.deltaTime * speed);

            //space.World, Space.Self
            //transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
            

        }
    }
}
/*
1.앞, 뒤, 좌, 우로 이동하기
2. 5의 속도로 이동하기
3. 목표지점(7, 1, 8)으로 이동하기
4. 목표지점 도착 판정

1 unit => 1m
*/
/*
n 프레임: 초당 n 번 실행하기 (보여주기)
20프레임 - 1프레임 보여주는데 0.05초 걸린다
FPS : 1프레임 보여주는데 걸리는 시간(초)



//Unity
Time.deltaTime: 1프레임을 실행하는데 걸리는 시간
1 frame

PC 1 :성능이 좋은 컴퓨터
10 Frame 1초 10만큼이동
Time.deltaTime 값 : 0.1f


//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;



PC 2 :성능이 나쁜 컴퓨터 - 프레임 저하, 드랍
2 Frame - 1초 2만큼 이동
Time.deltaTime 값 : 0.5
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;
//this.transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * 20;

방향 * 속도 * Time.deltaTime 













*/