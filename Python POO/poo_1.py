class Coche():  #Creación de la clase

    #Creación de atributos
    largoChisis = 250 
    anchoChasis = 120
    ruedas = 4
    enmarcha = False

    #Creación de métodos
    def arrancar(self, arrancamos):
        self.enmarcha = arrancamos

        if(self.enmarcha):
            return "El Coche est[a en marcha"
        else:
            return "El coche est[a parado"
       

    def estado(self):
        print("El coche tiene",self.ruedas,"Ruedas, un ancho de ",self.anchoChasis," y un largo de ",self.largoChisis)
        

miCoche = Coche()


print(miCoche.arrancar(True))

miCoche.estado()


print("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-")

miCoche2 = Coche()
print("El largo del coche es", miCoche2.largoChisis)
print("El coche tiene ", miCoche2.ruedas, " ruedas")

miCoche2.estado()
print(miCoche2.arrancar(False))
    