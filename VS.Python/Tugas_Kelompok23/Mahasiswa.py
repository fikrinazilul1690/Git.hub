class Mahasiswa(object):
    """description of class"""
    def __init__(self):
        self.name = ""
        self.nim = 0
        self.smstr = 0
        self.ip1 = 0
        self.ip2 = 0
        self.ip3 = 0
        self.ip4 = 0
        self.ip5 = 0
        self.ip6 = 0
        self.ip7 = 0
        self.ip8 = 0
        self.ttlip = 0
        self.ipk = 0

    def setname(self,name):
        self.name = name
    def getname(self):
        return self.name
    def setnim(self,nim):
        self.nim = nim
    def getnim(self):
        return self.nim
    def setsmstr(self,smstr):
        self.smstr = smstr
    def getsmstr(self):
        return self.smstr
    def setip1(self,ip1):
        self.ip1 = ip1
    def setip2(self,ip2):
        self.ip2 = ip2
    def setip3(self,ip3):
        self.ip3 = ip3
    def setip4(self,ip4):
        self.ip4 = ip4
    def setip5(self,ip5):
        self.ip5 = ip5
    def setip6(self,ip6):
        self.ip6 = ip6
    def setip7(self,ip7):
        self.ip7 = ip7
    def setip8(self,ip8):
        self.ip8 = ip8
    def setttlip(self):
        self.ttlip = self.ip1 + self.ip2 + self.ip3 + self.ip4 + self.ip5 + self.ip6 + self.ip7 + self.ip8
    def getttlip(self):
        return self.ttlip
    def setipk(self):
        self.ipk = self.ttlip/(self.smstr - 1)
    def getipk(self):
        return self.ipk