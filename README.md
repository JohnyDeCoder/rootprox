<br />
<div align="center">
  <a href="https://ibb.co/6sM04Rh">
    <img src="https://i.ibb.co/RHFTCpn/ROOTPROX-logo-colorfull.png" alt="ROOTPROX-logo-colorfull" border="0" width="50%" height="50%">
  </a>

  <h1 align="center">ROOTPROX ₂₀₂₂</h1>

  <p align="center">
    <i>ROOTPROX es una calculadora de ecuaciones no lineales por el método de bisección, secante y regla falsa.</i>
    <br />
    <br />
    <a href="https://github.com/JohnyDeCoder/rootprox/issues">Reportar Bug</a>
    ·
    <a href="https://github.com/JohnyDeCoder/rootprox/issues">Solicitar Función</a>
  </p>
</div>

<details>
  <summary>Tabla de Contenidos</summary>
  <ol>
    <li>
      <a href="#acerca-del-proyecto">Acerca del Proyecto</a>
      <ul>
        <li><a href="#características">Características</a></li>
        <li><a href="#construido-con">Construido con</a></li>
      </ul>
    </li>
    <li>
      <a href="#comenzando">Comenzando</a>
      <ul>
        <li><a href="#pre-requisitos">Pre-requisitos</a></li>
        <li><a href="#instalación">Instalación</a></li>
      </ul>
    </li>
    <li><a href="#contribuyendo">Contribuyendo</a></li>
    <li><a href="#guía-de-uso">Guía de Uso</a></li>
    <li><a href="#versionado">Versionado</a></li>
    <li><a href="#autores">Autores</a></li>
    <li><a href="#licencia">Licencia</a></li>
    <li><a href="#agradecimientos">Agradecimientos</a></li>
  </ol>
</details>

## Acerca del proyecto

### Características

* Calcula prácticamente "cualquier" función
* Funciones trigonométricas incluidas
* Margen de error mínimo en el cálculo

### Construido con

* [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
* [FontAwesome.Sharp v5.15.4](http://www.dropwizard.io/1.0.2/docs/)
* [AngouriMath for C#](https://am.angouri.org/)

## Comenzando

Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas.

### Pre-requisitos

* [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
* [FontAwesome.Sharp v5.15.4](http://www.dropwizard.io/1.0.2/docs/)
* [AngouriMath for C#](https://am.angouri.org/)

### Instalación

1. Clona el repositorio
   ```sh
   git clone https://github.com/JohnyDeCoder/rootprox.git
   ```
2. Abre el archivo `rootprox-2022.sln`
3. Listo

## Contribuyendo

* Usamos [LiveShare](https://visualstudio.microsoft.com/es/services/live-share/) por parte de los desarolladores de la aplicación para el desarrollo colaborativo en tiempo real.
* Por el momento, **NO** se aceptan contribuciones externas o pull requests, pero puedes bifurcar (Fork) este repositorio.

## Guía de Uso

Esta guía te ayudará a familiarizarte con la aplicación de manera sencilla.

### Panel lateral izquierdo
* Dentro del **panel lateral izquierdo** se muestra una serie de botones cuyas funciones son las siguientes:

#### Métodos
* Esta sección te ayuda a resolver problemas de ecuaciones por métodos.
* _Al hacer "click" se desplegará un **submenú** en el cual hay 3 métodos disponibles:_

1. Bisección
2. Secante
3. Regla Falsa

* **NOTA IMPORTANTE:** _A PARTIR DE ESTA NOTA, LOS BOTONES DE OPCIONES, CASILLAS, CUADROS DE TEXTO Y TABLA DE RESULTADOS **APLICARÁ GLOBALMENTE** EN TODOS LOS MÉTODOS_

#### Botones en los métodos
* **Calcular** - _Toma los valores de los campos de texto que introduzca_
* **Reiniciar** - _Limpia los valores y campos de texto_
* **ℯ** - _Imprime la letra de ℯ (euler) en el campo de la función (f(x))_
* **^** - _Imprime la signo de ^ (potencia) en el campo de la función (f(x))_
* **Signos** - _Abre el **MAPA DE SÍMBOLOS MATEMÁTICOS** donde encontrará todos los símbolos, como las operaciones aritméticas y las funciones trigonométricas entre otras. Al hacer "click" en cualquier signo, lo imprimirá al campo de la función (f(x))_

#### Casillas de verificación y botones circulares
##### Casillas
* **Sin Factor de Paroᴮᴱᵀᴬ** - _Usa **únicamente** como límite el número máximo de iteraciones (puede ocasionar errores*)_

##### Botones circulares en TIPO DE RESULTADO
* **Normal** - _No se alteran los resultados (puede ser largo)_
* **Redondear decimales** - _Toma número del **cuadro de números** de la derecha del botón circular y redondea los todos los resultados obtenidos al número que establezca, **NO** AFECTA EL RESULTADO, EL RESULTADO SIGUE SIENDO EL MISMO SIEMPRE (por ejemplo, sí el resultado es 1.4 no se redondea, en cambio si el decimal es mayor que 5 entonces el resultado de 1.5 sería 2)_

###### Campos de texto y tabla de resultados
* **Campos o cuadros de texto** - _Se **introducen símbolos / sígnos (euler, potencia, etc) y números** positivos, negativos, enteros y/o decimales que serán necesarios para llevar a cabo el cálculo_
* **Tabla de resultados** - _La tabla más pequeña (localizada en la parte inferior del "Factor de Paro") muestra el **último** resultado obtenido del cálculo, mientras que la tabla más grande (localizada en la parte inferior) muestra **todos** los resultados obtenidos del cálculo_

#### Ayuda
* Esta sección te ayuda a resolver problemas de ecuaciones por métodos.
* _Al hacer "click" se desplegará un **submenú** en el cual hay 3 métodos disponibles:_

##### **Guía de Uso**
* _El botón te redirigirá a esta guía de uso para usuarios para saber cómo utilizar o cómo funciona cada una de las partes de la aplicación_

##### **Cambiar Tema**
* _Se desplegará un **submenú** con todos los temas (colores) disponibles, elija el que más le agrade ;)_

* _**NOTA IMPORTANTE:** LA APLICACIÓN ES UN TRABAJO ACADÉMICO Y DEBE TOMARSE COMO TAL, NI EL LOGOTIPO NI LA APLICACIÓN ESTÁN REGISTRADOS ACTUALMENTE, **SOLO DEBERÁ USARSE PARA FINES ACADÉMICOS**_

##### **Acerca de**
* _Se abrirá una nueva ventana con los datos de los creadores de la aplicación y un pequeño mensaje que debe cumplirse_

#### Lanzamientos
* _Te redirigirá a los [tags de este repositorio](https://github.com/JohnyDeCoder/rootprox/tags) que son versiones disponibles para descargar y usar_

### Salir
* _Se cerrará la aplicación_

## Versionado

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags de este repositorio](https://github.com/JohnyDeCoder/rootprox/tags).

## Autores

* **Johny Mora** - *Trabajo Inicial y Documentación* - [JohnyDeCoder](https://github.com/JohnyDeCoder)
* **Brandon Moran** - *Colaborador* - [BrandonMoran11](https://github.com/BrandonMoran11)

## Licencia

Este proyecto está bajo la Licencia GNU General Public License v3.0 - mira el archivo `LICENSE` para más información

## Agradecimientos
* [Font Awesome](https://fontawesome.com)
* [README-Plantilla](https://github.com/othneildrew/Best-README-Template)
* [AngouriMath](https://github.com/asc-community/AngouriMath)

<p align="right">(<a href="#top">regresar al inicio</a>)</p>
