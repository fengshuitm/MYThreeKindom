using UnityEngine;
using System.Collections;

public class Mission  {

	//��ǰ����
	int Now_mission;
	//��ǰ��Ϊ
	int Now_action;
	//�ϸ�������ɹ�
	int LastMonth_Achievements;
	
	public void ClearLastMonth()
	{
		LastMonth_Achievements=0;
	}

}
