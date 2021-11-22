# Práctica 5 - Micrófono y cámara

> Gabriel García Jaubert
>
> Universidad de La Laguna
>
> 22 de noviembre de 2021
>
> https://github.com/alu0101240374/II_P5.git

En esta práctica se nos pide reconocer la voz del usuario. Para ello utilizaremos las librerías de Windows Speech de KeywordRecognizer y DictationRecognizer.

## Funcionamiento del programa

Para ver el funcionamiento del proyecto, vea este vídeo:  

[youtube]()

Gifs:  



## KeywordRecognizer

El funcionamiento de KeywordRecognizer es muy simple. El objeto se crea con un array de Strings que nosotros proporcionamos como argumento, este array contiene las 'keywords' que queremos que detecte. También debemos añadir la función que queremos que se active cuando reconozca alguna palabra clave. En este caso, la función imprime en el texto 3D la palabra reconocida, además, si coincide con la palabra 'rojo' o 'azul', el color del coche cambia. Esto se consigue con el objeto 'args'. Este objeto a su vez tiene el atributo text, que contiene el valor de la palabra que ha reconocido, de modo que, si el valor de 'args.text' es igual a azul, rojo u otro color que elijamos, cambiaremos el color del material de la malla del coche.

## DictationRecognizer

El funcionamiento de dictationRecognizer es similar. Creamos el objeto, y en este caso, tenemos que añadir dos funciones en vez de una. La primera función será 'DictationResult' que será la función que se ejecute cuando termine de reconocer la oración. Esta función recibe como parámetros el texto reconocido y la certeza. La otra función  es 'DictationHypothesis' que funciona exactamente igual, pero se ejecuta cada vez que reconoce un sonido, no como 'DictationResult', que sólo es al final. Estas dos funciones cambian el texto del objeto 3D que se encuentra en la pantalla del cine.

## GameController

El GameController que se usó para esta práctica es bien simple. Dos cubos transparentes son los encargados de ejecutar las herramientas. Cuando el jugador entre en uno, al ser trigger, la función 'OnTriggerEnter' se ejecutará, y esta avisará al controlador del juego, para que active el evento de que el jugador ha entrado al cubo. Al igual ocurre cuando el jugador sale del cubo, para parar la ejecución del Recognizer. 
