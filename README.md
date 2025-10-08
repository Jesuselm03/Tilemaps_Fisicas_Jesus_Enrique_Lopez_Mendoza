#  Introducción a la programación de juegos 2D. Mapa - Físicas

El informe de esta práctica se divide en dos partes:

 - Por un lado, analizar los diferentes casos propuestos acerca de la interacción de objetos 2D mediante físicas usando el motor de Unity.
 
 - Por otro lado, añadir tilemaps para crear una zona de juego con decoración y obstáculos en el proyecto anterior acerca de sprites.

## Interacciones de objetos 2D con físicas en Unity

Para realizar estos experimentos, se ha creado un nuevo proyecto con una escena que está compuesta por dos GameObject en 2D (círculos) y un suelo creado con un RigidBody estático. Estos dos círculos serán los encargados de interactuar con las físicas en cada uno de los casos y de aportar información de las colisiones a partir de la consola mediante varios scripts que lo permiten según su tipo de RigidBody (Dinámico, Estático, isTrigger y cinemático).

**Caso 1: Ninguno de los objetos es físico.**

En este primer caso no se añade ningún tipo de física a ninguno de los objetos. Al ejecutar, ambos permanecen estáticos y no dan ninguna información en la consola.

![gif1](https://github.com/user-attachments/assets/29dc97a7-1dcd-41fd-9558-0f2cc05a8200)

**Caso 2: Un objeto tiene físicas y el otro no**

Aquí, el objeto con físicas cae y traspasa al otro, sin colisionar ni dar ninguna información en pantalla debido a que el otro objeto no tiene ningún componente de físicas atribuido.

![gif2](https://github.com/user-attachments/assets/694da3c3-a869-4a2e-994b-4a8bcc7ad0a4)

**Caso 3: Ambos objetos tienen físicas**

En este caso, ambos objetos chocan al caer. En la consola aparece que ambos han  colisionado.

![gif3](https://github.com/user-attachments/assets/8f4e00e0-24d7-4a9a-bb76-cc65c47d13f7)

**Caso 4: Ambos objetos tienen físicas y uno de ellos tiene 10 veces más masa que el otro**

Para lograr esto, se ha añadido una mayor cantidad de masa (10) al objeto 1 mediante el inspector.

<img width="1918" height="1078" alt="img1" src="https://github.com/user-attachments/assets/5d115403-4149-4162-84f4-a390fbd3cf4c" />

Al ejecutar, ambos objetos colisionan y muestran el mensaje en la consola como en el anterior caso. Sin embargo, esta vez el objeto con mayor masa sale disparado a mayor velocidad.

![gif4](https://github.com/user-attachments/assets/9b3fc90b-f995-47be-8355-1e2aad0803dc)

**Caso 5: Un objeto tiene físicas y el otro es IsTrigger**

Aquí, el objeto con físicas dinámicas traspasa al isTrigger, sin detectarlo en la consola. Sin embargo, el objeto2 si que lo detecta y muestra el mensaje.

![gif5](https://github.com/user-attachments/assets/6fe7130a-93c1-4b12-b2ba-75a1c007db27)

**Caso 6: Ambos objetos son físicos y uno de ellos está marcado como IsTrigger**

A diferencia del anterior caso, esta vez el objeto isTrigger también cae ya que tiene físicas, sin embargo, sigue traspasando al otro objeto. En la consola, se sigue mostrando solamente el mensaje del objeto con trigger activado.

![gif6](https://github.com/user-attachments/assets/099077e3-9f83-4c5e-b2c9-9d63436eb56c)

**Caso 7: Uno de los objetos es cinemático**

Para este último caso, el objeto cinemático se queda estático mientras que, el dinámico, se mueve. Ambos detectan la colisión en la consola.

![gif7](https://github.com/user-attachments/assets/656f6a56-e438-40a2-90ac-943998ba2a68)

## Elementos físicos e interacciones

**Caso 1: Objeto estático que ejerce de barrera infranqueable**

Para esto, se ha usado de ejemplo el GameObject con RigidBody estático que se usaba como suelo hasta ahora. El objeto dinámico cae, pero este otro no lo deja pasar.

![gif8](https://github.com/user-attachments/assets/d31ec5ec-c58a-4950-ad9b-8e872f900a4f)

**Caso 2: Zona en la que los objetos que caen en ella son impulsados hacia adelante**

Aquí, se ha usado un nuevo GameObject rectangular que delimita dicha zona. Se le ha añadido el componente Area Effector 2D con una magnitud de 10, de forma que desplaza a los objetos dinámicos hacia la derecha.

![gif9](https://github.com/user-attachments/assets/285a1cd3-b50d-49f5-812b-31395d8dabed)

**Caso 3: Objeto que es arrastrado por otro a una distancia fija**

Para conseguir este efecto, se ha añadido el componente Distance Joint 2D a uno de los objetos, de forma que se pueda unir con el otro mediante su rigidbody.

<img width="576" height="286" alt="img2" src="https://github.com/user-attachments/assets/ccf12d5d-97cf-431a-b012-fb3e0511e957" />

El objeto con este componente se ha unido a uno estático, de forma que al caer, crea un efecto de péndulo de un reloj.

![gif10](https://github.com/user-attachments/assets/4dbc6994-a124-4780-a0e5-916245c2d184)

**Caso 4: Objeto que al colisionar con otros sigue un comportamiento totalmente físico**

Aquí, se ha creado un Physics Material 2D y se ha agregado a uno de los objetos con el fin de crear un comportamiento totalmente físico.

<img width="132" height="141" alt="img3" src="https://github.com/user-attachments/assets/2e8c81de-a44f-4ffc-b850-8fc395ba76d5" />

Cuando se ejecuta, vemos que el objeto comienza a botar entre los muros establecidos como si fuera una pelota.

![gif11](https://github.com/user-attachments/assets/a6c94655-c839-4aef-8db9-9f8a871cc147)

**Caso 5: Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos**

Para conseguir que ambos objetos eviten colisionar, primero se crean dos capas y se añaden respectivamente a cada uno de los objetos.

<img width="586" height="702" alt="img4" src="https://github.com/user-attachments/assets/c0cf3f90-624f-41c4-80a3-211ea15efddc" />

Luego, en el apartado de Project Settings, justo donde aparece Layer Collision Matrix, se desmarca el cruce entre las dos capas creadas para evitar que los objetos en dichas capas colisionen

<img width="1635" height="332" alt="img5" src="https://github.com/user-attachments/assets/43673b2b-90df-4db9-9b9d-b82cf88d9939" />

Se puede ver en el efecto final como ambos objetos colisionan con el suelo, sin embargo, no lo hacen entre ellos y se traspasan.

![gif12](https://github.com/user-attachments/assets/32e9b224-93fe-4620-b319-e05900278c1f)

## Tilemaps y zona de juego 2D

Para esta parte de la práctica, se ha continuado con la escena del proyecto de Sprites y movimiento 2D.

Para empezar, se ha creado un Grid que contiene un tilemap principal, que se usó para delimitar la zona de juego. Para ello, se creó una nueva paleta destinada a esto y ubicada en la capa 0, de forma que la zona jugable sea la base del mapa. Se establecieron varios elementos extraídos de los recursos del aula virtual a modo de barrera visual para establecer los límites del mapa. El resultado inicial es el siguiente:

<img width="1918" height="1078" alt="img6" src="https://github.com/user-attachments/assets/adea7c34-70c0-41d2-ac99-006e130847e0" />

Para continuar con la práctica, se han creado dos tilemaps nuevos dentro del grid principal: uno para elementos decorativos (capa 1) y otro para obstáculos, que se encuentran en la capa 2 para que sean los más visibles. Se crean paletas nuevas para añadir los elementos necesarios y se consigue este resultado:

<img width="1918" height="1078" alt="img7" src="https://github.com/user-attachments/assets/8d807d62-5960-4120-b75a-83b04eebf479" />

Por último, se actualiza el script inicial de controlador del jugador para crear un movimiento up and down y poder moverse correctamente por el mapa diseñado. Para lograr esto, se ha usado un `Input.GetAxis("Vertical")`. Tras acabar esto y añadirle una caja de colisión al personaje, el resultado final es el siguiente:


![gif13](https://github.com/user-attachments/assets/c9ed462d-a04a-4325-ac95-786e0ac3bb88)
