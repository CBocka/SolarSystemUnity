# Mi Primer Proyecto en Unity

### Simulación sistema solar

Proyecto muy básico donde se han definido diferentes game objects del tipo primitivo esfera para modelar un sistema solar. 

Cada elemento de la escena tiene un material asignado creado a partir de una textura en formato imagen. El movimiento está implementado de manera descentralizada, con un script en C# que es asignado por igual a cada elemento al que nos interese dotar de movimiento.

El sol gira sobre sí mismo y cada planeta describe una órbita en torno a dicho elemento.

Cada planeta tiene una escala y una velocidad de rotación diferentes.

También se incluye, aunque no es utilizada, una implementación del movimiento de manera centralizada, usando un script C# algo más complejo y que es asignado a un game object vacío al que se ha denominado Controller.

<br>
<p align="center">
<img src="https://github.com/CBocka/SolarSystemUnity/assets/156449965/315ae535-ef8e-4e77-ac21-dfc4143bc432" height="450" width="220" >
</p>
<br>

