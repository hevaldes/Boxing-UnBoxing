# Boxing-UnBoxing
Boxing and Unboxing in C#

## Introducción

El lenguaje de programación C# tiene 2 tipos de dato: 

* Tipos por valor (Value Types)
* Tipos por referencia (Reference Types)

Los tipos por valor almacenan como tal solamente un valor, mientras que los tipos por referencia almacenan la dirección de memoria del valor que está almacenando. 

[Referencia](https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/data-types/value-types-and-reference-types "Value Types and Reference Types")

Algunos ejemplos de tipos por valor: int, float, double, decimal, bool, char, etc
Algunos ejemplos de tpos por referencia: object, string, array.

Normalmente, en el desarrollo tradicional se suele convertir de tipos por valor a tipos por referencia y viceversa. Este proceso tiene cierta característica dentro de .NET en relación al manejo de la memoria, lo que significa que .NET internamente hace ciertas operaciones para hacer estos cambios, los cuales son imperceptibles para los desarrolladores o clientes de las aplicaciones (hasta cierto punto).

Este proceso u operaciones internas se conoce como **_Boxing and Unboxing_**

---

## ¿Qué es el _Boxing_?

El _Boxing_ es el proceso de convertir un tipo de valor al tipo de objeto o cualquier tipo de interfaz implementado por este tipo de valor. El _Boxing_ es implícito.

```
int miMumero = 20; 
object miObjeto =miNumero; // Aquí se realiza el _Boxing_
```

Como se puede ver en el ejemplo anterior, la variable _miNumero_ es de tipo _int_ y es asignada a un tipo _object_ que es la variable _miObjeto_. 

La clase _object_ en _C#_ es la clase base de todas las clases en .NET, por ello, una variable como _miNumero_ de tipo _int_ puede asignarse a un tipo _object_. 

Este proceso de convertir un objeto _int_ a un tipo _object_ se conoce con el nombre de **_Boxing_**

El siguiente ejemplo, es un poco mas ilustrativo: 

```
ArrayList listaDatos = new ArrayList();
listaDatos.Add(10); // Aqui hay _Boxing_!!!
listaDatos.Add("Mexico");
```

En este ejemplo, ArrayList es una clase en _C#_, por lo que es un **tipo por referencia**. 
Luego, agregamos un valor int 10 en él, por lo que .NET realizará el proceso de _Boxing_ aquí para asignar el tipo por valor al tipo por referencia.

---

## ¿A que se debe el nombre de _Boxing_?

Todos los tipos por referencia almacenados en el [Heap](https://docs.microsoft.com/en-us/cpp/mfc/memory-management-heap-allocation?view=msvc-160 "Memory Management: Heap Allocation") donde contienen la dirección del valor y los tipos por valor, son almacenados en el [Stack](https://www.sciencedirect.com/topics/engineering/stack-memory "Stack Memory")

¿Como se ve gráficamente el primer ejemplo donde asignamos un tipo por valor a un tipo por referencia? En este caso, vemos como miNumero se asigna a miObjeto. 

La variable miObjeto es considerada una dirección de memoria y no una copia de esa dirección, es decir un tipo por valor. 

Entonces, lo que sucede es que el CLR coloca en una "caja" la variable miNumero creando un nuevo _System.Object_ en el _Heap_ y envuelve el valor de la variable _miNumero_ en el y finalmente al objeto le asigna una dirección de memoria.

Entonces, como el CLR crea una "caja" en el _Heap_ que almacena el valor, el proceso como tal se conoce como _Boxing_.

![Image](https://github.com/hevaldes/Boxing-UnBoxing/blob/main/assets/BoxUnbox_1.gif "SSH Key")