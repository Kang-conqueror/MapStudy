using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



namespace Map
{
    public class MapManager : MonoBehaviour
    {
        //MapManager Class ����

        public Map CurMap; //���� Map�� ������ ����

        [SerializeField]
        public List<NodeList> nodeList;

        [SerializeField]
        public List<NodeSprite> nodeSprites; //NodeSprite ���� ������ List

        [SerializeField]
        public NodeList nodes; // nodeList�� �ִ� �͵� �� Ȱ���� node�� ������ ���� 

        public static MapManager instance;

        //�̱��� ���� ����
        private void Awake()
        {
            instance = this;

        }

        //���� �� ����� �Լ�
        private void Start()
        {            
            nodeList.Add(new NodeList_1()); //NodeList_1 �߰�

        }

        //���� �� ����� �Լ�
        private void OnApplicationQuit()
        {
            
        }


    }


}

