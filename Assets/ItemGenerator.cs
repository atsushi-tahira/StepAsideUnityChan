using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour {
	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;
	//アイテムを自動生成する際のプレイヤー情報
	private GameObject target;
	//プレイヤーの位置情報
	private int zPos;
	//1秒ごとにループさせるための値
	private int oncePos;

	void Start () {
		target = GameObject.Find("unitychan");
	}
		
	void Update () {
		//プレイヤーの位置情報をint型に変換
		zPos = Mathf.CeilToInt(target.transform.position.z);
		//z軸が15毎に一度だけアイテムを生成するように設定
		bool once = zPos != oncePos ? true : false;
		//アイテムの生成位置
		int interval = zPos + 50;
		if (zPos % 15 == 0 && once == true && interval < 130) {
			
			//どのアイテムを出すのかをランダムに設定
			int num = Random.Range (1, 11);
			if (num <= 2) {
				//コーンをx軸方向に一直線に生成
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, interval);
				}
			} else {

				//レーンごとにアイテムを生成
				for (int j = -1; j <= 1; j++) {
					//アイテムの種類を決める
					int item = Random.Range (1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 6);
					//60%コイン配置:30%車配置:10%何もなし
					if (1 <= item && item <= 6) {
						//コインを生成
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y,interval + offsetZ);
					} else if (7 <= item && item <= 9) {
						//車を生成
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y,interval + offsetZ);
					}
				}
			}
			oncePos = zPos;
		}
	}
}