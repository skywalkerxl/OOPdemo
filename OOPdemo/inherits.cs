using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPdemo
{
    public partial class inherits : Form
    {
        public inherits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("Husky", 4);
            dog.ShoutNum = 6;
            MessageBox.Show(dog.shout());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("Tom", 5);
            MessageBox.Show(cat.shout());
        }

        class Animal
        {
            protected string name = "";
            protected int shoutNum = 4;

            //  无参构造函数
            public Animal() { }

            //  带两个形参的构造函数
            public Animal(string name, int shoutNum)
            {
                this.name = name;
                this.shoutNum = shoutNum;
            }

            //  
            public int ShoutNum
            {
                get
                {
                    return shoutNum;
                }
                set
                {
                    shoutNum = value;
                }
            }

        }

        class Dog : Animal
        {
            public Dog() : base() { }
            public Dog(string name, int shoutNum) : base(name, shoutNum) { }

            public string shout()
            {
                string result = "";
                for(int i = 0; i < this.shoutNum; i++)
                {
                    result += "嗷!";
                }
                return "我的名字叫:" + this.name + "," + result;
            }
        }

        class Cat : Animal
        {
            public Cat() : base() { }
            public Cat(string name, int shoutNum) : base(name, shoutNum) { }

            public string shout()
            {
                string result = "";
                for (int i = 0; i < this.shoutNum; i++)
                {
                    result += "喵!";
                }
                return "我的名字叫:" + this.name + "," + result;
            }

        }

        
        /*class Dog
        {
            private string name = "Husky";
            private int shoutNum = 4;

            public string shout()
            {
                string result = "";

                for(int i = 0; i < this.shoutNum; i++)
                {
                    result += "嗷！";
                }

                return "我的名字叫:" + this.name + "," + result ;
            }
        }*/
    }
}
