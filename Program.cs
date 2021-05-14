using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO9_POO
{
    class Alumno
    {
        private string nombre;
        private int edad;

        //Constructor
        public Alumno(string n, int e)
        {
            this.nombre = n;
            this.edad = e;
        }

        public void ImprimeAlumno()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }

        public void EsMayorEdad()
        {
            if (this.edad >= 18) 
            {
                Console.WriteLine("Es mayor de edad");
            }
        }
    }

    class Empleado
    {
        private string nombre;
        private decimal sueldo;

        //Constructor
        public Empleado(string nombre, decimal sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void ImprimeEmpleado()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Sueldo:" + sueldo);
        }

        public decimal Sueldo
        {
            get { return sueldo; }
        }

    }

    class Operacion
    {
        private int valor1;
        private int valor2;

        public Operacion(int valor1,int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public void ImprimeValores()
        {
            Console.WriteLine("Valor 1:" + this.valor1);
            Console.WriteLine("Valor 2:" + this.valor2);
        }

        public int Suma()
        {
            return this.valor1 + this.valor2;
        }

        public int Resta()
        {
            return this.valor1 - this.valor2;
        }

        public int Multiplicacion()
        {
            return this.valor1 * this.valor2;
        }

        public int Division()
        {
            return this.valor1 / this.valor2;
        }
    }

    class Persona
    {
        private string nombre;

        //Constructor
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + this.nombre);
        }
    }//clase persona

    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        public Libro(string autor,string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

        public string GetAutor {
            get { return autor; }
        }

        public string GetTitulo
        {
            get { return titulo; }
        }

        public string GetUbicacion
        {
            get { return ubicacion; }
        }


        public void SetAutor(string valor)
        {
             autor = valor;
        }

        public void SetTitulo(string valor)
        {
            titulo = valor;
        }

        public void SetUbicacion(string valor)
        {
            ubicacion = valor;
        }

        public string Titulo { get => titulo; set => titulo = value; }
    }

    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private decimal potencia;

        public Coche(string marca,string modelo,int cilidrada,decimal potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilidrada;
            this.potencia = potencia;
        }

        public void MostrarDatosCoche()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("cilindrada: " + cilindrada);
            Console.WriteLine("potencia: " + potencia);

        }
    }//Coche

    class Persona2
    {
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private int peso;
        private double altura;

        //Constructor por defecto
        public Persona2(string DNI)
        {
            this.nombre = "";
            this.edad = 0;
            this.DNI = DNI;
            this.sexo = 'M';
            this.peso = 0;
            this.altura = 0;
        }

        public Persona2(string DNI, string nombre,int edad,char sexo)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.edad = edad;            
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }

        public Persona2(string DNI, string nombre, int edad, char sexo,int peso,double altura)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public void Mostrardatos()
        {
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("NOMBRE: " + nombre);
            Console.WriteLine("EDAD: " + edad);
            Console.WriteLine("SEXO: " + sexo);
            Console.WriteLine("PESO: " + peso);
            Console.WriteLine("ALTURA: " + altura);
        }

    }//PERSONA 2

    class Password
    {
        private int longitud;
        private string contraseña;

        public Password()
        {
            this.longitud = 8;
            this.contraseña = "";
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            //Genera la contraseña con esa longitud
            Random r = new Random();
            //Armar rango por la longitud
            
            string inicial = "1";
            string final = "9";

            for (int i = 0; i < longitud - 1; i++)
            {
                inicial = inicial + "0";
                final = final + "9";
            }
            

            this.contraseña = Convert.ToString(r.Next(Convert.ToInt32(inicial), Convert.ToInt32(final)));
        }

        public void Mostrardatos()
        {
            Console.WriteLine("LONGITUD: " + longitud);
            Console.WriteLine("CONTRASEÑA: " + this.contraseña);

        }
    }//Password

    class Electrodomestico
    {
        private double precio_base;
        private string color;
        private char consumo_energetico;
        private int peso;

        //Constructor por defecto
        public Electrodomestico()
        {
            this.precio_base = 100;
            this.color = "blanco";
            this.consumo_energetico = 'F';
            this.peso = 5;
        }
   
        public Electrodomestico(double precio_base,int peso)
        {
            this.precio_base = precio_base;
            this.color = "blanco";
            this.consumo_energetico = 'F';
            this.peso = peso;

        }
        public Electrodomestico(double precio_base, string color,char consumo_energetico,int peso)
        {
            this.precio_base = precio_base;
            this.color = color;
            this.consumo_energetico = consumo_energetico;
            this.peso = peso;            
        }

        public void Mostrardatos()
        {
            Console.WriteLine("PRECIO BASE: " + precio_base);
            Console.WriteLine("COLOR: " + color);
            Console.WriteLine("CONSUMO ENERGETICO: " + consumo_energetico);
            Console.WriteLine("PESO: " + peso);
        }

    }

    class Serie
    {
        private string titulo;
        private int numero_temporadas;
        private bool entregado;
        private string genero;
        private string creador;

        public Serie()
        {
            this.titulo = "";
            this.numero_temporadas = 3;
            this.entregado = false;
            this.genero = "";
            this.creador = "";
        }

        public Serie(string titulo,string creador)
        {
            this.titulo = titulo;
            this.numero_temporadas = 3;
            this.entregado = false;
            this.genero = "";
            this.creador = creador;
        }

        public Serie(string titulo, int numero_temporadas, string genero,string creador)
        {
            this.titulo = titulo;
            this.numero_temporadas = numero_temporadas;
            this.entregado = false;
            this.genero = genero;
            this.creador = creador;
        }

        public void Mostrardatos()
        {
            Console.WriteLine("TITULO: " + titulo);
            Console.WriteLine("NUMERO TEMPORADAS: " + numero_temporadas);
            Console.WriteLine("ENTREGADO: " + entregado);
            Console.WriteLine("GENERO: " + genero);
            Console.WriteLine("CREADOR: " + creador);
    }



    }//Serie


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ejercicio 1");
            Alumno alumno = new Alumno("Juan",25 );
            alumno.ImprimeAlumno();
            alumno.EsMayorEdad();
            
            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 2");
            Empleado empleado = new Empleado("Maria", 3500);
            empleado.ImprimeEmpleado();
            if (empleado.Sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos (sueldo > 3000)");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuestos (sueldo <= 3000)");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 3");
            Operacion op = new Operacion(15, 4);
            op.ImprimeValores();
            Console.WriteLine("La suma de los valores es: " + op.Suma());
            Console.WriteLine("La resta de los valores es: " + op.Resta());
            Console.WriteLine("La multiplicacion de los valores es: " + op.Multiplicacion());
            Console.WriteLine("La division de los valores es: " + op.Division());

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 4");
            Persona persona1 = new Persona("Juan");
            Persona persona2 = new Persona("Maria");
            persona1.Saludar();
            persona2.Saludar();

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 5");
            Libro libro = new Libro("Libro","Titulo","Ubicacion");

            Console.WriteLine("Asignando valores");
            libro.SetAutor("Libro X");
            libro.SetTitulo("Titulo Y");
            libro.SetUbicacion("Ubicacion Z");
            Console.WriteLine("Obteniendo valores");
            Console.WriteLine("Autor: " + libro.GetAutor); 
            Console.WriteLine("Titulo: " + libro.GetTitulo);
            Console.WriteLine("Ubicacion: "+ libro.GetUbicacion);

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 6");          
            Coche coche = new Coche("Toyota","Yaris",2,120);
            coche.MostrarDatosCoche();
            

            

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 7");
            Persona2 P = new Persona2("12345678G");
            Console.WriteLine("***  CONSTRUCTOR POR DEFECTO SOLO DNI *** ");
            P.Mostrardatos();
            Persona2 P2 = new Persona2("12345678A","Maria",30,'F');
            Console.WriteLine("***  CONSTRUCTOR CON DNI NOMBRE, EDAD, SEXO Y RESTO POR DEFECTO *** ");
            P2.Mostrardatos();
            Persona2 P3 = new Persona2("12345678B","Juan",25,'M',85,1.65);
            Console.WriteLine("***  CONSTRUCTOR CON TODOS LOS ATRIBUTOS COMO PARAMETRO *** ");
            P3.Mostrardatos();

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 8");
            Password Pass = new Password();
            Console.WriteLine("***  CONSTRUCTOR POR DEFECTO LONGITUD 8 *** ");
            Pass.Mostrardatos();
            Password Pass2 = new Password(4);
            Console.WriteLine("***  CONSTRUCTOR ENVIANDO LONGITUD *** ");
            Pass2.Mostrardatos();
            Password Pass3 = new Password(8);
            Console.WriteLine("***  CONSTRUCTOR ENVIANDO LONGITUD *** ");
            Pass3.Mostrardatos();

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 9");
            Electrodomestico E = new Electrodomestico();
            Console.WriteLine("***  CONSTRUCTOR POR DEFECTO ");
            E.Mostrardatos();
            Electrodomestico E2 = new Electrodomestico(200,10);
            Console.WriteLine("***  CONSTRUCTOR CON PRECIO Y PESO ");
            E2.Mostrardatos();
            Electrodomestico E3 = new Electrodomestico(150,"Rojo",'A',300);
            Console.WriteLine("***  CONSTRUCTOR CON TODOS LOS ATRIBUTOS ");
            E3.Mostrardatos();

            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio 10");
            Serie S = new Serie();
            Console.WriteLine("***  CONSTRUCTOR POR DEFECTO ");
            S.Mostrardatos();
            Serie S2 = new Serie("Juego de tronos", "David Benioff");
            Console.WriteLine("***  CONSTRUCTOR CON TITULO Y CREADOR ");
            S2.Mostrardatos();

            Serie S3 = new Serie("Juego de tronos",8,"Fantasia","David Benioff");
            Console.WriteLine("***  CONSTRUCTOR CON TODOS LOS ATRIBUTOS EXCEPTO ENTREGADO ");
            S3.Mostrardatos();

    


            //Para salir del programa
            Console.ReadKey();
        }
    }
}


