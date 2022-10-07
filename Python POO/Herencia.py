#Cración de una clase
class Persona:
    #constructor de atributos
    def __init__(self, name, age):
        self.name = name
        self.age = age
    
    #Cración de Métodos
    def saludar(self):
        if self.name == "Juan":
            print("hola, me llamo " + self.name)
        else:
            print("hola, me llamo " + self.name + " Mucho gusto")

P1=Persona("Juan",24)
print(P1.name)
print(P1.age)
P1.saludar()

print("______")

P2=Persona("Pepe",24)
print(P2.name)
print(P2.age)
P2.saludar()
P2.edad=30 # Crea el atributo de instancia edad
print(P2.edad)
'''
 Clase Empleado heredando de clase Persona
'''
class Empleado(Persona):
    
    #constructor de atributos
    def __init__(self, name, age, id, activo=False):
        '''
        Super() Esta función devuelve un objeto temporal de la superclase 
        que permite invocar a los métodos definidos en la misma.
        redefiniendo el método __init__ heredado
        '''
        super().__init__(name,age)
        self.id = id
        self.activo = activo

    def empleadoActivo(self):
        self.activo = True
        print("Estatus de empleado: Activo")

    def empleadoInactivo(self):
        self.activo = False
        print("Estatus de empleado: Inactivo")

    def imprimirEmpleado(self):
        print(self.name+"\n"+ str(self.age)+"\n"+ self.id+"\n"+ str(self.activo)+"\n")

    def saludar(self):
        print('Bienvenidos al Market, lo atiende ' + self.name)
    
   

E1=Empleado("Agustin",32,"QHS235491")
E1.imprimirEmpleado()
E1.empleadoActivo()
print(E1.activo)
E1.saludar()
