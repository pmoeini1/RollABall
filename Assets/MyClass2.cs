using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass2 : MonoBehaviour
{
    MyClass c = new MyClass();

    // Update is called once per frame
    void Update()
    {
        int x = c.num;
        print(c.ReturnNum());
        c.num = x+1;
        print(c.num);
        
    }

    public class MyClass {
        private int _num = 0;
        private int c = 0;
        public int num{
            get {
                _num += 2;
                return (_num);
            }
            set {
                _num = value;
            }
        }
        public int ReturnNum() {
            c++;
            return(c);
        }
    }


}
