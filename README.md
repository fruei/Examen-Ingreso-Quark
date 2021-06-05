# Examen Ingreso Quark
Este es mi solucion al examen de ingreso

## Contenido del proyecto
    1 Solucion
    1 Buckup de Base de Datos
    1 Diagrama de Clases UML

## Pasos para instalar

    Para abrir el proyecto solo hace falta clonar este repo, y abrir la solucion
    Primero hay que restaurar el archivo buckup BD del directorio "BuckupBD/Cotizador_Express_ExamenIngreso_Quark_BD.back"
    Luego se debe editar las cadenas de conexion que estan en los metodos del controller "controller/PrendasController.cs"
    Con esos pasos debe estar funcionando el proyecto

## Parte H
## Preguntas y Respuestas
    Nombre completo: Andres Emanuel Jara
    1. NO
    2. Cuando solamente quiera la estructura de esa clase y no la posibilidad de instanciarla como objeto
        EJ: La clase prenda solo la necesito para heredar atributos comunes entre sus hijos (Camisa, Pantalon),
            pero no deseo que nadie instancie un objecto del tipo Prenda
    3. Implica que una clase hijo hereda de una clase padre o super clase base
    4. Las interfaces no implementan la logica del metodo que declara,
            entonces solo definen parametros y valor de retorno de un metodo declarado en la interfaz, debe implementar la clase,
            y luego es esta misma quien define la implementacion de este metodo, su logica de aplicacion.
    5. En una relacion de composicion los objetos estan fuertemente ligados,
        quiere decir que si el objeto que tiene como atributos este otro objeto o esta constituido por otros objetos, muere,
        tambien lo hacen los demas objetos que forman parte de la composicion del primer objeto.
        En una relacion de agregacion los objetos no estan tan fuertemente ligados,
        quiere decir que si uno de los objetos en esta relacion, muere, el otro objeto u otros objetos, pueden seguir existiendo.

    6.Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
        a. V
        b. V
        c. F
