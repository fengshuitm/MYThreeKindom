using UnityEngine;
using System.Collections;


public class Global_const {

	public int MAXMATS=10;//��ż�����
	public int MAXFEIENDS=300;//��������
	public int MAXRIGHTEOUSBROTHERS=10;//���ֵ������

	public int MAXHEROS=2000;//Ӣ������
	public int MAXBACKS=1000;//Ӣ������

    public const int MAXFRIENDLIKE = 100;//Ӣ������

    public const int MAXARMYHERONO = 5;//����Ӣ������


    public const int MAXIMPORTANCE=200;//�ݵ�����

	public int MAXFAMILY=100;//family����
	
	public int MAXSKILLTYPE_COUNT=50;//�ܼ���������
	public int MAXSKILL_COUNT=6;//���˼��������
	public int MAX_S_SKILL_COUNT=2;//����S���������

	public int BGINSILL_COUNT=5;
	
	public int MAXKINDOM_COUNT=50;//��������

    public const int MAXFACERESOURCE = 50;//��Դ��

    public int GrownUp=15;
	public const int NONE_ID=-1;//��ЧID

	public const int BIGNO=100000;//BIG
	public const int SMALLNO =-100000;//BIG

	public int BATTLE_WORKS_NUM=4;

	//public const float CellSizeX =0.16f;
    //public const float CellSizeY = 0.16f;

    enum family_enum {FAMILY_BROTHER,FAMILY_SWORN_BROTHER,FAMILY_MATE,FAMILY_FATHER,FAMILY_MOTHER,FAMILY_FATHER_INLAW,FAMILY_MOTHER_INLAW,FAMILY_OTHERS};
	
	private static  Global_const instance = new Global_const(); 
	private Global_const(){} 
	
	  public static Global_const  getInstance() 
	  { 
		  
	   return instance; 
	  }


}
