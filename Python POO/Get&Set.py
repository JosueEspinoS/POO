class Cuenta():
    def __init__(self ,propietario, saldo, moneda):#Encapsulamiento de atributos __
        self.__propietario= propietario
        self.__saldo = saldo
        self.__moneda =moneda

    #Getters (Métodos GET) Para obtener los valores
    def get_Saldo(self):
        return self.__saldo
    
    def get_Propietario(self):
        return self.__propietario
    
    def get_Moneda(self):
        return self.__moneda

    #Setters (Métodos SET) Para modificar el valor
    def set_Moneda(self, moneda):
        self.__moneda = moneda


cuenta1= Cuenta("Josue ES", 15000, "Peso Mxn")
print(cuenta1.get_Saldo())
print(cuenta1.get_Moneda())
cuenta1.set_Moneda("Dólar USA")
print(cuenta1.get_Moneda())