class Animal:
    def __init__(self, name="默认", shoutNum=3):
        self.__name = name
        self.__shoutNum = shoutNum

    def shout(self):
        result = ''
        
        for i in range(self.__shoutNum):
            result += self.getShoutSound()

        return "我的名字叫：" + self.__name + "," + result

    def getShoutSound(self):
        return ""

    def get_shoutNum(self):
        return self.__shoutNum

    def set_shoutNum(self, shoutNum):
        self.__shoutNum = shoutNum
        

class Dog(Animal):
    def getShoutSound(self):
        return "嗷！"

dog = Dog("Husky")
dog.set_shoutNum(2)
print(dog.shout())