#  Introducción a la programación de juegos 2D. Mapa - Físicas

El informe de esta práctica se divide en dos partes:

 - Por un lado, analizar los diferentes casos propuestos acerca de la interacción de objetos 2D mediante físicas usando el motor de Unity.
 
 - Por otro lado, añadir tilemaps para crear una zona de juego con decoración y obstáculos en el proyecto anterior acerca de sprites.

## Interacciones de objetos 2D con físicas en Unity

Para realizar estos experimentos, se ha creado un nuevo proyecto con una escena que está compuesta por dos GameObject en 2D (círculos) y un suelo creado con un RigidBody estático. Estos dos círculos serán los encargados de interactuar con las físicas en cada uno de los casos y de aportar información de las colisiones a partir de la consola mediante varios scripts que lo permiten según su tipo de RigidBody (Dinámico, Estático, isTrigger y cinemático).

**Caso 1: Ninguno de los objetos es físico.**

En este primer caso no se añade ningún tipo de física a ninguno de los objetos. Al ejecutar, ambos permanecen estáticos y no dan ninguna información en la consola.

gif 1

**Caso 2: Un objeto tiene físicas y el otro no**

Aquí, el objeto con físicas cae y traspasa al otro, sin colisionar ni dar ninguna información en pantalla debido a que el otro objeto no tiene ningún componente de físicas atribuido.

gif 2

**Caso 3: Ambos objetos tienen físicas**

En este caso, ambos objetos chocan al caer. En la consola aparece que ambos han  colisionado.

gif 3

**Caso 4: Ambos objetos tienen físicas y uno de ellos tiene 10 veces más masa que el otro**

Para lograr esto, se ha añadido una mayor cantidad de masa (10) al objeto 1 mediante el inspector.

img 1

Al ejecutar, ambos objetos colisionan y muestran el mensaje en la consola como en el anterior caso. Sin embargo, esta vez el objeto con mayor masa sale disparado a mayor velocidad.

gif 4

**Caso 5: Un objeto tiene físicas y el otro es IsTrigger**

Aquí, el objeto con físicas dinámicas traspasa al isTrigger, sin detectarlo en la consola. Sin embargo, el objeto2 si que lo detecta y muestra el mensaje.

gif 5

**Caso 6: Ambos objetos son físicos y uno de ellos está marcado como IsTrigger**

A diferencia del anterior caso, esta vez el objeto isTrigger también cae ya que tiene físicas, sin embargo, sigue traspasando al otro objeto. En la consola, se sigue mostrando solamente el mensaje del objeto con trigger activado.

gif 6

**Caso 7: Uno de los objetos es cinemático**

Para este último caso, el objeto cinemático se queda estático mientras que, el dinámico, se mueve. Ambos detectan la colisión en la consola.

gif 7

## Elementos físicos e interacciones

**Caso 1: Objeto estático que ejerce de barrera infranqueable**

Para esto, se ha usado de ejemplo el GameObject con RigidBody estático que se usaba como suelo hasta ahora. El objeto dinámico cae, pero este otro no lo deja pasar.

gif 8

**Caso 2: Zona en la que los objetos que caen en ella son impulsados hacia adelante**

Aquí, se ha usado un nuevo GameObject rectangular que delimita dicha zona. Se le ha añadido el componente Area Effector 2D con una magnitud de 10, de forma que desplaza a los objetos dinámicos hacia la derecha.

gif 9

**Caso 3: Objeto que es arrastrado por otro a una distancia fija**

Para conseguir este efecto, se ha añadido el componente Distance Joint 2D a uno de los objetos, de forma que se pueda unir con el otro mediante su rigidbody.

img 2

El objeto con este componente se ha unido a uno estático, de forma que al caer, crea un efecto de péndulo de un reloj.

gif 10

**Caso 4: Objeto que al colisionar con otros sigue un comportamiento totalmente físico**

Aquí, se ha creado un Physics Material 2D y se ha agregado a uno de los objetos con el fin de crear un comportamiento totalmente físico.

img 3

Cuando se ejecuta, vemos que el objeto comienza a botar entre los muros establecidos como si fuera una pelota.

gif 11

**Caso 5: Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos**

Para conseguir que ambos objetos eviten colisionar, primero se crean dos capas y se añaden respectivamente a cada uno de los objetos.

img 4

Luego, en el apartado de Project Settings, justo donde aparece Layer Collision Matrix, se desmarca el cruce entre las dos capas creadas para evitar que los objetos en dichas capas colisionen

img 5

Se puede ver en el efecto final como ambos objetos colisionan con el suelo, sin embargo, no lo hacen entre ellos y se traspasan.

gif 12

## Tilemaps y zona de juego 2D

Para esta parte de la práctica, se ha continuado con la escena del proyecto de Sprites y movimiento 2D.

Para empezar, se ha creado un Grid que contiene un tilemap principal, que se usó para delimitar la zona de juego. Para ello, se creó una nueva paleta destinada a esto y ubicada en la capa 0, de forma que la zona jugable sea la base del mapa. Se establecieron varios elementos extraídos de los recursos del aula virtual a modo de barrera visual para establecer los límites del mapa. El resultado inicial es el siguiente:

img 6

Para continuar con la práctica, se han creado dos tilemaps nuevos dentro del grid principal: uno para elementos decorativos (capa 1) y otro para obstáculos, que se encuentran en la capa 2 para que sean los más visibles. Se crean paletas nuevas para añadir los elementos necesarios y se consigue este resultado:

img7

Por último, se actualiza el script inicial de controlador del jugador para crear un movimiento up and down y poder moverse correctamente por el mapa diseñado. Para lograr esto, se ha usado un `Input.GetAxis("Vertical")`. Tras acabar esto y añadirle una caja de colisión al personaje, el resultado final es el siguiente:

gif 13 
