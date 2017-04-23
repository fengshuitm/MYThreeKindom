using UnityEngine;
using System.Collections;

public class Relationship {
	
	//����ID��
	public int [] mates=new int[Global_const.getInstance().MAXMATS];
	public int [] friends=new int[Global_const.getInstance().MAXFEIENDS];
	public int [] righteousbrothers=new int[Global_const.getInstance().MAXRIGHTEOUSBROTHERS];
	public Hashtable friendsLikeHash=new Hashtable();
	public int friendscount=0;//��������

	//���ܶ�list(�Է����Լ�),����ʶ����ΪNOID
	//public int [] likelist = new int[Global_const.getInstance().MAXHEROS];

	public int [] subordinateid = new int[Global_const.getInstance().MAXHEROS];//�����б�
	public int subordinatecount=0;//��������

	//�����佫
	public int Factions_leader_ID;


	//��������
	public int belong_kindom;//=Global_const.NONE_ID;

	//����struct list
	public Family m_family=new Family();// = new Family[Global_const.getInstance().MAXFAMILY];

	public Relationship()
	{
		
		Factions_leader_ID = Global_const.NONE_ID;

		for (int i = 0; i < Global_const.getInstance ().MAXHEROS; i++) {
			//likelist [i] = Global_const.NONE_ID;//
			subordinateid[i]=Global_const.NONE_ID;//
		}

		for (int i = 0; i < Global_const.getInstance ().MAXFEIENDS; i++) {
			friends[i]=Global_const.NONE_ID;//
		}


		for (int i = 0; i < Global_const.getInstance ().MAXMATS; i++) {
			mates [i]= Global_const.NONE_ID;//����ʶ
		}

		for (int i = 0; i < Global_const.getInstance ().MAXRIGHTEOUSBROTHERS; i++) {
			righteousbrothers [i]= Global_const.NONE_ID;//����ʶ
		}

	}



    public bool addMate(herodata _Selectedhero)
	{
		
		for (int i = 0; i < Global_const.getInstance ().MAXMATS; i++) {
			int IDtemp = mates [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				return false;
			}

			if (Global_const.NONE_ID == IDtemp) {
				mates [i] = _Selectedhero.id;

				return true;
			}

		}

		return false;

	}

	public bool DeleteMate(herodata _Selectedhero)
	{

		for (int i = 0; i < Global_const.getInstance ().MAXMATS; i++) {
			int IDtemp = mates [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				mates [i] = Global_const.NONE_ID;

				//�����ͳͳ��ǰ��һ��
				for (int j = i; j < (Global_const.getInstance ().MAXMATS-1); j++) {
					mates [j] = mates [j + 1];
				}
				mates [Global_const.getInstance ().MAXMATS-1]=Global_const.NONE_ID;

				return true;
			}

		}

		return false;

	}

	public bool AddSubordinate(herodata _Selectedhero)
	{

		for(int i = 0; i < Global_const.getInstance().MAXHEROS; i++) {
			int IDtemp = subordinateid [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				return false;
			}

			if (Global_const.NONE_ID == IDtemp) {
				subordinateid [i] = _Selectedhero.id;

				subordinatecount ++;

                _Selectedhero.m_relationship.belong_kindom = this.belong_kindom;

				return true;
			}

		}

		return false;

	}

	public bool DeleteSubordinate(herodata _Selectedhero)
	{

		for (int i = 0; i < subordinatecount; i++) {
			int IDtemp = subordinateid [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				subordinateid [i] = Global_const.NONE_ID;
			
				//�����ͳͳ��ǰ��һ��
				for (int j = i; j < (subordinatecount-1); j++) {
					subordinateid [j] = subordinateid [j + 1];
				}
				subordinateid [subordinatecount-1]=Global_const.NONE_ID;
				subordinatecount--;

				return true;
			}

		}

		return false;

	}

	public bool AddRighteousbrother(herodata _Selectedhero)
	{
		for (int i = 0; i <Global_const.getInstance().MAXRIGHTEOUSBROTHERS; i++) {
			int IDtemp = righteousbrothers [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				return false;
			}

			if (Global_const.NONE_ID == IDtemp) {
				righteousbrothers [i] = _Selectedhero.id;
				return true;
			}

		}

		return false;
	}

	public bool DeleteRighteousbrother(herodata _Selectedhero)
	{
		for (int i = 0; i < Global_const.getInstance().MAXRIGHTEOUSBROTHERS; i++) {
			int IDtemp = righteousbrothers [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				righteousbrothers [i] = Global_const.NONE_ID;

				//�����ͳͳ��ǰ��һ��
				for (int j = i; j < (Global_const.getInstance().MAXRIGHTEOUSBROTHERS-1); j++) {
					righteousbrothers [j] = righteousbrothers [j + 1];
				}
				righteousbrothers [Global_const.getInstance().MAXRIGHTEOUSBROTHERS-1]=Global_const.NONE_ID;
				return true;
			}

		}
		return false;

	}

	public bool AddFriends(herodata _Selectedhero)
	{

		for (int i = 0; i < Global_const.getInstance().MAXFEIENDS; i++) {
			int IDtemp = friends [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				return false;
			}

			if (Global_const.NONE_ID == IDtemp) {
				friends [i] = _Selectedhero.id;
				friendsLikeHash.Add (_Selectedhero.id, 0);
				friendscount ++;

                return true;
			}

		}

		return false;

	}

	public bool DeleteFriends(herodata _Selectedhero)
	{

		for (int i = 0; i < friendscount; i++) {
			int IDtemp = friends [i];

			//���д��佫
			if (IDtemp == _Selectedhero.id) {
				friends [i] = Global_const.NONE_ID;
				friendsLikeHash.Remove (_Selectedhero.id);

				//�����ͳͳ��ǰ��һ��
				for (int j = i; j < (friendscount-1); j++) {
					friends [j] = friends [j + 1];
				}
				friends [friendscount-1]=Global_const.NONE_ID;
				friendscount--;

				return true;
			}

		}

		return false;

	}

}
