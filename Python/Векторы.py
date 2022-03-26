import math

class Vector():
    def __init__(self, x, y, z):
        self.x = x
        self.y = y
        self.z = z

    def __sub__(self, another):
        return Vector(self.x - another.x, self.y - another.y, self.z - another.z)

    def __mul__(self, another):
        return (self.x * another.x + self.y * another.y + self.z * another.z)

    def len(self):
        return (math.sqrt(self * self))

    def cMul(self, another):
        return Vector(
            self.y * another.z - another.y * self.z,
            -self.x * another.z + another.x * self.z,
            self.x * another.y - another.x * self.y
        )

for i in range(4):
    x, y, z, = map(float, input().split())
    if i == 0:
        a = Vector(x, y, z)
    elif i ==1:
        b = Vector(x, y, z)
    elif i == 2:
        c = Vector(x, y, z)
    else:
        d = Vector(x, y, z)
    


ab = b - a
bc = c - b
cd = d - c

x = ab.cMul(bc)
y = bc.cMul(cd)
cos = (x * y) / (x.len() * y.len())
phi = round(math.acos(cos) * 180 / math.pi, 2)
print(phi)