/*
EJERCICIOS

1)
Plantear una clase llamada Alumno y definir como atributos su nombre y su edad.
En el constructor realizar la carga de datos. Definir otros dos métodos para
imprimir los datos ingresados y un mensaje si es mayor o no de edad (edad >=18)

2)
Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. En el constructor cargar los atributos y luego en otro método
imprimir sus datos y por último uno que imprima un mensaje si debe pagar
impuestos (si el sueldo supera a 3000)

3)
Implementar la clase operaciones. Se deben cargar dos valores enteros en el
constructor, calcular su suma, resta, multiplicación y división, cada una en un
método, imprimir dichos resultados.

4)
Crea una clase llamada Persona, en el fichero "persona.cs". Esta clase deberá
tener un atributo "nombre", de tipo string.
También deberá tener un método "SetNombre", de tipo void y con un parámetro
string, que permita cambiar el valor del nombre. Finalmente, también tendrá un
método "Saludar", que escribirá en pantalla "Hola, soy " seguido de su nombre.
Crea también una clase llamada PruebaPersona. Esta clase deberá contener sólo
la función Main, que creará dos objetos de tipo Persona, les asignará un nombre
a cada uno y les pedirá que saluden.

5)
Para guardar información sobre libros, vamos a comenzar por crear una clase
"Libro", que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos strings)
y métodos Get y Set adecuados para leer su valor y cambiarlo.
Prepara también un Main (en la misma clase), que cree un objeto de la clase
Libro, dé valores a sus tres atributos y luego los muestre.

6)
Crea una clase "Coche", con atributos "marca" (texto), "modelo" (texto),
"cilindrada" (número entero), potencia (número real). No hace falta que crees un
Main de prueba.
Prepara también un Main (en la misma clase), que cree un objeto de la clase
coche, dé valores a sus tres atributos y luego los muestre.

7)
Haz una clase llamada Persona que siga las siguientes condiciones:
• Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No
queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el
más adecuado, también su tipo. Si quieres añadir algún atributo puedes hacerlo.
• Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0
números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una
constante para ello.
• Se implantaran varios constructores:
o Un constructor por defecto.
o Un constructor con el nombre, edad y sexo, el resto por defecto.
o Un constructor con todos los atributos como parámetro.

8)
Haz una clase llamada Password que siga las siguientes condiciones:
• Que tenga los atributos longitud y contraseña . Por defecto, la longitud sera de 8.
• Los constructores serán los siguiente:
o Un constructor por defecto.
• Un constructor con la longitud que nosotros le pasemos. Generara una contraseña
aleatoria con esa longitud.

9)
Crearemos una clase llamada Electrodomestico con las siguientes características:
• Sus atributos son precio base, color, consumo energético (letras entre A y F) ypeso.
Indica que se podrán heredar.
• Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de 100
€ y el peso de 5 kg. Usa constantes para ello.
• Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta
en mayúsculas o en minúsculas.
• Los constructores que se implementaran serán
o Un constructor por defecto.
o Un constructor con el precio y peso. El resto por defecto.
o Un constructor con todos los atributos.

10)
Crearemos una clase llamada Serie con las siguientes características:
• Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
• Por defecto, el numero de temporadas es de 3 temporadas y entregado false. El resto
de atributos serán valores por defecto según el tipo del atributo.
• Los constructores que se implementaran serán:
o Un constructor por defecto.
o Un constructor con el titulo y creador. El resto por defecto.
o Un constructor con todos los atributos, excepto de entregado

*/
