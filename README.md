# Practica Bits y Bytes

Archivo con el codigo: [Form1.cs](Practica1_Bits/Form1.cs)

Manipular de manera individual los bits de un dato leído del usuario, al procesar el numero, solo se trabajara con los 3 bytes mas bajos, el primero se forma por:
- bit 7 sensor 1 encendido/apagado
- bit 6 sensor 2 encendido/apagado
- bit 5,4 Nivel de tanque (0-vacio, 1- nivel medio, 2-lleno, 3 - proceso de llenado)
- bit 3,2,1 Dirección de movimiento ( de 0 a 7 -> N, NE, E, SE, S, SO, O, NO)
- bit 0 no se utiliza
- los bytes 2 y 3 representan la fecha que arroja el objeto y los 16 bits representan esta información tomando como año base 1900
a a a a a a a m m m m d d d d d

El usuario podrá modificar la fecha en la segunda pare del formulario y para esto hay que generar un numero que represente la fecha que se eligió basada en la representación de datos de arriba. Si el usuario selecciona 2 de febrero de 2017
1110101 0010 00010 mostrar 59970
