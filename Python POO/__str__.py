class Curso():
    def __init__(self,nombre,creditos,profesion):
        self.nombre = nombre
        self.creditos = creditos
        self.profesion = profesion
        self.__imparticion = "Presencial"# Propiedad encapsulada.
        
    def mostrarDatos(self):
        dat="Nombre: {0} / Créditos: {1} / Modo de impartición: {2}"
        print(dat.format(self.nombre,self.creditos,self.__imparticion))
        docenteAsignado = self.__verificarDocente()
        if docenteAsignado:
            print("Existe docente asignado")
        else:
            print("No es necesario asignar un docente")

    #Encapsulamiento de una función
    def __verificarDocente(self):
        #print('Verificando si existe docente asignado...')
        if self.__imparticion == "Presencial":
            return True
        else:
            return False

    def __str__(self):#Definir que mostrar cuando imprimas un objeto o una instancia de una clase
        texto="Nombre: {0} / Créditos: {1}"
        return texto.format(self.nombre,self.creditos)

curso1= Curso("Matemáticas",5,"Ing Civil")
print(curso1.nombre)
curso1.mostrarDatos()
print('***** Imprimiento con el formato __Str__ *****')
print(curso1)

#curso2= Curso("Lenguaje",4,"Ing Industrial")
#print(curso2.nombre)

