class Animal:
    def __init__(self, name="默认", shoutNum=3):
        self.name = name
        self.shoutNum = shoutNum

class Dog(Animal):
    def shout(self):
        result = ''
        
        for i in range(self.shoutNum):
            result += '嗷!'
        
        return '我的名字叫:' + self.name + ',' + "叫声是：" + result
    pass

class Cat(Animal):
    def shout(self):
        result = ''
        
        for i in range(self.shoutNum):
            result += '喵!'
        
        return '我的名字叫:' + self.name + ',' + "叫声是：" + result
    pass

dog = Dog("Husky");
cat = Cat("Tom");

print(dog.shout())
print(cat.shout())