using JetBrains.Annotations;
using System.Threading;
using System.Collections;
using UnityEngine;
using TMPro;
namespace MyDefence
{
    public class WaveManager : MonoBehaviour
    {
        #region Field
        public GameObject enemyPrefab;
        public Transform startPoint;

        //타이머
        public float waveTimer =5f;
        public float countdown = 0f;

        public int waveCount = 0;

        //UI
        public TextMeshProUGUI countdowntext;
        #endregion
        //Enemy 스폰. 웨이브를 관리하는 스크립트
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            countdown = 3f;
            waveCount = 0;
        }

        // Update is called once per frame
        void Update()
        {
            
            countdown += Time.deltaTime;
            if (countdown >= waveTimer)
            {
                //타이머 기능
                StartCoroutine(Spawnwave());

                //타이머 초기화
                countdown = 0f;
            }
            //UI
            countdowntext.text = Mathf.Round(countdown).ToString();
        }
        //시작지점에 enemy 스폰
        void SpawnEnemy()
         {
            //시작지점에 enemy 한마리 스폰
            Instantiate(enemyPrefab, startPoint.position, Quaternion.identity);
         }
        //웨이브
        IEnumerator Spawnwave()
        {
            waveCount++;
            Debug.Log($"{waveCount} wave");

            for (int i = 0; i < waveCount; i++)
            {
                SpawnEnemy();

                //일정시간 지연 
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}