using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



namespace Map
{
    //Node Class�� ����
    public class Node : MonoBehaviour
    {
        public Point point; //Node�� ��ǥ���� ������ Point �� ����
        public List<Node> connected; //�� Node�� ����� �ٸ� Node�� ��ǥ�� ������ List
        public NodeType nodeType; //NodeType�� ������ ����
        public Vector2 position; //���� ��ġ�� ǥ���� Vector2 ����
        public NodeStates state = NodeStates.Locked; //NodeStates�� ������ ����, �ʱ�� Locked�� ����.
        public SpriteRenderer sR; //SpriteRender ���� ����
        public Image image; //Image ���� ����



        //Node Class�� �� �ֱ�?
        public Node(NodeType nodeType, Point point)
        {
            this.nodeType = nodeType;
            this.point = point;
            position = new Vector2(this.point.x, this.point.y);
       }



        //Node Class�� �� �ֱ�?
        public Node(NodeType nodeType, Point point, List<Node> connected)
        {
            this.nodeType = nodeType;
            this.point = point;
            this.connected = connected;
            position = new Vector2(this.point.x, this.point.y);
        }


        public void addInfo(Node n)
        {
            point = n.point;
            connected = n.connected;
            nodeType = n.nodeType;
            position = n.position;
            state = n.state;

        }//addInfo



        //Node ���� ������ �߰��ϴ� �Լ� 
        public void AddConnections(Node n)
        {
            if (connected.Any(e => e.point.Equals(n.point)))
                return;

            connected.Add(n);

        }//AddConnections


        //Node�� ���� ������ �����ϴ� �Լ�
        public void RemoveConnections(Node n)
        {

            connected.RemoveAll(e => e.point.Equals(n.point));

        }//RemoveConnections


        //Node�� �̹��� ����? �ϴ� �Լ�
        public void setUp()
        {
            sR.sprite = MapManager.instance.nodeSprites.FirstOrDefault(nS => nS.nodeType == this.nodeType).sprite;
            image.sprite = MapManager.instance.nodeSprites.FirstOrDefault(nS => nS.nodeType == this.nodeType).sprite;

        }//setUp





    }//Node Class

}

 
