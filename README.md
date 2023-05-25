
# Solución para Coding Challenge IOL 

Como solución a este problema hice que FormaGeométrica sea una clase abstracta y que las formas hereden esa clase padre, con sus méotodos, como CalcularArea() y CalularPerimetro(), de esta manera cada figura tendría su propio calculo de cada método. Además, separé las responsabilidades, de tal manera que esté desacoplado, separando los reportes y las figuras. 

Con respecto a los idiomas, creé una nueva clase llamada Idiomas. Para la definición de los lenguajes, tenía mis dudas en utilizar una tupla o un diccionario de datos. Por lo que opté por utilizar una tupla, ya que se utiliza solo para guardar los lenguajes, van a ser datos que no van a modificarse a futuro, además, de que una tupla me parece una manera más simple. La clase Idiomas, contiene un tupla de Lenguajes, en donde, cada lenguaje contará con un archivo de recursos el cual contedrá cada una de las traducciones. De esta manera, en el caso de que se desee agregar un nuevo idioma, a nivel código solo se deberá agregar un elemento a la tupla. Mientras que para las traducciones, se deberá crear un nuevo archivo de recurso. 

Por otra parte, para calcular las variables de cada figura, creé otra clase abstracta llamada Reporte. De tal manera, que se trate como una clase padre sobre una subclase llamada Generador, el cual implementa el método Imprimir(). 

### Comentarios

Tuve que realizar una actualización de los paquetes nuget.

Desde ya, muchas gracias por la oportunidad de realizar el Challenge. 

**¡¡Saludos!!**
