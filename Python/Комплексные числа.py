import math

class Complex():
    def __init__(self, re, im):
        self.re = re
        self.im = im
    
    def __add__(self, another):
        return Complex(self.re + another.re, self.im + another.im)

    def __sub__(self, another):
        return Complex(self.re - another.re, self.im - another.im)

    def __mul__(self, another):
        return Complex(self.re * another.re - self.im * another.im, self.re * another.im + self.im * another.re)

    def __truediv__(self, another):
        return Complex((self.re * another.re + self.im * another.im) / (another.re ** 2 + another.im ** 2), (-self.re * another.im + self.im * another.re) / (another.re ** 2 + another.im ** 2))
   
    def mod(self):
        return Complex(math.sqrt(self.re * self.re + self.im * self.im), 0)

for i in range(2):
    num1, num2 = map(float, input().split())
    if i == 0:
        c = Complex(num1, num2)
    else:
        d = Complex(num1, num2)


for i in range(6):
    if i == 0:
        s = c + d
    elif i == 1:
        s = c - d
    elif i == 2:
        s = c * d
    elif i == 3:
        s = c / d
    elif i == 4:
        s = c.mod()
    else:
        s = d.mod()
    if s.im >= 0:
        st = '+'
    else:
        st = ''
    print("%.2f" % s.re + st + "%.2f" % s.im + 'i')
